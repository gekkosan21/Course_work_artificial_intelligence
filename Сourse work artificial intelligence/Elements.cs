using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сourse_work_artificial_intelligence
{
    internal class Elements
    {
        public double _shipLenght = 35.0;   // Длина корабля
        public double _shipWidth = 7.2;     // Ширина корабля
        public double _shipDraught = 3.0;   // Осадка корабля
        public double _metaHeight = 0.47;   // Метацентрическая высота
        public double _shipSpeed = 11.0;    // Скорость корабля
        public double _waveLenght = 35.0;   // Длина волны
        public double _tetaM = 15;          // Амплитуда качки тета
        public double _psiM = 3;            // Амплитуда качки пси

        // Исходные оценки вероятностей
        public double PE = 0.67;
        public double PHE = 0.73;
        public double PHnotE = 0.03;
        public double MDHE1 = 0.83;
        public double MDHE2 = 0.85;

    }
}
