namespace Hmez
{
    partial class Finder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.bFind = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(23, 22);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(605, 23);
            this.tbLocation.TabIndex = 0;
            this.tbLocation.Text = "C:\\Users\\Олег\\Desktop\\Testing";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(23, 68);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 23);
            this.tbType.TabIndex = 1;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(154, 68);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(89, 23);
            this.bFind.TabIndex = 2;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Found Elements:"});
            this.listBox1.Location = new System.Drawing.Point(23, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 229);
            this.listBox1.TabIndex = 3;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 426);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbLocation);
            this.Name = "Finder";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbLocation;
        private TextBox tbType;
        private Button bFind;
        private ListBox listBox1;
    }
}