namespace Calculadora.Entidades
{
    class Subtrair : AbstratoCalculadora
    {
        public Subtrair(double primeiroNumero, double segundoNumero) : base(primeiroNumero, segundoNumero)
        {
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }
    }
}
