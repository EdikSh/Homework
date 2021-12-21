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
    public partial class ColorChangerForm : Form
    {
        public ColorChangerForm()
        {
            InitializeComponent();
        }

        private void ColorChangerForm_Load(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelColorText.Text = "Color Changer";
            languageToolStripMenuItem.Text = "Language";
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelColorText.Text = "Изменение Цвета";
            languageToolStripMenuItem.Text = "Язык";
        }

        private void ukranianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelColorText.Text = "Зміна Кольору";
            languageToolStripMenuItem.Text = "Мова";
        }

        private void Bar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void rollUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
