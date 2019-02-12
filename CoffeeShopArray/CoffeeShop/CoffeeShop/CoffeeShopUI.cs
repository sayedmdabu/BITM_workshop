using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShopUI : Form
    {
        public CoffeeShopUI()
        {
            InitializeComponent();
        }

        int i                   = 1;
        string[] customerNames  = new string[100];
        string[] contactNumbers = new string[100];
        string[] addresses      = new string[100];
        string[] coffeeTypes    = new string[100];
        string[] quantitys      = new string[100]; 
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(customerNameTextBox.Text == "" || contactNumberTextBox.Text == "" || addressTextBox.Text == "" || 
                    coffeeTypeComboBox.SelectedItem == "" || quantityTextBox.Text == "")
                {
                    MessageBox.Show("Fill the gap!");
                }
                else
                {
                    customerNames[i]  = customerNameTextBox.Text;
                    contactNumbers[i] = contactNumberTextBox.Text;
                    addresses[i]      = addressTextBox.Text;
                    coffeeTypes[i]    = coffeeTypeComboBox.Text;
                    quantitys[i]      = quantityTextBox.Text;
                    

                    if (coffeeTypes[i] == "Black")
                    {
                        
                        totalAmountTextBox.Text = Convert.ToString(Convert.ToInt32(quantitys[i]) * 120);
                    }

                    if (coffeeTypes[i] == "Cold")
                    {
                        totalAmountTextBox.Text = Convert.ToString(Convert.ToInt32(quantitys[i]) * 100);
                    }

                    if (coffeeTypes[i] == "Hot")
                    {
                        totalAmountTextBox.Text = Convert.ToString(Convert.ToInt32(quantitys[i]) * 90);
                    }

                    if (coffeeTypes[i] == "Regular")
                    {
                        totalAmountTextBox.Text = Convert.ToString(Convert.ToInt32(quantitys[i]) * 80);
                    }

                    coffeeShopDataGridView.Rows.Add(Convert.ToString(i), customerNames[i], contactNumbers[i], addresses[i], 
                        coffeeTypeComboBox.Text, quantitys[i], totalAmountTextBox.Text);

                    i++;
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
