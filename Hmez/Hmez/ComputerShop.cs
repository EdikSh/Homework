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
    public partial class ComputerShop : Form
    {
        private List<string> price = new List<string>() { "300", "250", "150"};
        private List<string> totalprice = new List<string>();

        public ComputerShop()
        {
            InitializeComponent();
        }

        private void ComputerShop_Load(object sender, EventArgs e)
        {

        }

        private void bBucket_Click(object sender, EventArgs e)
        {
            var a = listBox1.SelectedIndex;
            comboBox1.Items.Add(listBox1.SelectedItem);
            if(tbPrice.Text != "")
            {
                int sum = Convert.ToInt32(tbPrice.Text) + Convert.ToInt32(price[a]);
                tbPrice.Text = Convert.ToString(sum);
            } else
            {
                tbPrice.Text = price[a];
            }
            totalprice.Add(price[a]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = listBox1.SelectedIndex;
            tbPrice2.Text = price[a];
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            var a = comboBox1.SelectedIndex;
            int sum = Convert.ToInt32(tbPrice.Text) - Convert.ToInt32(totalprice[a]);
            tbPrice.Text = Convert.ToString(sum);
            comboBox1.Items.RemoveAt(a);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var a = new StuffAddcs();
            a.ShowDialog();
            listBox1.Items.Add(Classass.newname);
            price.Add(Classass.newprice);
        }
    }
}
