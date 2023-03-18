using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppGestionEcole
{
    public partial class UserControle : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public UserControle()
        {
            InitializeComponent();
        }

        private void UserControle_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                this.usersTableAdapter.Fill(this.gestionEcoleDataSet.users);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (motpasse.Text == confirmMotPasse.Text)
                {
                    int admin;
                    if (isadmin.Text == "Oui")
                    {
                        admin = 1;
                    }
                    else
                    {
                        admin = 0;
                    }
                    string insert = "INSERT INTO users"
                        + " VALUES('" + textBox3.Text + "' , '" + motpasse.Text + "' , '" + nomuser.Text + "' , '" + prenomuser.Text + "' , '" + numTeluser.Text + "' , " + admin + ", '" + adresseuser.Text + "' , '" + datenaissanceuser.Value.ToString() + "')";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                    this.usersTableAdapter.Fill(this.gestionEcoleDataSet.users);
                    dataGridView1.RefreshEdit();
                    this.clear();
                }
                else
                {
                    MessageBox.Show("Vérifier votre mot de passe");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            textBox3.Text = "";
            motpasse.Text = "";
            nomuser.Text = "";
            prenomuser.Text = "";
            numTeluser.Text = "";
            isadmin.Text = "";
            confirmMotPasse.Text = "";
            adresseuser.Text = "";
            datenaissanceuser.Value = DateTime.Now;
        }
        int t = -1;

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
            int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());

            try
            {
                if (t != 1)
                {
                    nomuser.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                    prenomuser.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                    datenaissanceuser.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
                    numTeluser.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
                    adresseuser.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
                    motpasse.Text = dataGridView1.Rows[id].Cells[7].Value.ToString();
                    isadmin.Text = dataGridView1.Rows[id].Cells[8].Value.ToString();
                    Ajouter.Enabled = false;
                    Supprimer.Enabled = false;
                }

                if (t != -1)
                {
                    DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment modifier cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int admin;
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        if (motpasse.Text == confirmMotPasse.Text)
                        {
                            if(isadmin.Text == "Oui")
                            {
                                admin= 1;
                            }
                            else
                            {
                                admin = 0;
                            }
                            cmd.CommandText = "UPDATE users SET username = '" + textBox3.Text + "' , password = '" + motpasse.Text + "', nom = '"+ nomuser.Text + "', prenom = '"+ prenomuser.Text + "', numtel = '"+ numTeluser.Text + "' , isadmin ="+admin+" , adresse = '"+adresseuser.Text+"', datenaissance='"+datenaissanceuser.Value.ToString()+ "' Where id="+index;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Opération bien effectuer ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clear();
                            this.usersTableAdapter.Fill(this.gestionEcoleDataSet.users);
                            Ajouter.Enabled = true;
                            Supprimer.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe non conforme !");
                        }


                        
                    }
                    else
                    {
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                    }
                    t = -1;
                }
                else
                {
                    t = 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridView1.CurrentCell.RowIndex;
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "DELETE FROM users where id = " + index ;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.usersTableAdapter.Fill(this.gestionEcoleDataSet.users);
                    dataGridView1.RefreshEdit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from users where username Like '%" + username.Text + "%' or nom Like '%" + username.Text + "%' or prenom Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}