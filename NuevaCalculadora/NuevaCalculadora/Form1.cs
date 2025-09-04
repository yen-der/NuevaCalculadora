using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NuevaCalculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "2";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "4";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "5";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "6";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "8";

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "+";

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "-";
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "*";

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "/";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "9";

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1) Pantalla.Text = "0";
            else Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "3.1416";
        }

        private void btnsen_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(Pantalla.Text, out valor))
            {
                Pantalla.Text = Math.Sin(valor).ToString();
            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(Pantalla.Text, out valor))
            {
                Pantalla.Text = Math.Cos(valor).ToString();
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(Pantalla.Text, out valor))
            {
                Pantalla.Text = Math.Tan(valor).ToString();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(Pantalla.Text, out valor))
            {
                Pantalla.Text = Math.Sqrt(valor).ToString();
            }
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(Pantalla.Text, out valor))
            {
                Pantalla.Text = Math.Exp(valor).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double baseNum = double.Parse(Pantalla.Text);
            double exponente = 2;
            Pantalla.Text = Math.Pow(baseNum, exponente).ToString();
        }

        private void btnizq_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + "(";
        }

        private void btnderec_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") Pantalla.Text = "";

            Pantalla.Text = Pantalla.Text + ")";
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            // Función de memoria M+ pendiente
            // Puedes guardar el valor actual en una variable si lo deseas
        }


        private void btnMmenos_Click(object sender, EventArgs e)
        {
            // Función de memoria M− pendiente
        }


        private void btnMc_Click(object sender, EventArgs e)
        {
            // Función de memoria Clear pendiente
        }


        private void button11_Click(object sender, EventArgs e)
        {
            // Usar punto decimal en lugar de coma
            Pantalla.Text += ".";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = Pantalla.Text;
                var resultado = new DataTable().Compute(expresion, "");
                Pantalla.Text = resultado.ToString();
            }
            catch
            {
                Pantalla.Text = "Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}