using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Height = btnacceuil.Height;
            panel2.Top = btnacceuil.Top;
            acceil1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Height = btnensignant.Height;
            panel2.Top = btnensignant.Top;
            ensignant1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = btnacceuil.Height;
            panel2.Top = btnacceuil.Top;
            acceil1.BringToFront();
        }

        private void btninsciption_Click(object sender, EventArgs e)
        {
            panel2.Height = btninsciption.Height;
            panel2.Top = btninsciption.Top;
            inscription1.BringToFront();
        }

        private void btnpaiement_Click(object sender, EventArgs e)
        {
            panel2.Height = btnpaiement.Height;
            panel2.Top = btnpaiement.Top;
            payment1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
