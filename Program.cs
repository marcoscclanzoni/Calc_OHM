using System;

namespace Ohm
{
    class Program
    {


        static void Main(string[] args)
        {

            int opc = 0;
            while (opc < 4)
            {
                Console.WriteLine("Escolha uma opção abaixo ok ");
                Console.WriteLine("");
                Console.WriteLine("1 = Calculo de Tensão");
                Console.WriteLine("2 = Calculo de Corrente");
                Console.WriteLine("3 = Calculo de Resistencia ");
                Console.WriteLine("4 = Para Sair ");
                Console.WriteLine("");
                Console.WriteLine("");
                opc = int.Parse(Console.ReadLine());


                Console.WriteLine("__________________________________");
                if (opc == 1)
                {
                    Console.WriteLine("Será Efetuado o Calculo de Tensão");
                    Console.WriteLine("");
                    Console.WriteLine("Entre com os valores solicitados abaixo");
                    Console.WriteLine("");
                    CalcOhmTensao ohm1 = new CalcOhmTensao();
                    Console.Write("Corrente =");
                    ohm1.i = double.Parse(Console.ReadLine()); // carrega valores de corrente
                    Console.Write("Resistencia =");
                    ohm1.r = double.Parse(Console.ReadLine()); // carrega valores de resistencia
                    double tensao = ohm1.v();
                    Console.WriteLine("A Tensão para " + ohm1.i + " amperes " + ohm1.r + " e  ohms é de " + tensao + " volts");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opc == 2)
                {
                    Console.WriteLine("Será Efetuado o Calculo de Corrente");
                    Console.WriteLine("");
                    Console.WriteLine("Entre com os valores solicitados abaixo");
                    Console.WriteLine("");
                    CalcOhmCor ohm1 = new CalcOhmCor();
                    Console.Write("Tensão =");
                    ohm1.t = double.Parse(Console.ReadLine()); // carrega valores de tensao
                    Console.Write("Resistencia =");
                    ohm1.r = double.Parse(Console.ReadLine()); // carrega valores de resistencia
                    double corrente = ohm1.c();
                    Console.WriteLine("A corrente para " + ohm1.t + " volts " + ohm1.r + " e  ohms é de " + corrente + " amperes");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 3)
                {
                    Console.WriteLine("Será Efetuado o Calculo de Resistencia");
                    Console.WriteLine("");
                    Console.WriteLine("Entre com os valores solicitados abaixo");
                    Console.WriteLine("");
                    CalcOhmRes ohm1 = new CalcOhmRes();
                    Console.Write("Tensão =");
                    ohm1.t = double.Parse(Console.ReadLine()); // carrega valores de tensao
                    Console.Write("Corrente =");
                    ohm1.i = double.Parse(Console.ReadLine()); // carrega valores de corrente
                    double resistencia = ohm1.r();
                    Console.WriteLine("A resistencia para " + ohm1.t + " volts " + ohm1.i + " amperes é de " + resistencia + " ohms");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 4)
                {
                    Console.WriteLine("Voce escolheu a opção para sair");

                    Console.WriteLine("Para sair acione qualquer tecla");
                    Console.WriteLine("");
                }
                if (opc == 0)

                {
                    Console.WriteLine("Obrigatorio escolher um parametro");
                    Console.ReadKey();

                }

            }
        }
    }
}