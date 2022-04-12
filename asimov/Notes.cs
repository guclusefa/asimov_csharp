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

            // if index not 0
            if (cb_classe.SelectedIndex != 0)
            {
                // récup data
                var data = methods.getRequest("/notes/fiche_eleve/" + (cb_eleve.SelectedItem as dynamic).Value.ToString() + "/" + (cb_classe.SelectedItem as dynamic).Value.ToString());

                // show notes par trimestre
                methods.showNotes(data, "T1", panel_notesT1, l_moyenneEleveT1, l_moyenneClasseT1, label_moyET1, label_moyCT1, btn_grapheT1);
                methods.showNotes(data, "T2", panel_notesT2, l_moyenneEleveT2, l_moyenneClasseT2, label_moyET2, label_moyCT2, btn_grapheT2);
                methods.showNotes(data, "T3", panel_notesT3, l_moyenneEleveT3, l_moyenneClasseT3, label_moyET3, label_moyCT3, btn_grapheT3);
                
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
