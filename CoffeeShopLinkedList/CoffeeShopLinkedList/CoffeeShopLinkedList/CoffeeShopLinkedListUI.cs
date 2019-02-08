using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CoffeeShopLinkedList
{
    public partial class CoffeeShopLinkedListUI : Form
    {
        public CoffeeShopLinkedListUI()
        {
            InitializeComponent();
        }


        

        List<string> nameList       = new List<string>();
        List<string> phoneList      = new List<string>();
        List<string> addressList    = new List<string>();
        List<string> emailList      = new List<string>();
        List<string> coffeeTypeList = new List<string>();
        List<double> quantityList   = new List<double>();

        int i=1;
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" || phoneTextBox.Text == "" ||
                    emailTextBox.Text == "" || addressTextBox.Text == "" ||
                    coffeeTypeComboBox.Text == "" || quantityTextBox.Text == "")
                {
                    Check();
                }
                else
                {
                    nameList.Add(nameTextBox.Text);
                    phoneList.Add(phoneTextBox.Text);
                    emailList.Add(emailTextBox.Text);
                    addressList.Add(addressTextBox.Text);
                    coffeeTypeList.Add(coffeeTypeComboBox.Text);
                    quantityList.Add(Convert.ToDouble(quantityTextBox.Text));

                    if (!nameList.Contains(nameTextBox.Text))
                    {
                        //email already exits
                        nameLabel.Text = "Name already exists.";
                        nameLabel.ForeColor = Color.Red;
                        return;

                    }
                   
                    if (phoneList.Last().Length != 11)
                    {
                        phoneLabel.Text = "Phone number must be \n11 character long.";
                        phoneLabel.ForeColor = Color.Red;
                        return;
                    }

                    if (!this.emailList.Last().Contains('@') || !this.emailList.Last().Contains('.'))
                    {
                        emailLabel.Text = "Please Enter A Valid Email.";
                        emailLabel.ForeColor = Color.Red;
                        return;
                    }

                    Order();

                    Display();

                    Clear();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Order()
        {
            if (coffeeTypeList.Last().Equals("Black"))
            {
                priceTextBox.Text = Convert.ToString(Convert.ToDouble(quantityTextBox.Text) * 120);
            }
            if (coffeeTypeList.Last().Equals("Cold"))
            {
                priceTextBox.Text = Convert.ToString(Convert.ToDouble(quantityTextBox.Text) * 100);
            }
            if (coffeeTypeList.Last().Equals("Hot"))
            {
                priceTextBox.Text = Convert.ToString(Convert.ToDouble(quantityTextBox.Text) * 90);
            }
            if (coffeeTypeList.Last().Equals("Regular"))
            {
                priceTextBox.Text = Convert.ToString(Convert.ToDouble(quantityTextBox.Text) * 80);
            }
        }

        private void Check()
        {
            if (nameTextBox.Text == "")
            {
                nameLabel.Text = "Please Fill the Name.";
                nameLabel.ForeColor = Color.Red;
            }
            if (phoneTextBox.Text == "")
            {
                phoneLabel.Text = "Please Fill the Phone.";
                phoneLabel.ForeColor = Color.Red;
            }
            if (emailTextBox.Text == "")
            {
                emailLabel.Text = "Please Fill the Email.";
                emailLabel.ForeColor = Color.Red;
            }
            if (addressTextBox.Text == "")
            {
                addressLabel.Text = "Please Fill the Address.";
                addressLabel.ForeColor = Color.Red;
            }
            if (coffeeTypeComboBox.Text == "")
            {
                coffeeTypeLabel.Text = "Please Fill the Coffee Type.";
                coffeeTypeLabel.ForeColor = Color.Red;
            }
            if (quantityTextBox.Text == "")
            {
                quantityLabel.Text = "Please Fill the Name.";
                quantityLabel.ForeColor = Color.Red;
            }
        }

        private void Display()
        {
            displayDataGridView.Rows.Add(Convert.ToString(i), nameList.Last(),
                         phoneList.Last(), emailList.Last(), addressList.Last(), coffeeTypeList.Last(),
                         quantityList.Last(), priceTextBox.Text);
        }

        private void Clear()
        {
            nameTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    }
}
