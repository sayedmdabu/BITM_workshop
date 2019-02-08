using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopAssignmentTwo
{
    public partial class CoffeeShopUI : Form
    {
        public CoffeeShopUI()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name, contactNo, address, coffeeType;
                double quantity, price = 0;

                name = nameTextBox.Text;
                contactNo = contactNoTextBox.Text;
                address = addressTextBox.Text;
                coffeeType = coffeeTypeComboBox.Text;
                quantity = Convert.ToDouble(quantityTextBox.Text);

                if (coffeeType == "Black")
                {
                    price = quantity * 120;
                }
                if (coffeeType == "Cold")
                {
                    price = quantity * 100;
                }
                if (coffeeType == "Hot")
                {
                    price = quantity * 90;
                }
                if (coffeeType == "Reguler")
                {
                    price = quantity * 80;
                }

                displayRichTextBox.Text = 
                    "Order Information \n===================="+"\n"+
                    "\nName       : "+name+
                    "\nContact No : "+contactNo+
                    "\nAddress    : "+address+
                    "\nCoffee Type: "+coffeeType+
                    "\nQuantity   : "+quantity+
                    "\nPrice      : "+price;
                
            
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
