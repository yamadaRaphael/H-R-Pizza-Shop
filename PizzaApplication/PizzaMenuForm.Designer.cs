namespace PizzaApplication
{
    partial class PizzaMenuForm
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
            this.labelPizzaSize = new System.Windows.Forms.Label();
            this.labelPizzaQuantity = new System.Windows.Forms.Label();
            this.labelPriceSize = new System.Windows.Forms.Label();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.buttonProceedToCheckout = new System.Windows.Forms.Button();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.labelPizzaPrice = new System.Windows.Forms.Label();
            this.comboBoxPizzaSize = new System.Windows.Forms.ComboBox();
            this.dataGridViewPizzaMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPizzaSize
            // 
            this.labelPizzaSize.AutoSize = true;
            this.labelPizzaSize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaSize.Location = new System.Drawing.Point(183, 438);
            this.labelPizzaSize.Name = "labelPizzaSize";
            this.labelPizzaSize.Size = new System.Drawing.Size(95, 23);
            this.labelPizzaSize.TabIndex = 26;
            this.labelPizzaSize.Text = "Pizza Size";
            // 
            // labelPizzaQuantity
            // 
            this.labelPizzaQuantity.AutoSize = true;
            this.labelPizzaQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaQuantity.Location = new System.Drawing.Point(195, 561);
            this.labelPizzaQuantity.Name = "labelPizzaQuantity";
            this.labelPizzaQuantity.Size = new System.Drawing.Size(82, 23);
            this.labelPizzaQuantity.TabIndex = 25;
            this.labelPizzaQuantity.Text = "Quantity";
            // 
            // labelPriceSize
            // 
            this.labelPriceSize.AutoSize = true;
            this.labelPriceSize.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceSize.Location = new System.Drawing.Point(530, 499);
            this.labelPriceSize.Name = "labelPriceSize";
            this.labelPriceSize.Size = new System.Drawing.Size(23, 25);
            this.labelPriceSize.TabIndex = 24;
            this.labelPriceSize.Text = "$";
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Location = new System.Drawing.Point(172, 589);
            this.comboBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(115, 30);
            this.comboBoxQuantity.TabIndex = 23;
            // 
            // buttonProceedToCheckout
            // 
            this.buttonProceedToCheckout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProceedToCheckout.Location = new System.Drawing.Point(893, 591);
            this.buttonProceedToCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProceedToCheckout.Name = "buttonProceedToCheckout";
            this.buttonProceedToCheckout.Size = new System.Drawing.Size(212, 35);
            this.buttonProceedToCheckout.TabIndex = 22;
            this.buttonProceedToCheckout.Text = "Proceed To Checkout ";
            this.buttonProceedToCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(912, 489);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(147, 35);
            this.buttonAddToOrder.TabIndex = 21;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            // 
            // labelPizzaPrice
            // 
            this.labelPizzaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPizzaPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaPrice.Location = new System.Drawing.Point(561, 499);
            this.labelPizzaPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPizzaPrice.Name = "labelPizzaPrice";
            this.labelPizzaPrice.Size = new System.Drawing.Size(149, 34);
            this.labelPizzaPrice.TabIndex = 20;
            // 
            // comboBoxPizzaSize
            // 
            this.comboBoxPizzaSize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPizzaSize.FormattingEnabled = true;
            this.comboBoxPizzaSize.Location = new System.Drawing.Point(141, 467);
            this.comboBoxPizzaSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPizzaSize.Name = "comboBoxPizzaSize";
            this.comboBoxPizzaSize.Size = new System.Drawing.Size(180, 30);
            this.comboBoxPizzaSize.TabIndex = 19;
            // 
            // dataGridViewPizzaMenu
            // 
            this.dataGridViewPizzaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPizzaMenu.Location = new System.Drawing.Point(47, 39);
            this.dataGridViewPizzaMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPizzaMenu.Name = "dataGridViewPizzaMenu";
            this.dataGridViewPizzaMenu.Size = new System.Drawing.Size(1164, 375);
            this.dataGridViewPizzaMenu.TabIndex = 18;
            // 
            // PizzaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.labelPizzaSize);
            this.Controls.Add(this.labelPizzaQuantity);
            this.Controls.Add(this.labelPriceSize);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.buttonProceedToCheckout);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.labelPizzaPrice);
            this.Controls.Add(this.comboBoxPizzaSize);
            this.Controls.Add(this.dataGridViewPizzaMenu);
            this.Name = "PizzaMenuForm";
            this.Text = "Pizza Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzaMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPizzaSize;
        private System.Windows.Forms.Label labelPizzaQuantity;
        private System.Windows.Forms.Label labelPriceSize;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Button buttonProceedToCheckout;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Label labelPizzaPrice;
        private System.Windows.Forms.ComboBox comboBoxPizzaSize;
        private System.Windows.Forms.DataGridView dataGridViewPizzaMenu;
    }
}

