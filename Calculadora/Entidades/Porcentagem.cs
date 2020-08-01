namespace Calculadora.Entidades
{
    class Porcentagem : AbstratoCalculadora
    {
        public string OperadorAritmetico { get; private set; }
        public Porcentagem(double primeiroNumero, double segundoNumero, string operadorAritmetico) : base(primeiroNumero, segundoNumero)
        {
            OperadorAritmetico = operadorAritmetico;
        }
        public override double Calcular(double primeiroNumero, double segundoNumero)
        {
            double resultado = 0.0;
            switch (OperadorAritmetico)
            {
                case "+":
                    resultado = segundoNumero / 100.0 * primeiroNumero + primeiroNumero;
                    break;
                case "-":
                    resultado = segundoNumero / 100.0 * primeiroNumero;
                    resultado = primeiroNumero - resultado;
                    break;
                case "*":
                    resultado = primeiroNumero * (segundoNumero / 100.0);
                    break;
                case "/":
                    resultado = segundoNumero / 100.0;
                    resultado = primeiroNumero / resultado;
                    break;
            }
            return resultado;
        }
    }
}
