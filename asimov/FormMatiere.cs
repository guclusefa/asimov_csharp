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
    public partial class FormMatiere : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        // les params
        public static int modifier;
        public static string id;

        public FormMatiere(int modifierForm, string idForm)
        {
            InitializeComponent();

            // initialisation des params
            modifier = modifierForm;
            id = idForm;

            // si modifier
            if (modifier == 1)
            {
                // les labels
                this.Text = "Modifier matière";
                label1.Text = "Modifier matière";
                btn_valider.Text = "Modifier";

                // les values
                var data = methods.getRequest("/matieres/modifier/"+id);

                // attribuer values
                tb_libelle.Text = data["uneMatiere"]["matiere_libelle"].ToString();
            }
        }

        // valider
        private void btn_valider_Click(object sender, EventArgs e)
        {
            // les params
            string url;
            string[] lesParams = { "libelle", tb_libelle.Text };

            // si pour ajouter sinon pour ajouter
            if (modifier == 0)
            {
                // les params ajouter
                url = "/matieres/ajouter";
            } else
            {
                // les params modifier
                url = "/matieres/modifier/" + id;
                
                // add to lesParams
                lesParams = lesParams.Concat(new string[] { "id", id }).ToArray();
            }
            // json
            string json = methods.generateJson(lesParams);

            //requete ajouter
            methods.validate(url, json, this);            
        }
    }
}
