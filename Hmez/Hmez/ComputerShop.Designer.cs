namespace Hmez
{
    partial class ComputerShop
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
            this.bAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bBucket = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lProduct = new System.Windows.Forms.Label();
            this.tbPrice2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(680, 25);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(108, 42);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(596, 36);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(78, 23);
            this.tbPrice.TabIndex = 1;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lPrice.Location = new System.Drawing.Point(615, 12);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(45, 21);
            this.lPrice.TabIndex = 2;
            this.lPrice.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // bBucket
            // 
            this.bBucket.Location = new System.Drawing.Point(12, 386);
            this.bBucket.Name = "bBucket";
            this.bBucket.Size = new System.Drawing.Size(121, 52);
            this.bBucket.TabIndex = 5;
            this.bBucket.Text = "Add To Bucket";
            this.bBucket.UseVisualStyleBackColor = true;
            this.bBucket.Click += new System.EventHandler(this.bBucket_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(485, 14);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(87, 23);
            this.bRemove.TabIndex = 6;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Mouse",
            "KeyBoard",
            "HeadPhones"});
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 319);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lProduct
            // 
            this.lProduct.AutoSize = true;
            this.lProduct.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProduct.Location = new System.Drawing.Point(26, 14);
            this.lProduct.Name = "lProduct";
            this.lProduct.Size = new System.Drawing.Size(89, 30);
            this.lProduct.TabIndex = 8;
            this.lProduct.Text = "Product";
            // 
            // tbPrice2
            // 
            this.tbPrice2.Location = new System.Drawing.Point(139, 51);
            this.tbPrice2.Name = "tbPrice2";
            this.tbPrice2.ReadOnly = true;
            this.tbPrice2.Size = new System.Drawing.Size(78, 23);
            this.tbPrice2.TabIndex = 9;
            this.tbPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComputerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrice2);
            this.Controls.Add(this.lProduct);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bBucket);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.bAdd);
            this.Name = "ComputerShop";
            this.Text = "ComputerShop";
            this.Load += new System.EventHandler(this.ComputerShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bAdd;
        private TextBox tbPrice;
        private Label lPrice;
        private ComboBox comboBox1;
        private Button bBucket;
        private Button bRemove;
        private ListBox listBox1;
        private Label lProduct;
        private TextBox tbPrice2;
    }
}