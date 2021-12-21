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
    public partial class FileChange : Form
    {
        public FileChange()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileChange_Load(object sender, EventArgs e)
        {
            rtbEditor.Text = Classass.text;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Classass.text = rtbEditor.Text;
            Close();
        }
    }
}
