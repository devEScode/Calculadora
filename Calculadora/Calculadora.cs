using Calculadora.Entidades;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primeiroNumero, segundoNumero;
        string operadorAritmetico;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "1";
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += "0";
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            BoxPainel.Text += ".";
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            BoxPainel.Clear();
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            operadorAritmetico = "+";
            primeiroNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);
            BoxPainel.Clear();
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            operadorAritmetico = "-";
            primeiroNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);
            BoxPainel.Clear();
        }

        private void BtnDivicao_Click(object sender, EventArgs e)
        {
            operadorAritmetico = "/";
            primeiroNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);
            BoxPainel.Clear();
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            operadorAritmetico = "*";
            primeiroNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);
            BoxPainel.Clear();
        }

        private void BtnPorcentagem_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);

            AbstratoCalculadora porcentagem = new Porcentagem(primeiroNumero, segundoNumero, operadorAritmetico);
            BoxPainel.Text = porcentagem.Calcular(primeiroNumero, segundoNumero).ToString(CultureInfo.InvariantCulture);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(BoxPainel.Text, CultureInfo.InvariantCulture);

            if (operadorAritmetico == "/" && segundoNumero == 0)
            {
                BoxPainel.Text = "Não é possível dividir por zero.";
            }
            else
            {
                switch (operadorAritmetico)
                {
                    case "+":
                        AbstratoCalculadora somar = new Soma(primeiroNumero, segundoNumero);
                        BoxPainel.Text = somar.Calcular(primeiroNumero, segundoNumero).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        AbstratoCalculadora subtrair = new Subtrair(primeiroNumero, segundoNumero);
                        BoxPainel.Text = subtrair.Calcular(primeiroNumero, segundoNumero).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "*":
                        AbstratoCalculadora multiplicar = new Multiplicar(primeiroNumero, segundoNumero);
                        BoxPainel.Text = multiplicar.Calcular(primeiroNumero, segundoNumero).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "/":
                        AbstratoCalculadora dividir = new Dividir(primeiroNumero, segundoNumero);
                        BoxPainel.Text = dividir.Calcular(primeiroNumero, segundoNumero).ToString(CultureInfo.InvariantCulture);
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
