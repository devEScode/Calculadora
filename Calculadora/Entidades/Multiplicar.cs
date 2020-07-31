namespace Calculadora.Entidades
{
    class Multiplicar : AbstratoCalculadora
    {
        public Multiplicar(double primeiroNumero, double segundoNumero) : base(primeiroNumero, segundoNumero)
        {
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
    }
}
