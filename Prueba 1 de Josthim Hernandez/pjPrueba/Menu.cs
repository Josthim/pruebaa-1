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
    public partial class Menu : Form
    {
        Form1 x = new Form1();
        Form2 y = new Form2();
        Form3 z = new Form3();
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void solicitudDePréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MdiParent = this;
            x.Show();
        }

        private void depreciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y.MdiParent = this;
            y.Show();
        }

        private void totalAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z.MdiParent = this;
            z.Show();
        }
    }
}
