using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasMorato
{
    class Program
    {

        static string  ComunicacaoComClasse()
        {
            IMC imc = new IMC();
            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine()); 

            string classificacao = imc.Classifcar(imc.Calcular(peso, altura));

            return classificacao;         
        }      

        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de IMC: ");
            Console.WriteLine("Sua classificação é {0}", ComunicacaoComClasse());

            Console.ReadKey();
        }
    }
}

