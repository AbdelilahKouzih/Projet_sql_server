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
    public partial class Etudiant : Form
    {
        private int Verif;
        public Etudiant()
        {
            InitializeComponent();
        }

        private void Etudiant_Load(object sender, EventArgs e)
        {
            connection();
            btnannuler.Enabled = false;
            btnvalider.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;


            btnajouter.Enabled = true;
            txtlcmd.Enabled = false;
            txtnumcmd.Enabled = false;
            txtnumc.Enabled = false;
            txtquantite.Enabled = false;


            cnx.Close();
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
            txtlcmd.Clear();
            txtquantite.Clear();
            txtnumc.Clear();
            txtnumcmd.Clear();


        }

        public void etatinitial()
        {

            function_clear();
            txtlcmd.Enabled = true;
            txtquantite.Enabled = true;
            txtnumc.Enabled = true;
            txtnumcmd.Enabled = true;


            btnvalider.Enabled = false;
            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;


            btnajouter.Enabled = true;

        }
       
        private void Commande_Click(object sender, EventArgs e)
        {
            Classe p = new Classe();
            p.Show();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inscription ins = new inscription();
            ins.Show();
        }

        private void txtlcmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            Verif = 1;



            connection();
            function_clear();

            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnajouter.Enabled = false;
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;


            txtlcmd.Enabled = true;
            txtquantite.Enabled = true;
            txtnumcmd.Enabled = true;
            txtnumc.Enabled = true;

            cnx.Close();
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {

            Verif = 2;

            connection();
            txtlcmd.Enabled = true;
            txtquantite.Enabled = true;
            txtnumcmd.Enabled = true;
            txtnumc.Enabled = true;

            btnsupprimer.Enabled = false;

            btnajouter.Enabled = false;
            btnvalider.Enabled = true;
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnafficher.Enabled = false;

            function_clear();

            cnx.Close();
        }

        private void btnsupprimer_Click_1(object sender, EventArgs e)
        {

            Verif = 3;

            connection();

            txtlcmd.Enabled = true;
            txtquantite.Enabled = true;
            txtnumcmd.Enabled = true;
            txtnumc.Enabled = true;

            btnsupprimer.Enabled = false;

            btnajouter.Enabled = false;
            btnvalider.Enabled = true;
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnafficher.Enabled = false;

            function_clear();
            cnx.Close();
        }

        private void btnafficher_Click_1(object sender, EventArgs e)
        {

            connection();
            cmd.CommandText = "execute AffichageEtudiant";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dglcmd.DataSource = dt;
            cnx.Close();
        }

        private void btnvalider_Click_1(object sender, EventArgs e)
        {
            if (Verif == 1)
            {
                if (txtlcmd.Text == "" || txtquantite.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = " execute InsertionEtudiant N'" + txtlcmd.Text + "',N'" + txtquantite.Text + "',N'" + txtnumc.Text + "' ,N'" + txtnumcmd.Text + "' ";
                cmd.ExecuteNonQuery();
                etatinitial();

                cnx.Close();

            }
            else if (Verif == 2)
            {
                connection();

                cmd.CommandText = " execute UpdateEtudiant N'" + txtlcmd.Text + "',N'" + txtquantite.Text + "',N'" + txtnumcmd.Text + "' ,N'" + txtnumc.Text + "'";
                cmd.ExecuteNonQuery();
                etatinitial();
                cnx.Close();

            }
            else if (Verif == 3)
            {

                MessageBox.Show("vous avez sûre !!");
                connection();

                cmd.CommandText = " execute SuppresionEtudiant N'" + txtlcmd.Text + "'";
                cmd.ExecuteNonQuery();
                etatinitial();
                MessageBox.Show("la ligne a été bien supprimer");

                cnx.Close();

            }
        }

        private void btnannuler_Click_1(object sender, EventArgs e)
        {
            function_clear();
            btnmodifier.Enabled = true;

            txtlcmd.Enabled = true;
            txtquantite.Enabled = true;
            txtnumcmd.Enabled = true;
            txtnumc.Enabled = true;
            btnsupprimer.Enabled = true;

            btnajouter.Enabled = true;
            btnannuler.Enabled = false;
            btnvalider.Enabled = false;
            btnafficher.Enabled = false;
        }

        private void Commande_Click_1(object sender, EventArgs e)
        {
            Classe ca = new Classe();
            ca.Show();
        }
    }
}

