using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionEcole
{
    public partial class EcoleControl1 : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public EcoleControl1()
        {
            InitializeComponent();
        }

        private void EcoleControl1_Load(object sender, EventArgs e)
        {
            this.ecoleTableAdapter.Fill(this.gestionEcoleDataSet1.ecole);
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
            string insert = "INSERT INTO ecole(nomEcole , adresseEcole , logo , numtel , emailEcole , siteweb , rib) " +
                            "VALUES ('"+nomEcole.Text+"','"+AdresseEcole.Text+"','"+logo+"','"+numTelEcole.Text+"','"+mailEcole.Text+"','"+siteweb.Text+"','"+rib.Text+"')";
            cmd.CommandText = insert;
            cmd.ExecuteNonQuery();
            this.ecoleTableAdapter.Fill(this.gestionEcoleDataSet1.ecole);
            dataGridView1.RefreshEdit();
            this.clear();


        }
        public void clear()
        {
            nomEcole.Text = "";
            AdresseEcole.Text = "";
            numTelEcole.Text = "";
            mailEcole.Text = "";
            siteweb.Text = "";
            rib.Text = "";
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
                    nomEcole.Text = dataGridView1.Rows[id].Cells[1].Value.ToString(); 
                    AdresseEcole.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                    numTelEcole.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                    mailEcole.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
                    siteweb.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
                    rib.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
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
                        cmd.CommandText = "UPDATE ecole SET nomEcole = '"+nomEcole.Text+"' , adresseEcole = '"+AdresseEcole.Text+"'" +
                            ",logo = '"+logo.ImageLocation+"' ,numtel = '"+numTelEcole.Text + "',emailEcole = '"+mailEcole.Text+"',siteweb = '"+siteweb.Text+"',rib = '"+rib.Text+ "' WHERE idEcole="+index;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Opération bien effectuer ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                        this.ecoleTableAdapter.Fill(this.gestionEcoleDataSet1.ecole);
                        t = -1;
                    }
                    else
                    {
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                    }
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
            int id = dataGridView1.CurrentCell.RowIndex;
            if(id != -1)
            {
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "DELETE FROM ecole where idEcole=" + index + ";";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.ecoleTableAdapter.Fill(this.gestionEcoleDataSet1.ecole);
                    dataGridView1.RefreshEdit();
                }
            }
            else
            {
                MessageBox.Show("La table est vide ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void logo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                logo.Image = new Bitmap(dialog.FileName);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from ecole where nomEcole Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}