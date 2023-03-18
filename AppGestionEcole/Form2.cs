using System;
using System.Windows.Forms;

namespace AppGestionEcole
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            classeControl11.Visible= false;
            filiereControl11.Visible= false;
            profControle1.Visible= false;
            userControle1.Visible = false;
            profControle1.Visible= false;
            ecoleControl11.Visible= false;
            etudiantControle1.Visible = true;
            accueil1.Visible= false;
            paimentEtu1.Visible = false;

        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = true;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = false;

        }

        private void btnFiliere_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = true;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = false;

        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = true;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = false;

        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = true;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = false;

        }

        private void btnInfoEcole_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = true;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = true;
            paimentEtu1.Visible = false;
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = true;
            paimentEtu1.Visible = false;

        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            classeControl11.Visible = false;
            filiereControl11.Visible = false;
            profControle1.Visible = false;
            userControle1.Visible = false;
            profControle1.Visible = false;
            ecoleControl11.Visible = false;
            etudiantControle1.Visible = false;
            accueil1.Visible = false;
            paimentEtu1.Visible = true;
        }
    }
}
