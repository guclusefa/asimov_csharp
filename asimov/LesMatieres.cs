using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asimov
{
    public partial class LesMatieres : Form
    {
        // importation des methods
        Methods methods = new Methods();

        public LesMatieres()
        {
            InitializeComponent();
            getLesMatieres();
        }

        // recuper les matieres
        public void getLesMatieres()
        {
            // requete des matieres
            string url = "/matieres/liste";
            var data = methods.getRequest(url);

            // clear tableau
            dg_lesMatieres.Rows.Clear();
            dg_lesMatieres.Refresh();

            // affichage des data dans le tableau
            foreach (var item in data["lesMatieres"])
            {
                dg_lesMatieres.Rows.Add(item["matiere_id"], item["matiere_libelle"]);
            }
        }

        // les params qu'on fait passer
        public static int modifier = 0;
        public static string matiere_id = "";
        public static string matiere_libelle = "";

        // ajouter
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            // modification a 0
            modifier = 0;

            // open ajouter matiere dialog
            FormMatiere formMatiere = new FormMatiere();
            formMatiere.ShowDialog();

            // refresh
            getLesMatieres();
        }

        // modifier
        private void btn_modifierMatiere_Click(object sender, EventArgs e)
        {
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                // recupere id selectionné
                DataGridViewRow row = this.dg_lesMatieres.SelectedRows[0];

                // faire passer params
                modifier = 1;
                matiere_id = row.Cells["id"].Value.ToString();
                matiere_libelle = row.Cells["libelle"].Value.ToString();

                // open ajouter matiere dialog
                FormMatiere formMatiere = new FormMatiere();
                formMatiere.ShowDialog();

                // refresh
                getLesMatieres();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere", "Erreur");
            }
        }

        // supprimer 
        private void btn_supprimerMatiere_Click(object sender, EventArgs e)
        {
            // si ligne choisie
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                // confirmations
                var confirmResult = MessageBox.Show("Êtes-vous sûr de supprimer " + dg_lesMatieres.SelectedRows.Count.ToString() + " matière(s) ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);


                // si supprimer
                if (confirmResult == DialogResult.Yes)
                {
                    // les requetes de delete
                    foreach (DataGridViewRow r in dg_lesMatieres.SelectedRows)
                    {
                        // requete get
                        string url = "/matieres/supprimer/" + r.Cells["id"].Value.ToString();
                        methods.getRequest(url);
                    }

                    // msg succès
                    MessageBox.Show("Supprimé "+ dg_lesMatieres.SelectedRows.Count.ToString()+ " matière(s) avec succès", "Succès");

                    // refresh
                    getLesMatieres();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere", "Erreur");
            }
        }

        // quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // revnir index
            this.Hide();
            Index index = new Index();
            index.Show();
        }
    }
}
