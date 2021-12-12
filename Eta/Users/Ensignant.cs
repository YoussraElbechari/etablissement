using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eta.Users
{
    public partial class Ensignant : UserControl
    {
        public Ensignant()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        public void afficher()
        {
            try
            {
                d.connecter();
                dataGridView1.Rows.Clear();
                d.cmd.CommandText = "select * from enseignant ";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                while (d.dr.Read())
                {
                    dataGridView1.Rows.Add(d.dr[1], d.dr[2], d.dr[3], d.dr[4], d.dr[5]);
                }
                d.deconnecter();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            d.connecter();
            try
            {
                d.cmd.CommandText = "insert into enseignant (nom_enseign,prenom_enseign,dateNai,N_tele,adress) values (@a,@b,@c,@d,@e)";
                d.cmd.Connection = d.cnx;
                d.cmd.Parameters.AddWithValue("@a", txnom.Text);
                d.cmd.Parameters.AddWithValue("@b", txprenom.Text);
                d.cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value);
                d.cmd.Parameters.AddWithValue("@d", int.Parse(txtel2.Text));
                d.cmd.Parameters.AddWithValue("@e", txadress.Text);
                d.cmd.ExecuteNonQuery();
                MessageBox.Show("la ou le Maitre " + txnom.Text + " a été bien ajouter ");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            d.deconnecter();
            afficher();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txadress.Text = txnom.Text = txprenom.Text = txtel2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                d.connecter();
                string no = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string pr = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string tel = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                d.cmd.CommandText = "delete from enseignant where nom_enseign = @x and prenom_enseign = @y and N_tele = @z";
                d.cmd.Connection = d.cnx;
                d.cmd.Parameters.AddWithValue("@x", no);
                d.cmd.Parameters.AddWithValue("@y", pr);
                d.cmd.Parameters.AddWithValue("@z", tel);
                d.cmd.ExecuteNonQuery();
                
                d.deconnecter();
                MessageBox.Show(no + " " + pr + " a ete supprimer");
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            
            afficher();
        }

        private void Ensignant_Load(object sender, EventArgs e)
        {
            afficher();
        }
    }
}
