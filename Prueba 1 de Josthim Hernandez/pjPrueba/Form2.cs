using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPrueba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double valor, depre, a;
            if (comboBox1.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show(" No se permiten espacios");
                comboBox1.Focus();
            }
            else
            {
                if(comboBox1.Text.Equals("Vehiculos"))
                {
                    valor = double.Parse(maskedTextBox1.Text);
                    a = 5;
                    if(valor >= 500 && valor <= 20000)
                    {
                        depre = valor / a;
                        textBox1.Text = depre.ToString();
                    }
                    else
                    {
                        MessageBox.Show(" El valor debe estar entre 500 y 20000", "Error");
                        maskedTextBox1.Focus();
                        maskedTextBox1.Text = "";
                    }
                }
                else if(comboBox1.Text.Equals("Edificios"))
                {
                    valor = double.Parse(maskedTextBox1.Text);
                    a = 20;
                    if(valor >= 1000 && valor <= 100000)
                    {
                        depre = valor / a;
                        textBox1.Text = depre.ToString();
                    }
                    else
                    {
                        MessageBox.Show(" El valor debe estar entre 1000 y 100000", "Error");
                        maskedTextBox1.Focus();
                        maskedTextBox1.Text = "";
                    }
                }
                else if(comboBox1.Text.Equals("Equipo de Oficina"))
                {
                    valor = double.Parse(maskedTextBox1.Text);
                    a = 2;
                    if (valor >= 10 && valor <= 10000)
                    {
                        depre = valor / a;
                        textBox1.Text = depre.ToString();
                    }
                    else
                    {
                        MessageBox.Show(" El valor debe estar entre 10 y 10000", "Error");
                        maskedTextBox1.Focus();
                        maskedTextBox1.Text = "";
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                "Calcular Depreciación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
