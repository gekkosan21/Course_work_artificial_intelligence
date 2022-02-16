namespace Сourse_work_artificial_intelligence
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBx_teta = new System.Windows.Forms.TextBox();
            this.tBx_psi = new System.Windows.Forms.TextBox();
            this.tBx_crsAngl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert_params = new System.Windows.Forms.Button();
            this.pcb_Diagram = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbResultText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Byeiss = new System.Windows.Forms.TextBox();
            this.txb_Shortliff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Diagram)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBx_teta
            // 
            this.tBx_teta.Location = new System.Drawing.Point(15, 35);
            this.tBx_teta.Name = "tBx_teta";
            this.tBx_teta.Size = new System.Drawing.Size(100, 20);
            this.tBx_teta.TabIndex = 0;
            // 
            // tBx_psi
            // 
            this.tBx_psi.Location = new System.Drawing.Point(15, 74);
            this.tBx_psi.Name = "tBx_psi";
            this.tBx_psi.Size = new System.Drawing.Size(100, 20);
            this.tBx_psi.TabIndex = 1;
            // 
            // tBx_crsAngl
            // 
            this.tBx_crsAngl.Location = new System.Drawing.Point(15, 118);
            this.tBx_crsAngl.Name = "tBx_crsAngl";
            this.tBx_crsAngl.Size = new System.Drawing.Size(100, 20);
            this.tBx_crsAngl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Амплитуда бортовой качки (тэта)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Амплитуда килевой качки (пси)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Курсовой угол";
            // 
            // btn_insert_params
            // 
            this.btn_insert_params.Location = new System.Drawing.Point(15, 145);
            this.btn_insert_params.Name = "btn_insert_params";
            this.btn_insert_params.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_params.TabIndex = 6;
            this.btn_insert_params.Text = "Ввод";
            this.btn_insert_params.UseVisualStyleBackColor = true;
            this.btn_insert_params.Click += new System.EventHandler(this.btn_insert_params_Click);
            // 
            // pcb_Diagram
            // 
            this.pcb_Diagram.BackgroundImage = global::Сourse_work_artificial_intelligence.Properties.Resources.diagram;
            this.pcb_Diagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_Diagram.Location = new System.Drawing.Point(6, 19);
            this.pcb_Diagram.Name = "pcb_Diagram";
            this.pcb_Diagram.Size = new System.Drawing.Size(434, 206);
            this.pcb_Diagram.TabIndex = 7;
            this.pcb_Diagram.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "12    10     8      6      4      2      0";
            // 
            // txbResultText
            // 
            this.txbResultText.Location = new System.Drawing.Point(317, 275);
            this.txbResultText.Multiline = true;
            this.txbResultText.Name = "txbResultText";
            this.txbResultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResultText.Size = new System.Drawing.Size(434, 105);
            this.txbResultText.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcb_Diagram);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диаграмма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вероятность по формуле Байеса";
            // 
            // txb_Byeiss
            // 
            this.txb_Byeiss.Location = new System.Drawing.Point(13, 301);
            this.txb_Byeiss.Name = "txb_Byeiss";
            this.txb_Byeiss.ReadOnly = true;
            this.txb_Byeiss.Size = new System.Drawing.Size(198, 20);
            this.txb_Byeiss.TabIndex = 12;
            // 
            // txb_Shortliff
            // 
            this.txb_Shortliff.Location = new System.Drawing.Point(13, 359);
            this.txb_Shortliff.Name = "txb_Shortliff";
            this.txb_Shortliff.ReadOnly = true;
            this.txb_Shortliff.Size = new System.Drawing.Size(198, 20);
            this.txb_Shortliff.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вероятность по формуле Шортлиффа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Shortliff);
            this.Controls.Add(this.txb_Byeiss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbResultText);
            this.Controls.Add(this.btn_insert_params);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBx_crsAngl);
            this.Controls.Add(this.tBx_psi);
            this.Controls.Add(this.tBx_teta);
            this.Name = "Form1";
            this.Text = "control of resonance";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Diagram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBx_teta;
        private System.Windows.Forms.TextBox tBx_psi;
        private System.Windows.Forms.TextBox tBx_crsAngl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert_params;
        private System.Windows.Forms.PictureBox pcb_Diagram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbResultText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Byeiss;
        private System.Windows.Forms.TextBox txb_Shortliff;
        private System.Windows.Forms.Label label6;
    }
}

