using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppGestionEcole
{
    public partial class FiliereControl1 : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public FiliereControl1()
        {
            InitializeComponent();
        }

        private void FiliereControl1_Load(object sender, EventArgs e)
        {
            this.filiereTableAdapter.Fill(this.gestionEcoleDataSet2.filiere);
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

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO filiere(nomFiliere,abréviation,datecreation) VALUES('" + nomFiliere.Text + "','" + abrviation.Text + "','" + datecreation.Value.Date.ToString() + "')";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                this.filiereTableAdapter.Fill(this.gestionEcoleDataSet2.filiere);
                dataGridView1.RefreshEdit();
                this.clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            nomFiliere.Text = "";
            abrviation.Text = "";
            datecreation.Value = DateTime.Now;
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
                    string query = "DELETE FROM filiere where idFiliere = " + index;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.filiereTableAdapter.Fill(this.gestionEcoleDataSet2.filiere);
                    dataGridView1.RefreshEdit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        nomFiliere.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                        abrviation.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                        datecreation.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                        Ajouter.Enabled = false;
                        Supprimer.Enabled = false;
                    }

                    if (t != -1)
                    {
                        DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment modifier cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE filiere SET nomFiliere = '" + nomFiliere.Text + "' , abréviation = '" + abrviation.Text + "', datecreation= '" + datecreation.Value.Date.ToString() + "' WHERE idFiliere =" + index + ";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Opération bien effectuer ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clear();
                            Ajouter.Enabled = true;
                            Supprimer.Enabled = true;
                            this.filiereTableAdapter.Fill(this.gestionEcoleDataSet2.filiere);
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
            string sql = "SELECT * from filiere where nomFiliere Like '%" + username.Text + "%' or abréviation Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}
