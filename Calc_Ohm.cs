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
    class CalcOhmPot1 // calculo de potencia tendo Tensão e Corrente 
    {
        public double t; // entrada de tensao 
        public double i; // entrada de corrente
        public double p()
        {
            return t * i; // resultado em watts 
        }

    }
    class CalcOhmPot2 // Calculo de potencia tendo resistencia e corrente
    {
        public double i;
        public double r;
        public double p2()
        {
            return (i * i) * r;
        }

    }
}