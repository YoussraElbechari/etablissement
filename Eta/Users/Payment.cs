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
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void Payment_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select nom_groupe from groupe";
            d.cmd.Connection = d.cnx;
            d.cmd.Parameters.AddWithValue("@x", txnom.Text);
            d.cmd.Parameters.AddWithValue("@y", txprenom.Text);
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbgrp.Items.Add(d.dr[0]);
            }
            d.dr.Dispose();
            d.dr.Close();
            d.deconnecter(); 
            cmbmois.Items.AddRange(new string[]
            {
                "Janvier","Février","Mars","Avril","Mai","Juin","Juillet","Août","Septembre","Octobre","Novembre","Décembre"
            });
        }
        private void cmbgrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                d.connecter();
                d.cmd.CommandText = "select * from eleve inner join groupe on eleve.id_eleve = groupe.id_elv where nom_eleve = @x and prenom_eleve = @y";
                d.cmd.Connection = d.cnx;
                d.cmd.Parameters.AddWithValue("@x",txnom.Text);
                d.cmd.Parameters.AddWithValue("@y",txprenom.Text);
                d.dr = d.cmd.ExecuteReader();
                while (d.dr.Read())
                {
                    dataGridView1.Rows.Add( d.dr[1], d.dr[2], d.dr[3], d.dr[4], d.dr[5], d.dr[6]);
                }
                d.dr.Dispose();
                d.dr.Close();
                d.deconnecter();
            }
            catch(Exception x) { MessageBox.Show(x.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.cmd.CommandText = "insert into Payment (id_P,date_p,Mois,Montant,id_eleve,id_niveau) values (@a,@b,@c,@d,@e) where id_eleve = @f and id_niv = @j";
            d.cmd.Connection = d.cnx;
            d.cmd.Parameters.AddWithValue("@a",dateTimePicker1.Value);
            d.cmd.Parameters.AddWithValue("@b",cmbmois.Text);
            d.cmd.Parameters.AddWithValue("@c", txmontant.Text);
            //d.cmd.Parameters.AddWithValue("@d",);
            //d.cmd.Parameters.AddWithValue("@e",);

        }

        
    }
}
