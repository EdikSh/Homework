namespace Hmez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bColorForm = new System.Windows.Forms.Button();
            this.bFinder = new System.Windows.Forms.Button();
            this.bPCShop = new System.Windows.Forms.Button();
            this.bFileEdit = new System.Windows.Forms.Button();
            this.bRedactor = new System.Windows.Forms.Button();
            this.bWinForms = new System.Windows.Forms.Button();
            this.bConductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bColorForm
            // 
            this.bColorForm.Location = new System.Drawing.Point(39, 54);
            this.bColorForm.Name = "bColorForm";
            this.bColorForm.Size = new System.Drawing.Size(105, 40);
            this.bColorForm.TabIndex = 0;
            this.bColorForm.Text = "ColorForm";
            this.bColorForm.UseVisualStyleBackColor = true;
            this.bColorForm.Click += new System.EventHandler(this.bColorForm_Click);
            // 
            // bFinder
            // 
            this.bFinder.Location = new System.Drawing.Point(187, 54);
            this.bFinder.Name = "bFinder";
            this.bFinder.Size = new System.Drawing.Size(105, 40);
            this.bFinder.TabIndex = 1;
            this.bFinder.Text = "Finder";
            this.bFinder.UseVisualStyleBackColor = true;
            this.bFinder.Click += new System.EventHandler(this.bFinder_Click);
            // 
            // bPCShop
            // 
            this.bPCShop.Location = new System.Drawing.Point(344, 54);
            this.bPCShop.Name = "bPCShop";
            this.bPCShop.Size = new System.Drawing.Size(105, 40);
            this.bPCShop.TabIndex = 2;
            this.bPCShop.Text = "Computer Shop";
            this.bPCShop.UseVisualStyleBackColor = true;
            this.bPCShop.Click += new System.EventHandler(this.bPCShop_Click);
            // 
            // bFileEdit
            // 
            this.bFileEdit.Location = new System.Drawing.Point(492, 54);
            this.bFileEdit.Name = "bFileEdit";
            this.bFileEdit.Size = new System.Drawing.Size(105, 40);
            this.bFileEdit.TabIndex = 3;
            this.bFileEdit.Text = "File Editor";
            this.bFileEdit.UseVisualStyleBackColor = true;
            this.bFileEdit.Click += new System.EventHandler(this.bFileEdit_Click);
            // 
            // bRedactor
            // 
            this.bRedactor.Location = new System.Drawing.Point(112, 173);
            this.bRedactor.Name = "bRedactor";
            this.bRedactor.Size = new System.Drawing.Size(105, 40);
            this.bRedactor.TabIndex = 4;
            this.bRedactor.Text = "Redactor";
            this.bRedactor.UseVisualStyleBackColor = true;
            this.bRedactor.Click += new System.EventHandler(this.bRedactor_Click);
            // 
            // bWinForms
            // 
            this.bWinForms.Location = new System.Drawing.Point(410, 173);
            this.bWinForms.Name = "bWinForms";
            this.bWinForms.Size = new System.Drawing.Size(105, 40);
            this.bWinForms.TabIndex = 5;
            this.bWinForms.Text = "Win Forms";
            this.bWinForms.UseVisualStyleBackColor = true;
            this.bWinForms.Click += new System.EventHandler(this.bWinForms_Click);
            // 
            // bConductor
            // 
            this.bConductor.Location = new System.Drawing.Point(266, 173);
            this.bConductor.Name = "bConductor";
            this.bConductor.Size = new System.Drawing.Size(105, 40);
            this.bConductor.TabIndex = 6;
            this.bConductor.Text = "Conductor";
            this.bConductor.UseVisualStyleBackColor = true;
            this.bConductor.Click += new System.EventHandler(this.bConductor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.bConductor);
            this.Controls.Add(this.bWinForms);
            this.Controls.Add(this.bRedactor);
            this.Controls.Add(this.bFileEdit);
            this.Controls.Add(this.bPCShop);
            this.Controls.Add(this.bFinder);
            this.Controls.Add(this.bColorForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bColorForm;
        private Button bFinder;
        private Button bPCShop;
        private Button bFileEdit;
        private Button bRedactor;
        private Button bWinForms;
        private Button bConductor;
    }
}