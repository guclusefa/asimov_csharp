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
    public partial class NoteItem : UserControl
    {
        public NoteItem(string libelleMatiere, string moyMatiere, string bilanMatiere)
        {
            InitializeComponent();
            // add margin bottom 20px
            this.Margin = new Padding(0, 0, 0, 20);

            // les values
            label1.Text = libelleMatiere;
            label5.Text = moyMatiere;
            label3.Text = bilanMatiere;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
