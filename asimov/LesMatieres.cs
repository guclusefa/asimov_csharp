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
        public LesMatieres()
        {
            InitializeComponent();
            Methods methods = new Methods();
            // requete des matieres
            string url = "/matieres/liste";
            var data = methods.getRequest(url);
            foreach (var item in data["lesMatieres"])
            {
                dg_lesMatieres.Rows.Add(item["matiere_id"], item["matiere_libelle"]);
            }
        }


        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // revnir index
            this.Hide();
            Index index = new Index();
            index.Show();
        }

        private void btn_modifierMatiere_Click(object sender, EventArgs e)
        {
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dg_lesMatieres.SelectedRows[0];
                MessageBox.Show(row.Cells["id"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            // open ajouter matiere dialog
            AjouterMatiere ajouterMatiere = new AjouterMatiere();
            ajouterMatiere.ShowDialog();
        }
    }
}
