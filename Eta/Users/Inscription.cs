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
    public partial class Inscription : UserControl
    {
        public Inscription()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txnom.Text = txparent.Text = txprenom.Text = txadress.Text = txtel1.Text = cmbgrp.Text = cmbniveau.Text = "";
        }
        private void Inscription_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from groupe";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbgrp.Items.Add(d.dr[1]);
            }
            d.dr.Dispose();
            d.dr.Close();

            d.cmd.CommandText = "select * from niveau";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbniveau.Items.Add(d.dr[1]);
            }
            d.dr.Dispose();
            d.dr.Close();

            d.cmd.CommandText = "select * from enseignant";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbansignant.Items.Add(d.dr[1]);
            }
            d.dr.Dispose();
            d.dr.Close();
            d.deconnecter();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                d.connecter();
                d.cmd.CommandText = "insert into eleve (nom_eleve , prenom_eleve , dateNai , nom_respo , N_tele , adress " +
                    ", id_enseign , id_groupe , id_niveau ) values ( @a , @b , @c , @d , @e , @f ,@g ,@h, @i ) ";
                d.cmd.Connection = d.cnx;
                d.cmd.Parameters.AddWithValue("@a", txnom.Text);
                d.cmd.Parameters.AddWithValue("@b", txprenom.Text);
                d.cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value);
                d.cmd.Parameters.AddWithValue("@d", txparent.Text);
                d.cmd.Parameters.AddWithValue("@e", int.Parse(txtel1.Text));
                d.cmd.Parameters.AddWithValue("@f", txadress.Text);
                d.cmd.Parameters.AddWithValue("@g", cmbansignant.SelectedIndex)  ;
                d.cmd.Parameters.AddWithValue("@h", cmbgrp.SelectedIndex);
                d.cmd.Parameters.AddWithValue("@i", cmbniveau.SelectedIndex) ;
                d.cmd.ExecuteNonQuery();
                d.deconnecter();
                MessageBox.Show("l'eleve a ete bien ajouter");
            }
            catch(Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
