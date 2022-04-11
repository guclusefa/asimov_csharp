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
    public partial class NoteItemEval : UserControl
    {
        public NoteItemEval(string libelle, string moy, string bilan)
        {
            InitializeComponent();
            // margin bottom 0
            this.Margin = new Padding(0, 0, 0, 0);

            // les valeurs
            label2.Text = libelle;
            label6.Text = moy;
            label4.Text = bilan;
        }
    }
}
