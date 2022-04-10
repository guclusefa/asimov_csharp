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
    public partial class FormEval : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        // les params
        public static int modifier;
        public static string id;
        public static JObject data;

        public FormEval(int modifierForm, string idForm)
        {
            InitializeComponent();

            // initialisation des params
            modifier = modifierForm;
            id = idForm;

            data = methods.getRequest("/evaluations/ajouter/");

            // init trimestre
            methods.initTrimestres(cb_trimestre);
            methods.initCursus(cb_classes, data["lesCursus"], null);
            methods.emptyMatieres(cb_matieres);
            
            // si modifier
            if (modifier == 1)
            {
                // les labels
                this.Text = "Modifier une évaluation";
                label1.Text = "Modifier une évaluation";
                btn_valider.Text = "Modifier";
                label6.Text = "Les notes";

                // les values
                data = methods.getRequest("/evaluations/modifier/" + id);

                // set cb_matiere text
                cb_classes.Text = data["uneEval"]["classe_libelle"].ToString() + " " + data["uneEval"]["cursus_libelle"].ToString() + " (" + data["uneEval"]["cursus_anneeScolaire"].ToString() + ")";
 
                // add item to combo box
                cb_classes.Items.Add(cb_classes.Text);
                cb_matieres.Items.Add(data["uneEval"]["matiere_libelle"].ToString() + " (Prof. " + data["uneEval"]["user_prenom"].ToString() + data["uneEval"]["user_nom"].ToString() + ")");

                // select added item
                cb_matieres.SelectedIndex = cb_matieres.Items.Count - 1;

                // disable cbs
                cb_classes.Enabled = false;
                cb_matieres.Enabled = false;

                // set values
                tb_desc.Text = data["uneEval"]["eval_desc"].ToString();
                methods.getSelect(cb_trimestre, data["uneEval"]["eval_trimestre"].ToString());
                dtp_date.Value = DateTime.Parse(data["uneEval"]["eval_date"].ToString());

                // nptes
                // on ajoute une cb pr tout les eleves
                foreach (JObject eleve in data["lesEleves"])
                {
                    methods.addLesElevesNotes(panel_notes, data["lesEleves"], eleve["user_id"], eleve["note_valeur"]);
                }                
            }
        }


        // matieres
        private void cb_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if index not 0
            if (cb_classes.SelectedIndex != 0 && (cb_classes.SelectedItem as dynamic).Value.ToString() != "")
            {
                // remplir les champs
                methods.initMatieres(cb_matieres, (cb_classes.SelectedItem as dynamic).Value.ToString(), data["lesMatieresParCursus"], null);
            }
            else
            {
                // empty combo box
                methods.emptyMatieres(cb_matieres);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // les params
            string url;
            string[] lesParams = {
                    "desc", tb_desc.Text,
                    "date", dtp_date.Text,
                    "trimestre", (cb_trimestre.SelectedItem as dynamic).Value.ToString()
            };

            // si pour ajouter sinon pour ajouter
            if (modifier == 0)
            {
                // les params ajouter
                url = "/evaluations/ajouter";
                lesParams = lesParams.Concat(new string[] {
                    "cursus", (cb_classes.SelectedItem as dynamic).Value.ToString(),
                    "matiere", (cb_matieres.SelectedItem as dynamic).Value.ToString()
                }).ToArray();
            }
            else
            {
                // les params modifier
                url = "/evaluations/modifier/" + id;
                lesParams = lesParams.Concat(new string[] {
                    "eleves", methods.getValuesComboBox(panel_notes),
                    "notes", methods.getValuesTextBox(panel_notes),
                    "id", id
                }).ToArray();
            }

            // json
            string json = methods.generateJson(lesParams);

            //requete ajouter
            methods.validate(url, json, this);
        }
    }
}
