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
    public partial class Conductor : Form
    {
        public Conductor()
        {
            InitializeComponent();
        }

        private void Conductor_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo a in drives)
            {
                var rootdisk = new TreeNode()
                {
                    Text = a.Name
                };
                var directoryInfo = Directory.GetDirectories($@"{rootdisk.Text}");
                for (int i = 0; i < directoryInfo.Count(); i++)
                {
                    rootdisk.Nodes.Add(new TreeNode(directoryInfo[i]) { Tag = true });
                }
                treeView1.Nodes.Add(rootdisk);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = treeView1.SelectedNode;
            var directoryInfo = Directory.GetDirectories($@"{node.Text}");

            if (node != null)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    if ((bool)n.Tag == true && n.Nodes.Count == 0)
                    {
                        for (int i = 0; i < directoryInfo.Count(); i++)
                        {
                            n.Nodes.Add(new TreeNode(directoryInfo[i]) { Tag = true });
                        }
                    }
                }
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            var files = Directory.GetFiles($@"{node.Text}");
            listBox1.Items.Clear();
            foreach(var a in files)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
