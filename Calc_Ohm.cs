using System;
using System.Collections.Generic;
using System.Text;

namespace Ohm
{
    class CalcOhmTensao
    {

        public double i; // corrente
        public double r; // resistencia
        public double v()
        {
            return i * r;
        }

    }
    class CalcOhmCor
    {
        public double t;// tensão
        public double r;// resistencia
        public double c()
        {
            return t / r;

        }
    }
    class CalcOhmRes
    {
        public double t;// tensao
        public double i;// entrada de corrente
        public double r()
        {
            return t / i;
        }
    }
}