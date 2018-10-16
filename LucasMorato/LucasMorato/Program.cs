using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasMorato
{
    class Program
    {
        static int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
                return b;
        }

        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static bool Resto(int c)
        {
            if (c % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            //Questão 1
            Console.WriteLine(Maior(1, 2));
            Console.WriteLine(Maior2(5, 2));

            //Questão 3
            Console.WriteLine(Resto(2));
        

           
            Console.ReadKey();
            Console.Clear();
        }


    }
}

