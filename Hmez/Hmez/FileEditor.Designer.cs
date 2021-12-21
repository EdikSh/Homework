namespace Hmez
{
    partial class FileEditor
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
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.bLoad = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bSaveTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(12, 12);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.ReadOnly = true;
            this.rtbRead.Size = new System.Drawing.Size(309, 426);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(360, 125);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(122, 52);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Load File";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bEdit
            // 
            this.bEdit.Enabled = false;
            this.bEdit.Location = new System.Drawing.Point(360, 192);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(122, 52);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bSaveTo
            // 
            this.bSaveTo.Enabled = false;
            this.bSaveTo.Location = new System.Drawing.Point(360, 264);
            this.bSaveTo.Name = "bSaveTo";
            this.bSaveTo.Size = new System.Drawing.Size(122, 52);
            this.bSaveTo.TabIndex = 3;
            this.bSaveTo.Text = "Save To File";
            this.bSaveTo.UseVisualStyleBackColor = true;
            this.bSaveTo.Click += new System.EventHandler(this.bSaveTo_Click);
            // 
            // FileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 462);
            this.Controls.Add(this.bSaveTo);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.rtbRead);
            this.Name = "FileEditor";
            this.Text = "FileEditor";
            this.Load += new System.EventHandler(this.FileEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbRead;
        private Button bLoad;
        private Button bEdit;
        private Button bSaveTo;
    }
}