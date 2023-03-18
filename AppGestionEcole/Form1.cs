using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraCharts.Native;

namespace AppGestionEcole
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void afficherPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if(afficherPassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "" && username.Text == "")
                MessageBox.Show("Veuillez Remplir les champs du formulaire ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else if (username.Text == "")
                MessageBox.Show("Veuillez remplir le champ Nom d'utilisateur ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password.Text == "")
                MessageBox.Show("Veuillez remplir le champ Mot de passe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionEcole;Data source=(LocalDB)\Local");
                    con.Open();

                    string req = "select * from users where username='" + username.Text + "' and password='" + password.Text + "';";
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(req, con);
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou Mot de passe invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clear();
                }
                finally
                {
                    con.Close();
                    
                }
            }

        }

        public void clear()
        {
            this.password.Text = "";
            this.username.Text = "";
            username.Focus();
        }

    }
}
