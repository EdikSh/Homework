namespace Hmez
{
    partial class FileChange
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
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Location = new System.Drawing.Point(12, 12);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(284, 414);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(339, 129);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(117, 56);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(339, 213);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(117, 56);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // FileChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 438);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.rtbEditor);
            this.Name = "FileChange";
            this.Text = "FileChange";
            this.Load += new System.EventHandler(this.FileChange_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbEditor;
        private Button bSave;
        private Button bCancel;
    }
}