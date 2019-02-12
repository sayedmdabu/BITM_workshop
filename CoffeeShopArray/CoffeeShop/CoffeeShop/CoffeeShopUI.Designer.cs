namespace CoffeeShop
{
    partial class CoffeeShopUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coffeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.coffeeShopDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(165, 119);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(126, 26);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact Number:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextBox.Location = new System.Drawing.Point(165, 161);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(126, 26);
            this.contactNumberTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(165, 204);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(126, 26);
            this.addressTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "CoffeeType:";
            // 
            // coffeeTypeComboBox
            // 
            this.coffeeTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeTypeComboBox.FormattingEnabled = true;
            this.coffeeTypeComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.coffeeTypeComboBox.Location = new System.Drawing.Point(165, 249);
            this.coffeeTypeComboBox.Name = "coffeeTypeComboBox";
            this.coffeeTypeComboBox.Size = new System.Drawing.Size(126, 28);
            this.coffeeTypeComboBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(165, 293);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(126, 26);
            this.quantityTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(165, 376);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 43);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // coffeeShopDataGridView
            // 
            this.coffeeShopDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coffeeShopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffeeShopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.coustomerName,
            this.contactNumber,
            this.address,
            this.coffeeType,
            this.quantity,
            this.price});
            this.coffeeShopDataGridView.Location = new System.Drawing.Point(319, 119);
            this.coffeeShopDataGridView.Name = "coffeeShopDataGridView";
            this.coffeeShopDataGridView.Size = new System.Drawing.Size(440, 300);
            this.coffeeShopDataGridView.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(676, 453);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // coustomerName
            // 
            this.coustomerName.HeaderText = "Coustomer Name";
            this.coustomerName.Name = "coustomerName";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // coffeeType
            // 
            this.coffeeType.HeaderText = "Coffee Type";
            this.coffeeType.Name = "coffeeType";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Amount:";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(165, 335);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(126, 26);
            this.totalAmountTextBox.TabIndex = 2;
            // 
            // CoffeeShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 500);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.coffeeShopDataGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.coffeeTypeComboBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeShopUI";
            this.Text = "Coffee Shop";
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coffeeTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView coffeeShopDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalAmountTextBox;
    }
}

