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
    public partial class Liste : Form
    {
        // importation des methods
        Methods methods = new Methods();

        // les params
        public static string titre;
        public static string route;
        public static string type;

        public Liste(string titreForm, string routeForm, string typeForm)
        {
            InitializeComponent();

            // initialisation des params
            titre = titreForm;
            route = routeForm;
            type = typeForm;

            // les labesl
            this.Text = titre;
            label1.Text = titre;

            // remplir tableau
            methods.fillDataGrid(dgv_liste, route + "/liste", type);
        }

        // détail
        private void btn_detail_Click(object sender, EventArgs e)
        {
            methods.showDetail(route + "/fiche/", dgv_liste, type);
        }
        
        // ajouter
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            methods.showAdd(route + "/ajouter", dgv_liste, type);
        }

        // modifier
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            methods.showModify(route + "/modifier/", dgv_liste, type);
        }

        // supprimer
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            methods.delete(route + "/supprimer/", dgv_liste, type);
        }

        // chercher
        private void tb_chercher_TextChanged(object sender, EventArgs e)
        {
            methods.searchDataGrid(dgv_liste, tb_chercher);
        }

        // quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            methods.revenirIndex(this);
        }
    }
}
