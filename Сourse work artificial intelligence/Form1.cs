using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сourse_work_artificial_intelligence.Properties;

namespace Сourse_work_artificial_intelligence
{
    public partial class Form1 : Form
    {
        Elements elements = new Elements();
        public Form1()
        {
            InitializeComponent();
        }

        double teta;
        double psi;
        double courseAngle;

        private void btn_insert_params_Click(object sender, EventArgs e)
        {
            try
            {
                teta = Convert.ToDouble(tBx_teta.Text);
                psi = Convert.ToDouble(tBx_psi.Text);
                courseAngle = Convert.ToDouble(tBx_crsAngl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вводимые данные некорректны.");
            }

            Calculating();

        }

        double pm1_1, pm1_2;
        double pm2_1, pm2_2;
        double pm3_1, pm3_2;
        const double HIGHT=5;
        Graphics currentPoint;
        private void Calculating()
        {
            currentPoint = pcb_Diagram.CreateGraphics();
            double spdRnWv = 1.25 * Math.Pow(elements._waveLenght, 0.5);

            pm1_1 = spdRnWv - elements._waveLenght / (0.8 * 0.8 * elements._shipWidth / Math.Pow(elements._metaHeight, 0.5));
            pm1_2 = spdRnWv - elements._waveLenght / (1.2 * 0.8 * elements._shipWidth / Math.Pow(elements._metaHeight, 0.5));

            pm2_1 = spdRnWv - elements._waveLenght / (1.85 * 0.8 * elements._shipWidth / Math.Pow(elements._metaHeight, 0.5));
            pm2_2 = spdRnWv - elements._waveLenght / (2.15 * 0.8 * elements._shipWidth / Math.Pow(elements._metaHeight, 0.5));

            pm3_1 = spdRnWv - elements._waveLenght / (0.8 * 2.5 * Math.Pow(elements._shipDraught, 0.5));
            pm3_2 = spdRnWv - elements._waveLenght / (1.2 * 2.5 * Math.Pow(elements._shipDraught, 0.5));

            //Расчёт вероятностей по формулам
            double baiess = elements.PHE * elements.PE + elements.PHnotE * (1 - elements.PE) 
                + (1 - elements.PHE) * elements.PE + elements.PHE * (1 - elements.PE);       //Формула Байеса
            double shortlif = elements.MDHE1 + elements.MDHE2 * (1 - elements.MDHE1);        //Формула Шортлиффа
            double medium = (baiess + shortlif) / 2;                                         //средняя ариф. вероятность

            txb_Byeiss.Text = baiess.ToString();
            txb_Shortliff.Text = shortlif.ToString();
            double r = elements._shipSpeed * Math.Cos(courseAngle / 180 * Math.PI);
            double x = r;
            double y = elements._shipSpeed * Math.Sin(courseAngle / 180 * Math.PI);

            int knot = 32;
            int x_c = (int)(pcb_Diagram.Width / 2) - 7;
            int y_c = pcb_Diagram.Height;

            Point centerPoint = new Point(x_c, y_c);

            Point test = new Point((int)(x_c - x * knot / 2), (int)(y_c - y * knot / 2));

            Rectangle mainResonanse = new Rectangle((int)(x_c-pm1_2*knot/2), 0, (int)Math.Abs((pm1_1-pm1_2) * knot / 2), pcb_Diagram.Height);
            Rectangle paramResonanse = new Rectangle((int)(x_c-pm2_2 * knot / 2), 0, (int)Math.Abs((pm2_1 - pm2_2) * knot / 2), pcb_Diagram.Height);
            Rectangle kievResonance = new Rectangle((int)(x_c-pm3_2 * knot / 2), 0, (int)Math.Abs((pm3_1 - pm3_2) * knot / 2), pcb_Diagram.Height);

            Pen brush = new Pen(Color.Red, 3);
            Pen brush2 = new Pen(Color.Green, 3);

            SolidBrush zone1 = new SolidBrush(Color.FromArgb(128, 102, 0, 204));
            SolidBrush zone2 = new SolidBrush(Color.FromArgb(128, 0, 102, 204));
            SolidBrush zone3 = new SolidBrush(Color.FromArgb(128, 255, 255, 51));


            pcb_Diagram.Refresh();

            currentPoint.FillRectangle(zone1, mainResonanse);
            currentPoint.FillRectangle(zone2, paramResonanse);
            currentPoint.FillRectangle(zone3, kievResonance);

            //Определение типа резонанса
            if (teta > elements._tetaM && r >= pm1_1 && r <= pm1_2)
            {
                
                txbResultText.Text="По имеющимся данным есть основной резонанс бортовой качки с вероятностью "+medium +"."+ 
                Environment.NewLine + "Измените курсовой угол, используя диаграмму качки.";
                currentPoint.DrawLine(brush, centerPoint, test);
            }
            else if (teta > elements._tetaM && r >= pm2_1 && r <= pm2_2)
            {

                txbResultText.Text = "По имеющимся данным есть параметрический резонанс бортовой качки с вероятностью " + medium + "." +
                Environment.NewLine + "Измените курсовой угол, используя диаграмму качки.";
                currentPoint.DrawLine(brush, centerPoint, test);
            }
            else if (psi > elements._psiM && r >= pm3_1 && r <= pm3_2)
            {

                txbResultText.Text = "По имеющимся данным есть основной резонанс килевой качки с вероятностью " + medium + "." +
                Environment.NewLine + "Измените курсовой угол, используя диаграмму качки.";
                currentPoint.DrawLine(brush, centerPoint, test);
            }
            else
            {
                txbResultText.Text = "Резонансных качек не выявленно." +
                Environment.NewLine + "Изменение курса не требуется.";
                currentPoint.DrawLine(brush2, centerPoint, test);
            }



        }


    }
}
