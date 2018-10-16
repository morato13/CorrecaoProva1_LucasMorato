using System;

namespace LucasMorato
{
    class IMC
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

        public double calcular(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public double Classifcar(double imc)
        {
            return 0.0;
        }
    }
}
