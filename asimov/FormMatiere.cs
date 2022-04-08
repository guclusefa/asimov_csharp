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
                label1.Text = "Modifier";
                btn_valider.Text = "Modifier";

                // les values
                var data = methods.getRequest("/matieres/modifier/"+id);

                // attribuer values
                tb_libelle.Text = data["uneMatiere"]["matiere_libelle"].ToString();
            }
        }

        // format json pour ajouter
        private string jsonAjouter(string libelle)
        {
            string json = "{" +
                "\"libelle\":\"" + libelle + "\"" +
                "}";
            return json;
        }
        
        // format json pour modifier
        private string jsonModifier(string libelle, string id)
        {
            string json = "{" +
                "\"libelle\":\"" + libelle + "\"," +
                "\"id\":\"" + id + "\"" +
                "}";
            return json;
        }

        // valider
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string url;
            string json;
            
            // si pour ajouter sinon pour ajouter
            if (modifier == 0)
            {
                url = "/matieres/ajouter";
                json = jsonAjouter(tb_libelle.Text);
            } else
            {
                url = "/matieres/modifier/" + id;
                json = jsonModifier(tb_libelle.Text, id);
            }
            
            //requete
            methods.validate(url, json, this);
        }
    }
}
