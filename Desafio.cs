using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEstágioTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                opcao = OpcaoMenu();;
                Console.ReadKey();
            } while (opcao != 0);
        }

        static int OpcaoMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("Opção numero 1 = Soma");
            Console.WriteLine("Opção numero 2 = Fibonacci");
            Console.WriteLine("Opção numero 3 = Faturamento diário");
            Console.WriteLine("Opção numero 4 = Faturamento mensal");
            Console.WriteLine("Opção numero 5 = String Reverse");
            Console.WriteLine("Opção numero 0 = Sair");
            Console.WriteLine("----------------");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao) 
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Fibonacci();
                    break;
                case 3:
                    FaturamentoDiario();
                    break;
                case 4:
                    FaturamentoMensal();
                    break;
                case 5:
                    StringReverse();
                    break;
            }

            return opcao;
        }

        static int Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("Opção numero 1 = Soma");
            Console.WriteLine("Opção numero 2 = Fibonacci");
            Console.WriteLine("Opção numero 3 = Faturamento diário");
            Console.WriteLine("Opção numero 4 = Faturamento mensal");
            Console.WriteLine("Opção numero 5 = String Reverse");
            Console.WriteLine("Opção numero 0 = Sair");
            Console.WriteLine("----------------");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Soma()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                Console.WriteLine(soma);
            }

            Console.WriteLine($"O valor final da soma é: {soma}");
        }

        static void Fibonacci ()
        {

            Console.WriteLine("Digie uma sequência para o Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];

            int n1 = 0;
            int n2 = 1;
            int soma = n1 + n2;


            for (int i = 0; i < n; i++)
            {

                if (i == 0)
                {
                    array1[i] = 0;
                    Console.Write(" ( " + array1[i]);
                }
                else if (i == 1) 
                {
                    array1[i] = 1;
                    Console.Write(" , " + array1[i]);
                }
                else
                {
                    array1[i] = soma;
                    n1 = n2;
                    n2 = soma;
                    soma = n1 + n2;

                    Console.Write(" , " + array1[i]);
                }
            }
            Console.Write(" ) ");
            Console.WriteLine();

            if (array1.Contains(n))
            {
                Console.WriteLine($"O valor {n} pertence a tabela Fibonacci");
            }else
            {
                Console.WriteLine($"O valor {n} não pertence a tabela Fibonacci");
            }

        }

        static void FaturamentoDiario()
        {
            double[] diario = new double[30];

            double maxvalor = double.MinValue;
            double minvalor = double.MaxValue;
            double media = 0;
            double soma = 0;
            int contdia = 0;
            

            diario[0] = 22174.1664;
            diario[1] = 24537.6698;
            diario[2] = 26139.6134;
            diario[3] = 0.0;
            diario[4] = 0.0;
            diario[5] = 26742.6612;
            diario[6] = 0.0;
            diario[7] = 42889.2258;
            diario[8] = 46251.174;
            diario[9] = 11191.4722;
            diario[10] = 0.0;
            diario[11] = 0.0;
            diario[12] = 3847.4823;
            diario[13] = 373.7838;
            diario[14] = 2659.7563;
            diario[15] = 48924.2448;
            diario[16] = 18419.2614;
            diario[17] = 0.0;
            diario[18] = 0.0;
            diario[19] = 35240.1826;
            diario[20] = 43829.1667;
            diario[21] = 18235.6852;
            diario[22] = 4355.0662;
            diario[23] = 13327.1025;
            diario[24] = 0.0;
            diario[25] = 0.0;
            diario[26] = 25681.8318;
            diario[27] = 1718.1221;
            diario[28] = 13220.495;
            diario[29] = 8414.61;

            for (int i = 0; i < diario.Length; i++)
            {
                
                if (diario[i] < minvalor)
                {
                    minvalor = diario[i];
                }
                if (diario[i] > maxvalor)
                {
                    maxvalor = diario[i];
                }
                soma = diario[i] + soma;
            }

            media = soma / 21;

            for (int i = 0; i < diario.Length; i++) 
            {
                if (diario[i] > media) 
                {
                    contdia++;
                    Console.Write($"O faturamento foi maior que a média nos dias: ");
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($" A quantidade de dias que o faturamento foi maior é: {contdia}");
            Console.WriteLine($"O valor minimo é:  {minvalor}");
            Console.WriteLine($"O valor máximo é:  {maxvalor}");

        }

        static void FaturamentoMensal()
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double soma;
            double persp;
            double perrj;
            double permg;
            double peres;
            double perout;

            soma = sp + rj + mg + es + outros;

            persp = (sp / soma) * 100;
            perrj = (rj / soma) * 100;
            permg = (mg / soma) * 100;
            peres = (es / soma) * 100;
            perout = (outros / soma) * 100;

            Console.WriteLine("O valor dos percentuais de cada cidade é: ");
            Console.WriteLine($"Percentual de SP: {persp} %");
            Console.WriteLine($"Percentual de RJ: {perrj} %");
            Console.WriteLine($"Percentual de MG: {permg} %");
            Console.WriteLine($"Percentual de ES: {peres} %");
            Console.WriteLine($"Percentual de Outros: {perout} %");
        }

        static void StringReverse()
        {
            Console.WriteLine("Digite o string que você quer reverter");
            string reverter = Console.ReadLine();

            Console.WriteLine("String revertido:");
            string imprimir = StringNew (reverter);
            Console.WriteLine(imprimir);

        }

        static string StringNew(string s) 
        {
            char[] chars = new char [s.Length];
            int c = 0;

            for (int i = s.Length - 1; i >= 0; i--) 
            {
                chars[c] = s[i];
                c++;
            }

            return new string(chars);
        }


    }
}