using System;

namespace Ohm
{
    class Program
    {


        static void Main(string[] args)
        {

            int opc = 0;
            while (opc < 6)
            {
                Console.WriteLine("Escolha uma opção abaixo ............ ");
                Console.WriteLine("");
                Console.WriteLine("1 = Calculo de Tensão");
                Console.WriteLine("2 = Calculo de Corrente");
                Console.WriteLine("3 = Calculo de Resistencia ");
                Console.WriteLine("4 = Calculo de Potência considerando tensão e corrente ");
                Console.WriteLine("5 = Calculo de Potencia considerando resistencia e corrente");
                Console.WriteLine("6 = Para Sair ");
                Console.WriteLine("");
                Console.WriteLine("");
                opc = int.Parse(Console.ReadLine());


                Console.WriteLine("__________________________________");
                if (opc == 1)
                {
                    Console.WriteLine("");
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
                    Console.WriteLine("A Tensão para " + ohm1.i + " amperes  e " + ohm1.r + "  ohms é de " + tensao + " volts...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opc == 2)
                {
                    Console.WriteLine("");
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
                    Console.WriteLine("A corrente para " + ohm1.t + " volts  e " + ohm1.r + "  ohms é de " + corrente + " amperes...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 3)
                {
                    Console.WriteLine("");
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
                    Console.WriteLine("A resistencia para " + ohm1.t + " volts e  " + ohm1.i + " amperes é de " + resistencia + " ohms...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Será Efetuado o Calculo de Potência ");
                    Console.WriteLine("");
                    Console.WriteLine("Entre com os valores solicitados abaixo");
                    Console.WriteLine("");
                    CalcOhmPot1 ohm1 = new CalcOhmPot1();
                    Console.Write("Tensão =");
                    ohm1.t = double.Parse(Console.ReadLine()); // carrega valores de tensao
                    Console.Write("Corrente =");
                    ohm1.i = double.Parse(Console.ReadLine()); // carrega valores de corrente
                    double potencia  = ohm1.p();
                    Console.WriteLine("A potencia  para " + ohm1.t + " volts e  " + ohm1.i + " amperes é de " + potencia + " watts...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Será Efetuado o Calculo de Potência tendo resistencia e corrente ");
                    Console.WriteLine("");
                    Console.WriteLine("Entre com os valores solicitados abaixo");
                    Console.WriteLine("");
                    CalcOhmPot2 ohm1 = new CalcOhmPot2();
                    Console.Write("Resistencia  =");
                    ohm1.r = double.Parse(Console.ReadLine()); // carrega valores da resistencia
                    Console.Write("Corrente =");
                    ohm1.i = double.Parse(Console.ReadLine()); // carrega valores de corrente
                    double potencia2 = ohm1.p2();
                    Console.WriteLine("A potencia  para " + ohm1.r + " ohms e  " + ohm1.i + " amperes é de " + potencia2 + " watts...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (opc == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Voce escolheu a opção para sair");

                    Console.WriteLine("Para sair acione qualquer tecla");
                    Console.WriteLine("");
                }
                if (opc == 0)

                {
                    Console.WriteLine("");
                    Console.WriteLine("Obrigatorio escolher um parametro");
                    Console.ReadKey();

                }

            }
        }
    }
}