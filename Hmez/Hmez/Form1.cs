namespace Hmez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bColorForm_Click(object sender, EventArgs e)
        {
            var a = new ColorChangerForm();
            a.Show();
        }

        private void bFinder_Click(object sender, EventArgs e)
        {
            var a = new Finder();
            a.Show();
        }

        private void bPCShop_Click(object sender, EventArgs e)
        {
            var a = new ComputerShop();
            a.Show();
        }

        private void bFileEdit_Click(object sender, EventArgs e)
        {
            var a = new FileEditor();
            a.Show();
        }

        private void bRedactor_Click(object sender, EventArgs e)
        {
            var a = new Redactor();
            a.Show();
        }

        private void bWinForms_Click(object sender, EventArgs e)
        {
            var a = new WnForms();
            a.Show();
        }

        private void bConductor_Click(object sender, EventArgs e)
        {
            var a = new Conductor();
            a.Show();
        }
    }
}