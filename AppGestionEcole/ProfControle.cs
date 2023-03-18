using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AppGestionEcole
{
    public partial class ProfControle : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public ProfControle()
        {
            InitializeComponent();
        }

        private void ProfControle_Load(object sender, EventArgs e)
        {
            this.profTableAdapter.Fill(this.gestionEcoleDataSet3.prof);
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            nomprof.Text = "";
            prenomprof.Text = "";
            numtelprof.Text = "";
            genreprof.Text = "";
            salaireprof.Text = "";
            mailprof.Text = "";
            datenaissanceprof.Value = DateTime.Now;
            adresseprof.Text = "";
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO prof (nom, prenom, numtel, genre, salaire, mail, datenaissance, adresse) VALUES ('" + nomprof.Text + "','" + prenomprof.Text + "','" + numtelprof.Text + "','" + genreprof.Text + "'," + float.Parse(salaireprof.Text) + ",'" + mailprof.Text + "','" + datenaissanceprof.Value.ToString() + "','" + adresseprof.Text + "')";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                this.profTableAdapter.Fill(this.gestionEcoleDataSet3.prof);
                dataGridView1.RefreshEdit();
                this.clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "DELETE FROM prof where idProf=" + index + ";";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.profTableAdapter.Fill(this.gestionEcoleDataSet3.prof);
                    dataGridView1.RefreshEdit();
                }
            
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
                    nomprof.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                    prenomprof.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                    numtelprof.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                    genreprof.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
                    salaireprof.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
                    mailprof.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
                    datenaissanceprof.Text = dataGridView1.Rows[id].Cells[7].Value.ToString();
                    adresseprof.Text = dataGridView1.Rows[id].Cells[8].Value.ToString();
                }

                if (t != -1)
                {
                    DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment modifier cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE prof SET nom = '"+nomprof.Text+"' , prenom= '"+prenomprof.Text+"' , numtel= '"+numtelprof.Text+"' , genre= '"+genreprof.Text+"' , salaire= "+float.Parse(salaireprof.Text)+" , mail= '"+mailprof.Text+"' , datenaissance= '"+datenaissanceprof.Text+"' , adresse= '"+adresseprof.Text+"' where idProf = "+index;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Opération bien effectuer ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                        this.profTableAdapter.Fill(this.gestionEcoleDataSet3.prof);

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

        private void username_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from prof where nom Like '%" + username.Text + "%' or prenom Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}