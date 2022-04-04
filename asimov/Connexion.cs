namespace asimov
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open index
            this.Hide();
            Index index = new Index();
            index.Show();
        }
    }
}