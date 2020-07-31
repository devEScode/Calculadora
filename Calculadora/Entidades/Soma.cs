using System.Globalization;

namespace Calculadora.Entidades
{
    class Soma : AbstratoCalculadora
    {
        public Soma(double primeiroNumero,double segundoNumero) : base(primeiroNumero, segundoNumero)
        {
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }
    }
}
