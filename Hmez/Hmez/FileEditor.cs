using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hmez
{
    public partial class FileEditor : Form
    {
        private string name = "";

        public FileEditor()
        {
            InitializeComponent();
        }

        private void FileEditor_Load(object sender, EventArgs e)
        {

        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                name = file.FileName;
                rtbRead.Clear();
                rtbRead.Text = File.ReadAllText(name);
                bEdit.Enabled = true;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Classass.text = rtbRead.Text;
            var a = new FileChange();
            a.ShowDialog();
            rtbRead.Text = Classass.text;
            bSaveTo.Enabled = true;
        }

        private void bSaveTo_Click(object sender, EventArgs e)
        {
            File.WriteAllText(name, rtbRead.Text);
        }
    }
}
