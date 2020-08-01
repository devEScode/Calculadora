namespace Calculadora.Entidades
{
    class Dividir : AbstratoCalculadora
    {
        public Dividir(double primeiroNumero, double segundoNumero) : base(primeiroNumero, segundoNumero)
        {
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
