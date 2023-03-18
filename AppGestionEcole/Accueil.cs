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

namespace AppGestionEcole
{
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        private void Accueil_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(idEtudiant) FROM etudiant;";
                cmd = new SqlCommand(sql, conn);
                countEtudiants.Text = cmd.ExecuteScalar().ToString();
                //------
                string sql2 = "SELECT COUNT(idProf) FROM prof;";
                cmd = new SqlCommand(sql2, conn);
                countProf.Text = cmd.ExecuteScalar().ToString();
                //------
                string sql3 = "SELECT COUNT(idFiliere) FROM filiere;";
                cmd = new SqlCommand(sql3, conn);
                countFilieres.Text = cmd.ExecuteScalar().ToString();
                //------
                string sql4 = "SELECT COUNT(idClasse) FROM classe;";
                cmd = new SqlCommand(sql4, conn);
                countClasses.Text = cmd.ExecuteScalar().ToString();
                conn = new SqlConnection(cs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
