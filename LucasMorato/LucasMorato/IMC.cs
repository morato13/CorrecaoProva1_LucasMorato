using System;

namespace LucasMorato
{
    public class IMC
    {
        private double peso;
        private double altura;

        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;
        }

        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double Calcular(double peso, double altura)
        {
            double retorno = (peso / (altura * altura));
            return retorno;
        }

        public string Classifcar(double imc)
        {
            string classificacao = "Não validado!"; 

            if(imc < 16)
                classificacao = "Magreza Grave!";
            else if(imc > 16 & imc <= 18.4d)
                classificacao = "Magreza Moderada!";
            else if(imc >= 18.5 && imc <= 24)
                classificacao = "Magreza Leve!";
            else if(imc >= 25 && imc <= 30)
                classificacao = "Saudável!";
            else if(imc >= 31 && imc <= 34)
                classificacao = "Obesidade GRAU I";
            else if (imc >= 35 && imc <= 39)
                classificacao = "Obesidade GRAU II";
            else if (imc > 40)
                classificacao = "Obesidade GRAU III";

            return classificacao;
        }
    }
}
