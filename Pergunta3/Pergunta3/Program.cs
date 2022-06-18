using System;

namespace Pergunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) a = 1, b = 2, c = 3 Não formou um triângulo
            //b) a = 3, b = 4, c = 5 Triângulo Escaleno
            //c) a = 2, b = 2, c = 4 Não formou um triângulo
            //d) a = 4, b = 4, c = 4 Triângulo Equilátero
            //e) a = 5, b = 3, c = 3 Triângulo Isósceles

            //Variáveis
            int a = 0;
            int b = 0;
            int c = 0;
            string mens = "";

            Console.Write("Valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Valor de C: ");
            c = int.Parse(Console.ReadLine());

            if((a < b + c) && (b < a + c) && (c < b + a))
            {
                if((a == b) && (b == c))
                {
                    mens = "Triângulo Equilátero";
                }
                else if((a == b) || (b == c) || (a == c))
                {
                    mens = "Triângulo Isósceles";
                }
                else
                {
                    mens = "Triângulo Escaleno";
                }
            }
            else
            {
                mens = "Não é possível formar um triângulo";
            }

            Console.Write(mens);
        }
    }
}
