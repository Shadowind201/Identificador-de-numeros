using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identificador_de_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {   
            //Converte os textos das TextBoxes para Números do tipo double
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double num3 = Convert.ToDouble(txtNum3.Text);
            double num4 = Convert.ToDouble(txtNum4.Text);
            double num5 = Convert.ToDouble(txtNum5.Text);

            //Armazena os números em um array para fácil manipulação
            double[] numbers = { num1, num2, num3, num4, num5, };

            //Iniciaza 
            double max = numbers[0];
            double min = numbers[0];

            foreach (double num in numbers)
            {
                if (num > max) // Se o número atual for maior que max, atualiza max
                {
                    max = num;
                }
                if (num < min) // Se o número atual for menor que min, atuliza min
                {
                    min = num;
                }
            }
            txtMaior.Text = max.ToString(); 
            txtMenor.Text = min.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
