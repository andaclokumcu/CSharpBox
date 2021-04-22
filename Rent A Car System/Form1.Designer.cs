
namespace Rent_A_Car_System
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
            this.lbxCars = new System.Windows.Forms.ListBox();
            this.lbxColors = new System.Windows.Forms.ListBox();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddToCart2 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxCars
            // 
            this.lbxCars.FormattingEnabled = true;
            this.lbxCars.ItemHeight = 15;
            this.lbxCars.Location = new System.Drawing.Point(12, 27);
            this.lbxCars.Name = "lbxCars";
            this.lbxCars.Size = new System.Drawing.Size(134, 184);
            this.lbxCars.TabIndex = 0;
            // 
            // lbxColors
            // 
            this.lbxColors.FormattingEnabled = true;
            this.lbxColors.ItemHeight = 15;
            this.lbxColors.Location = new System.Drawing.Point(189, 27);
            this.lbxColors.Name = "lbxColors";
            this.lbxColors.Size = new System.Drawing.Size(151, 184);
            this.lbxColors.TabIndex = 1;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 15;
            this.lbxCart.Location = new System.Drawing.Point(380, 27);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(149, 184);
            this.lbxCart.TabIndex = 2;
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(12, 9);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(51, 15);
            this.lblCars.TabIndex = 3;
            this.lblCars.Text = "Arabalar";
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(189, 9);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(46, 15);
            this.lblColors.TabIndex = 4;
            this.lblColors.Text = "Renkler";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(380, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(54, 15);
            this.lblCart.TabIndex = 5;
            this.lblCart.Text = "Sepetiniz";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(12, 234);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(134, 23);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Sepete Ekle";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddToCart2
            // 
            this.btnAddToCart2.Location = new System.Drawing.Point(189, 234);
            this.btnAddToCart2.Name = "btnAddToCart2";
            this.btnAddToCart2.Size = new System.Drawing.Size(151, 23);
            this.btnAddToCart2.TabIndex = 7;
            this.btnAddToCart2.Text = "Sepete Ekle";
            this.btnAddToCart2.UseVisualStyleBackColor = true;
            this.btnAddToCart2.Click += new System.EventHandler(this.btnAddToCart2_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(568, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Fiyat:";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(380, 234);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveFromCart.TabIndex = 11;
            this.btnRemoveFromCart.Text = "Sepetten Çıkar";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(568, 67);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(174, 23);
            this.tbxPrice.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 301);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddToCart2);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.lbxColors);
            this.Controls.Add(this.lbxCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCars;
        private System.Windows.Forms.ListBox lbxColors;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddToCart2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.TextBox tbxPrice;
    }
}

