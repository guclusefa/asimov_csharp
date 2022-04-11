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
    public partial class Notes : Form
    {
        // importation des methods
        Methods methods = new Methods();

        // initialisation
        public Notes()
        {
            InitializeComponent();

            // récup data
            var data = methods.getRequest("/notes/fiche_eleve/0/0");

            // init des cb
            methods.initEleves(cb_eleve, data["lesEleves"], null);
        }

        // les eleves
        private void cb_eleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if index not 0
            if (cb_eleve.SelectedIndex != 0)
            {
                // récup data
                var data = methods.getRequest("/notes/fiche_eleve/" + (cb_eleve.SelectedItem as dynamic).Value.ToString() + "/0");

                // show tab control
                tc_eleves.Visible = true;

                // show combo box
                cb_classe.Visible = true;
                l_classe.Visible = true;

                // hide tab control
                tc_notes.Visible = false;

                // les data
                l_nom.Text = data["unEleve"]["user_nom"].ToString();
                l_prenom.Text = data["unEleve"]["user_prenom"].ToString();
                l_age.Text = data["unEleve"]["user_dateNaissance"].ToString() + " (" + data["unEleve"]["user_age"].ToString() + "ans)";
                l_sexe.Text = data["unEleve"]["user_sexe"].ToString();
                l_tel.Text = data["unEleve"]["user_tel"].ToString();
                l_email.Text = data["unEleve"]["user_mail"].ToString();

                // init cursus
                methods.initCursus(cb_classe, data["lesCursus"], null);
            } else
            {
                // hide tab control
                tc_eleves.Visible = false;
                tc_notes.Visible = false;

                // hide combo box
                cb_classe.Visible = false;
                l_classe.Visible = false;
            }
        }

        // les classes
        private void cb_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear all controls of panel
            panel_notesT1.Controls.Clear();
            panel_notesT2.Controls.Clear();
            panel_notesT3.Controls.Clear();
            panel_notesT4.Controls.Clear();


            // if index not 0
            if (cb_classe.SelectedIndex != 0)
            {
                // récup data
                var data = methods.getRequest("/notes/fiche_eleve/" + (cb_eleve.SelectedItem as dynamic).Value.ToString() + "/" + (cb_classe.SelectedItem as dynamic).Value.ToString());

                // for each les matieres
                foreach (JObject item in data["lesMatieres"]) {
 
                    // t1
                    if (item["notesT1"].Count() > 0)
                    {                        
                        string libelle = item["matiere_libelle"].ToString();
                        string moyEleve;
                        string moyClasse;
                        string max;
                        string min;
                        // if item not defined
                        if (item["bilanT1"].Count() > 0)
                        {
                            moyEleve = item["bilanT1"]["eleve_avg"].ToString() + "%";
                            moyClasse = item["bilanT1"]["classe_avg"].ToString() + "%";
                            max = item["bilanT1"]["classe_max"].ToString() + "%";
                            min = item["bilanT1"]["classe_min"].ToString() + "%";
                        }
                        else
                        {
                            moyEleve = "A definir";
                            moyClasse = "A definir";
                            min = "A definir";
                            max = "A definir";
                        }
                        string bilanMatiere = $"Moy: {moyClasse} Min: {min} Max: {max}";

                        NoteItem ni = new NoteItem(libelle, moyEleve, bilanMatiere);
                        panel_notesT1.Controls.Add(ni);
                        
                        // les evals
                        foreach (JToken eval in item["notesT1"])
                        {
                            string libelleEval = eval["eval_date"].ToString() + " : " + eval["eval_desc"].ToString();
                            string moyEval = methods.checkNotes(eval["note_valeur"].ToString(), "Absent");
                            string moyEvalClasse = methods.checkNotes(eval["eval_avg"].ToString(), "A definir");
                            string minEvalClasse = methods.checkNotes(eval["eval_min"].ToString(), "A definir");
                            string maxEvalClasse = methods.checkNotes(eval["eval_max"].ToString(), "A definir");

                            string bilanEval = $"Moy: {moyEvalClasse} Min: {minEvalClasse} Max: {maxEvalClasse}";
                            NoteItemEval ni2 = new NoteItemEval(libelleEval, moyEval, bilanEval);
                            panel_notesT1.Controls.Add(ni2);

                            // if last add margin bottom
                            if (item["notesT1"].Last() == eval)
                            {
                                ni2.Margin = new Padding(0, 0, 0, 20);
                            }
                        }

                        // bilan
                        l_moyenneEleveT1.Text = methods.checkNotes(data["bilanClasseT1"][0].ToString(), "A definir");
                        l_moyenneClasseT1.Text = methods.checkNotes(data["bilanClasseT1"][1].ToString(), "A definir");
                    } else
                    {
                        MessageBox.Show("aucune note pour cette matiere");
                    }
                }

                // show tab control
                tc_notes.Visible = true;
            }
            else
            {
                // hide tab control
                tc_notes.Visible = false;
            }
        }

        // quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            methods.revenirIndex(this);
        }
    }
}
