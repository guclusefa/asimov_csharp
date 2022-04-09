using Newtonsoft.Json.Linq;
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
    public partial class FormClasse : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        // les params
        public static int modifier;
        public static string id;
        public static JObject data;

        public FormClasse(int modifierForm, string idForm)
        {
            InitializeComponent();

            // initialisation des params
            modifier = modifierForm;
            id = idForm;

            data = methods.getRequest("/classes/ajouter/");

            // remplir les datalist
            methods.initClasses(cb_classes, data["lesClasses"]);
            methods.initProfsPrincipal(cb_pp, data["lesProfs"]);

            // remplir eleves et matieres
            methods.addLesMatieres(panel_matieres, data["lesMatieres"], data["lesProfs"]);
            methods.addLesEleves(panel_eleves, data["lesEleves"]);

            // si modifier
            if (modifier == 1)
            {
                // les labels
                this.Text = "Modifier une classe";
                label1.Text = "Modifier une classe";
                btn_valider.Text = "Modifier";

                // les values
                data = methods.getRequest("/classes/modifier/" + id);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
        }

        private void btn_ajouterEleve_Click(object sender, EventArgs e)
        {
            methods.addLesEleves(panel_eleves, data["lesEleves"]);
        }

        private void btn_supprimerEleve_Click(object sender, EventArgs e)
        {
            methods.deleteComboBox(panel_eleves);
        }
    }
}
