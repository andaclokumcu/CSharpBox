
namespace Veterinary
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
            this.dgrwVet = new System.Windows.Forms.DataGridView();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxAnimalName = new System.Windows.Forms.TextBox();
            this.tbxPersonalName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblPersonalName = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.lbxProduct = new System.Windows.Forms.ListBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwVet)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrwVet
            // 
            this.dgrwVet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrwVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwVet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrwVet.Location = new System.Drawing.Point(0, 0);
            this.dgrwVet.Name = "dgrwVet";
            this.dgrwVet.RowTemplate.Height = 25;
            this.dgrwVet.Size = new System.Drawing.Size(980, 150);
            this.dgrwVet.TabIndex = 0;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(139, 22);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 23);
            this.tbxID.TabIndex = 1;
            // 
            // tbxAnimalName
            // 
            this.tbxAnimalName.Location = new System.Drawing.Point(139, 70);
            this.tbxAnimalName.Name = "tbxAnimalName";
            this.tbxAnimalName.Size = new System.Drawing.Size(100, 23);
            this.tbxAnimalName.TabIndex = 2;
            // 
            // tbxPersonalName
            // 
            this.tbxPersonalName.Location = new System.Drawing.Point(139, 117);
            this.tbxPersonalName.Name = "tbxPersonalName";
            this.tbxPersonalName.Size = new System.Drawing.Size(100, 23);
            this.tbxPersonalName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(91, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 15);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID :";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(38, 73);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(77, 15);
            this.lblAnimalName.TabIndex = 5;
            this.lblAnimalName.Text = "Hayvan Adı : ";
            // 
            // lblPersonalName
            // 
            this.lblPersonalName.AutoSize = true;
            this.lblPersonalName.Location = new System.Drawing.Point(60, 120);
            this.lblPersonalName.Name = "lblPersonalName";
            this.lblPersonalName.Size = new System.Drawing.Size(55, 15);
            this.lblPersonalName.TabIndex = 6;
            this.lblPersonalName.Text = "Kişi Adı : ";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.lbxProduct);
            this.gbxAdd.Controls.Add(this.lblProduct);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxID);
            this.gbxAdd.Controls.Add(this.lblPersonalName);
            this.gbxAdd.Controls.Add(this.tbxAnimalName);
            this.gbxAdd.Controls.Add(this.lblAnimalName);
            this.gbxAdd.Controls.Add(this.tbxPersonalName);
            this.gbxAdd.Controls.Add(this.lblID);
            this.gbxAdd.Location = new System.Drawing.Point(71, 156);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(401, 239);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Bilgiler";
            // 
            // lbxProduct
            // 
            this.lbxProduct.FormattingEnabled = true;
            this.lbxProduct.ItemHeight = 15;
            this.lbxProduct.Location = new System.Drawing.Point(139, 146);
            this.lbxProduct.Name = "lbxProduct";
            this.lbxProduct.Size = new System.Drawing.Size(100, 79);
            this.lbxProduct.TabIndex = 8;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(60, 166);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(42, 15);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Ürün : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Listeye Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 407);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgrwVet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwVet)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwVet;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxAnimalName;
        private System.Windows.Forms.TextBox tbxPersonalName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblPersonalName;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxProduct;
        private System.Windows.Forms.Label lblProduct;
    }
}

