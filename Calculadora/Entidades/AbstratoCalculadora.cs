namespace Calculadora.Entidades
{
    abstract class AbstratoCalculadora
    {
        public double PrimeiroNumero { get; private set; }
        public double SegundoNumero { get; private set; }
        protected double Resultado;

        protected AbstratoCalculadora(double primeiroNumero, double segundoNumero)
        {
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            Resultado = 0.0;
        }

        public abstract double Calcular(double primeiroNumero, double segundoNumero);
    }
}
