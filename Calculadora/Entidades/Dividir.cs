using System.Globalization;

namespace Calculadora.Entidades
{
    class Dividir : AbstratoCalculadora
    {
        public Dividir(double primeiroNumero, double segundoNumero) : base(primeiroNumero, segundoNumero)
        {
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            if (primeiroNumero != 0)
            {
                return primeiroNumero / segundoNumero;
            }
            else
            {
                return 0000000000;
            }
        }
    }
}
