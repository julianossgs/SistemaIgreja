using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        //variáveis globais
        public double n1, n2, resultado;
        public string operacao;


        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        //*****************************
        //Métodos 

        //Método p/ a tecla igual
        private bool PressionouIgual;

        //Método p/ calcular a potência e raiz quadrada
        public double CalcularPotencia()
        {
            return Math.Pow(n1, n2);
        } 

        //Método p/ limpar o display
        private void LimparDisplay()
        {
            txtDisplay.Clear();
            n1 = 0;
            n2 = 0;
            resultado = 0;
            operacao = string.Empty;
            PressionouIgual = false;
        } 

        //Método p/ adicionar as operações matemáticas
        private void AddOperacao(string caracter)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    n1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    n1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                operacao = caracter;
                txtDisplay.Clear();
            }
        }

        //Botão Zero
        private void bt0_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        //Botão 1
        private void bt6_Click(object sender, EventArgs e)
        {
            AddCaracter("1");
        }

        //Botão 2
        private void bt7_Click(object sender, EventArgs e)
        {
            AddCaracter("2");
        }

        //Botão 3
        private void bt8_Click(object sender, EventArgs e)
        {
            AddCaracter("3");
        }

        //Botão 4
        private void bt11_Click(object sender, EventArgs e)
        {
            AddCaracter("4");
        }

        //Botão 5
        private void bt12_Click(object sender, EventArgs e)
        {
            AddCaracter("5");
        }

        //Botão 6
        private void bt13_Click(object sender, EventArgs e)
        {
            AddCaracter("6");
        }

        //Botão 7
        private void bt16_Click(object sender, EventArgs e)
        {
            AddCaracter("7");
        }

        //Botão 8
        private void bt17_Click(object sender, EventArgs e)
        {
            AddCaracter("8");
        }

        //Botão 9
        private void bt18_Click(object sender, EventArgs e)
        {
            AddCaracter("9");
        }

        //Botão Divisão
        private void btDivisao_Click(object sender, EventArgs e)
        {
            AddOperacao("/");
        }

        //Botão Multiplicação
        private void btMultiplicao_Click(object sender, EventArgs e)
        {
            AddOperacao("*");
        }

        //Botão Subtração
        private void btDiminuicao_Click(object sender, EventArgs e)
        {
            AddOperacao("-");
        }

        //Botão Adição
        private void btAdicao_Click(object sender, EventArgs e)
        {
            AddOperacao("+");
        }

        //Botão C
        private void btC_Click(object sender, EventArgs e)
        {
            LimparDisplay();
        }

        //Botão CE
        private void btCE_Click(object sender, EventArgs e)
        {
            if (operacao.Equals(string.Empty)||PressionouIgual)
            {
                LimparDisplay();
            }

            else
            {
                txtDisplay.Clear();
            }
        }

        //Botão Troca Sinal
        private void btTrocaSinal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ",")) * (-1)).ToString().Replace(",",".");
            }
        }

        //Botão Apagar
        private void btApagar_Click(object sender, EventArgs e)
        {
            int tamanho = txtDisplay.Text.Trim().Length;
            string texto = txtDisplay.Text.Trim();
            txtDisplay.Clear();

            for (int i = 0; i < tamanho-1; i++)
            {
                txtDisplay.Text = txtDisplay.Text + texto[i];
            }
        }

        //Botão Eleveado ao quadrado
        private void btElevado2_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                n2 = 2;
                var resultado = CalcularPotencia();
                txtDisplay.Text = resultado.ToString().Replace(",",".");
                PressionouIgual = true;
            }
        }

        //Botão Potenciação
        private void btPotenciacao_Click(object sender, EventArgs e)
        {
            AddOperacao("^");
        }

        //Botão Raiz Quadrada
        private void btRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",","));
                resultado = Math.Sqrt(n1);
                txtDisplay.Text = resultado.ToString().Replace(",",".");
                PressionouIgual = true;
            }
        }

        //Botão 1x
        private void bt1x_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                n1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));

                if (n1 == 0)
                {
                    MessageBox.Show("Erro ! Divisão por Zero!");
                    return;
                }
                resultado = 1 / n1;
                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }

        //Botão Ponto
        private void btPonto_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Text = "0.";
                PressionouIgual = false;
                return;
            }

            if (txtDisplay.Text.Trim().Equals(string.Empty))
            {
                txtDisplay.Text = "0.";
                if (txtDisplay.Text.Trim().Contains(","))
                {
                    return;
                } 
            }

            txtDisplay.Text = txtDisplay.Text + ",";
        }

        //Botão Igual
        private void btIgual_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
                return;
            }

            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    n2 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",","));
                }
                else
                {
                    n2 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                Calcular();
                PressionouIgual = true;
            }
        }


        //Método p/ adicionar caracter nos botões
        private void AddCaracter(string caracter)
        {
            if (PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = caracter;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caracter;
            }
        } 

        //Método p/ calcular(operações matemáticas)
        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (n2==0)
                    {
                        MessageBox.Show("Divisão por ZERO!");
                        break;
                    }
                    resultado = (n1/n2);
                    break;

                case "*":
                    resultado = (n1 * n2);
                    break;

                case "+":
                    resultado = (n1 + n2);
                    break;

                case "-":
                    resultado = (n1 - n2);
                    break;

                case "^":
                    resultado = CalcularPotencia();
                    break;
                default:
                    break;
            }

            txtDisplay.Text = resultado.ToString().Replace(",",".");
        }
    }
}
