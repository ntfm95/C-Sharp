using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEConersorSeg
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte op = 0;
            do
            {
                Console.WriteLine("Digite 1 para Triângulo maluco \nDigite 2 para Conversor de segundos \nDigite 3 para sair");
                op = Convert.ToSByte(Console.ReadLine());
                if (op == 1)
                {
                    Triangulo();
                }
                else if (op == 2)
                {
                    Conversor();
                }
                else
                {
                    Console.WriteLine("Digite um valor válido");
                }

            } while (op != 3);
        }
        static void Triangulo()
        {
            int val1, val2, val3 = 0;

            Console.WriteLine("Bem Vindo ao triângulo maluco \nDigite três valores");

            val1 = Convert.ToInt16(Console.ReadLine());
            val2 = Convert.ToInt16(Console.ReadLine());
            val3 = Convert.ToInt16(Console.ReadLine());


            if (val1 == val2 && val1 == val3 && val2 == val3)
            {
                Console.WriteLine("Equilatero");
            }
            else if (val1 == val2 || val1 == val3 || val2 == val3)
            {
                Console.WriteLine("Isóceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }

        static void Conversor()
        {
            int hora, min, seg = 0;

            Console.WriteLine("Bem Vindo ao conversor segundos \nDigite o valor segundos");

            seg = Convert.ToInt32(Console.ReadLine());

            hora = seg / 3600;
            min = (seg / 60) % 60;
            seg = seg % 60;

            Console.WriteLine(hora + ":" + min  + ":" + seg);
        }
    }
}
