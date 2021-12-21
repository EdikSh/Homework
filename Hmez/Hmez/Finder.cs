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
    public partial class Finder : Form
    {
        public Finder()
        {
            InitializeComponent();
        }

        private void Finder_Load(object sender, EventArgs e)
        {

        }

        private void bFind_Click(object sender, EventArgs e)
        {
            //var folder = Directory.GetFiles($@"{tbLocation}", ".txt", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles($@"{tbLocation.Text}", $"*{tbType.Text}", SearchOption.AllDirectories);
            listBox1.Items.Clear();
            listBox1.Items.Add("Found Elements:");
            foreach(var i in files)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
