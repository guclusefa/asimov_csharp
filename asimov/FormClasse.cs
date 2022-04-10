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

            // si modifier
            if (modifier == 1)
            {
                // les labels
                this.Text = "Modifier une classe";
                label1.Text = "Modifier une classe";
                btn_valider.Text = "Modifier";

                // les values
                data = methods.getRequest("/classes/modifier/" + id);

                //atribuer values
                tb_libelle.Text = data["uneClasse"]["cursus_libelle"].ToString();
                dtp_annee.Value = DateTime.Parse(methods.generateDateTime(data["uneClasse"]["cursus_anneeScolaire"].ToString()));

                methods.addLesMatieres(panel_matieres, data["lesMatieres"], data["lesProfs"], data["lesProfsClasse"]);
                methods.getSelect(cb_classes, data["uneClasse"]["classe_id"].ToString());
                methods.getSelect(cb_pp, data["uneClasse"]["user_id"].ToString());

                // on ajoute une cb pr tout les eleves
                foreach (JObject eleve in data["lesElevesClasse"])
                {
                    methods.addLesEleves(panel_eleves, data["lesEleves"], eleve["user_id"]);
                }
            }
            else
            {
                // remplir matieres
                methods.addLesMatieres(panel_matieres, data["lesMatieres"], data["lesProfs"], null);
                // on ajoute 1 cb eleve
                methods.addLesEleves(panel_eleves, data["lesEleves"], null);
            }
        }

        // ajouter eleve
        private void btn_ajouterEleve_Click(object sender, EventArgs e)
        {
            methods.addLesEleves(panel_eleves, data["lesEleves"], null);
        }

        // supprimer eleve
        private void btn_supprimerEleve_Click(object sender, EventArgs e)
        {
            methods.deleteComboBox(panel_eleves);
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // les params
            string url;
            string[] lesParams = {
                    "annee", dtp_annee.Text,
                    "libelle", tb_libelle.Text,
                    "classe", (cb_classes.SelectedItem as dynamic).Value.ToString(),
                    "principal", (cb_pp.SelectedItem as dynamic).Value.ToString(),
                    "eleves", methods.getValuesComboBox(panel_eleves),
                    "profs", methods.getValuesComboBox(panel_matieres)
            };

            // si pour ajouter sinon pour ajouter
            if (modifier == 0)
            {
                // les params ajouter
                url = "/classes/ajouter";
            }
            else
            {
                // les params modifier
                url = "/classes/modifier/" + id;

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
