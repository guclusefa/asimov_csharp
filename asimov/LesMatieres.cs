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
            
            // remplir tableau
            methods.fillDataGrid(dg_lesMatieres, "/matieres/liste", "MAT");
        }

        // détail
        private void btn_detail_Click(object sender, EventArgs e)
        {
            methods.showDetail("/matieres/fiche/", dg_lesMatieres, "MAT");
        }
        
        // ajouter
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            methods.showAdd("/matieres/ajouter", dg_lesMatieres, "MAT");
        }

        // modifier
        private void btn_modifierMatiere_Click(object sender, EventArgs e)
        {
            methods.showModify("/matieres/modifier/", dg_lesMatieres, "MAT");
        }

        // supprimer
        private void btn_supprimerMatiere_Click(object sender, EventArgs e)
        {
            methods.delete("/matieres/supprimer/", dg_lesMatieres, "MAT");
        }

        // chercher
        private void tb_chercher_TextChanged(object sender, EventArgs e)
        {
            methods.searchDataGrid(dg_lesMatieres, tb_chercher);
        }

        // quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            methods.revenirIndex(this);
        }
    }
}
