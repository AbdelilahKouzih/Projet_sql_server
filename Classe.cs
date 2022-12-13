using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_sql_server
{
    public partial class Classe : Form
    {
        private int Verif;
        public Classe()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=inscription;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void connection()
        {

            cnx.Open();

            cmd.Connection = cnx;
        }

        public void function_clear()
        {
            txtcmd.Clear();
            txtdatecmd.Clear();


        }

        public void etatinitial()
        {

            function_clear();
            txtcmd.Enabled = true;
            txtdatecmd.Enabled = true;

            btnvalider.Enabled = false;
            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;

            btnajouter.Enabled = true;

        }
        private void Commande_Load(object sender, EventArgs e)
        {
            connection();
            btnannuler.Enabled = false;
            btnvalider.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;

            btnajouter.Enabled = true;
            txtcmd.Enabled = false;
            txtdatecmd.Enabled = false;

            cnx.Close();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Verif = 1;



            connection();
            function_clear();

            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnajouter.Enabled = false;
            btnsupprimer.Enabled = false;

            txtcmd.Enabled = true;
            txtdatecmd.Enabled = true;

            cnx.Close();

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Verif = 2;

            connection();
            txtcmd.Enabled = true;
            txtdatecmd.Enabled = true;

            btnsupprimer.Enabled = false;

            btnajouter.Enabled = false;
            btnvalider.Enabled = true;
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            function_clear();

            cnx.Close();

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            Verif = 3;

            connection();


            txtcmd.Enabled = true;
            txtdatecmd.Enabled = false;

            btnsupprimer.Enabled = false;

            btnajouter.Enabled = false;
            btnvalider.Enabled = true;
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;

            function_clear();
            cnx.Close();

        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "execute AffichageClasse";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgcmd.DataSource = dt;
            cnx.Close();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            function_clear();
            btnmodifier.Enabled = true;

            txtcmd.Enabled = false;
            txtdatecmd.Enabled = false;
            btnsupprimer.Enabled = true;

            btnajouter.Enabled = true;
            btnannuler.Enabled = false;
            btnvalider.Enabled = false;
        }


       
        private void btnvalider_Click(object sender, EventArgs e)
        {

            if (Verif == 1)
            {
                if (txtcmd.Text == "" || txtdatecmd.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = " execute InsertionClasse N'" + txtcmd.Text + "',N'" + txtdatecmd.Text + "'";
                cmd.ExecuteNonQuery();
                etatinitial();

                cnx.Close();

            }
            else if (Verif == 2)
            {
                connection();

                cmd.CommandText = " execute Update_Classe N'" + txtcmd.Text + "',N'" + txtdatecmd.Text + "'";
                cmd.ExecuteNonQuery();
                etatinitial();
                cnx.Close();

            }
            else if (Verif == 3)
            {

                MessageBox.Show("vous avez sûre !!");
                connection();

                cmd.CommandText = " execute SuppresionClasse N'" + txtcmd.Text + "'";
                cmd.ExecuteNonQuery();
                etatinitial();
                MessageBox.Show("la ligne a été bien supprimer");

                cnx.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inscription p = new inscription();

            p.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.Show();
        }
    }
}
