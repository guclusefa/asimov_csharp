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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // close this and open connexion
            this.Hide();
            Connexion connexion = new Connexion();
            connexion.Show();
        }
    }
}
