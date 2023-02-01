using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pjPrueba
{
    public partial class Form3 : Form
    {
        double total;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double subt, iv;
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se permiten espacios", "Error");
            }
            else
            {
                subt = double.Parse(maskedTextBox1.Text);
                if (subt < 1 || subt > 1000)
                {
                    MessageBox.Show("Rango entre 1 y 1000", "Error");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();
                }
                else
                {
                    iv = subt * 0.15;
                    textBox1.Text = iv.ToString();
                    total = subt + iv;
                    textBox2.Text = total.ToString();        
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double monP, vuelt, descu;
            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("No se permiten espacios", "Error");
            }
            else
            {
                monP = double.Parse(maskedTextBox2.Text);
                if (monP >= total)
                {
                    if (radioButton1.Checked == false && radioButton2.Checked == true)
                    {
                        descu = total * 0.05;
                        textBox5.Text = descu.ToString();
                        vuelt = monP - (total - descu);
                        textBox4.Text = vuelt.ToString();
                    }
                    else if (radioButton1.Checked == true && radioButton2.Checked == false)
                    {
                        if (monP >= 1 || monP <= 25)
                        {
                            descu = total * 0.02;
                            textBox5.Text = descu.ToString();
                            vuelt = monP - (total - descu);
                            textBox4.Text = vuelt.ToString();
                        }
                        else if (monP >= 26 || monP <= 60)
                        {
                            descu = total * 0.04;
                            textBox5.Text = descu.ToString();
                            vuelt = monP - (total - descu);
                            textBox4.Text = vuelt.ToString();
                        }
                        else if (monP > 60)
                        {
                            descu = total * 0.07;
                            textBox5.Text = descu.ToString();
                            vuelt = monP - (total - descu);
                            textBox4.Text = vuelt.ToString();
                        }
                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        MessageBox.Show(" Porfavor seleccione una opcion entre Efectivo o Tarjeta");
                    }
                }
                else
                {
                    MessageBox.Show(" El monto a Pagar no puede ser menor al Total", "Error");
                    maskedTextBox2.Text = "";
                    maskedTextBox2.Focus();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                     "Total a Pagar",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
    