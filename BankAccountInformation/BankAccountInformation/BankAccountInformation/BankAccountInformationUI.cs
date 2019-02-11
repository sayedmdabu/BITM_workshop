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

namespace BankAccountInformation
{
    public partial class BankAccountInformationUI : Form
    {
        public BankAccountInformationUI()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Only Use Digit
        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void inputAccountNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void accountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Only Use Digit

        // Only Use Letter
        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Only Use Letter

        List<string> userNameList = new List<string>();
        List<string> firstNameList = new List<string>();
        List<string> lastNameList = new List<string>();
        List<string> contactNoList = new List<string>();
        List<string> emailList = new List<string>();
        List<string> addressList = new List<string>();
        List<string> inputAccountNoList = new List<string>();


        List<string> accountNumberList = new List<string>();
        List<double> balanceList = new List<double>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if( string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text) || 
                    string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(contactNoTextBox.Text) ||
                    string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(addressRichTextBox.Text) || 
                    string.IsNullOrEmpty(inputAccountNoTextBox.Text))
                {
                    CheckEmptyTextBox();
                }
                else
                {
                    if(userNameList.Contains(userNameTextBox.Text))
                    {
                        userNameTextBox.Focus();
                        userLabel.Text = "Enter Unique User Name!";
                        userLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { userLabel.Text = ""; }

                    if(contactNoList.Contains(contactNoTextBox.Text))
                    {
                        contactNoTextBox.Focus();
                        contactNoLabel.Text = "Enter Unique Contact Number!";
                        contactNoLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { contactNoLabel.Text = ""; }
                    
                    if (contactNoTextBox.TextLength != 11)
                    {
                        contactNoTextBox.Focus();
                        contactNoLabel.Text = "Plase Confirm 11 Disit Phone Number";
                        contactNoLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { contactNoLabel.Text = ""; }
                    
                    //Regex regex  = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
                    Regex regex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    if (!regex1.IsMatch(emailTextBox.Text))
                    {
                        emailTextBox.Focus();
                        emailLabel.Text = "Enter Valid Email!";
                        emailLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { emailLabel.Text = ""; }

                    if (emailList.Contains(emailTextBox.Text))
                    {
                        inputAccountNoTextBox.Focus();
                        emailLabel.Text = "Enter Unique Account Number!";
                        emailLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { emailLabel.Text = ""; }

                    if (inputAccountNoTextBox.TextLength != 6)
                    {
                        inputAccountNoTextBox.Focus();
                        inputAccountNoLabel.Text = "Plase Confirm 6 Disit Phone Number";
                        inputAccountNoLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { inputAccountNoLabel.Text = ""; }

                    if (inputAccountNoList.Contains(inputAccountNoTextBox.Text))
                    {
                        inputAccountNoTextBox.Focus();
                        inputAccountNoLabel.Text = "Enter Unique Account Number!";
                        inputAccountNoLabel.ForeColor = Color.Red;
                        return;
                    }
                    else { inputAccountNoLabel.Text = ""; }
                    
                    userNameList.Add(userNameTextBox.Text);
                    firstNameList.Add(firstNameTextBox.Text);
                    lastNameList.Add(lastNameTextBox.Text);
                    contactNoList.Add(contactNoTextBox.Text);
                    emailList.Add(emailTextBox.Text);
                    addressList.Add(addressRichTextBox.Text);
                    inputAccountNoList.Add(inputAccountNoTextBox.Text);

                    balanceList.Add(0);

                    MessageBox.Show("Successfully Saved all Information");
                    
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //CheckEmptyTextBox()
        private void CheckEmptyTextBox()
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                userNameTextBox.Focus();
                userLabel.Text = "Please Enter User Name!";
                userLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                userNameTextBox.Focus();
                userLabel.Text = "";
            }
            
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                firstNameTextBox.Focus();
                firstNameLabel.Text = "Please Enter First Name!";
                firstNameLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                firstNameTextBox.Focus();
                firstNameLabel.Text = "";
            }

            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                lastNameTextBox.Focus();
                lastNameLabel.Text = "Please Enter Last Name!";
                lastNameLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                lastNameTextBox.Focus();
                lastNameLabel.Text = "";
            }

            if (string.IsNullOrEmpty(contactNoTextBox.Text))
            {
                contactNoTextBox.Focus();
                contactNoLabel.Text = "Please Enter Contact Number!";
                contactNoLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                contactNoTextBox.Focus();
                contactNoLabel.Text = "";
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailTextBox.Focus();
                emailLabel.Text = "Please Enter Email ID!";
                emailLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                emailTextBox.Focus();
                emailLabel.Text = "";
            }

            if (string.IsNullOrEmpty(addressRichTextBox.Text))
            {
                addressRichTextBox.Focus();
                addressLlabel.Text = "Please Enter You Address!";
                addressLlabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                addressRichTextBox.Focus();
                addressLlabel.Text = "";
            }

            if (string.IsNullOrEmpty(inputAccountNoTextBox.Text))
            {
                ValidAccountNumber();
            }
            else
            {
                inputAccountNoTextBox.Focus();
                inputAccountNoLabel.Text = "";
            }
        } //CheckEmptyTextBox()

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                Desplay();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Desplay()
        private void Desplay()
        {
            displayRichTextBox.Clear();
            //displayRichTextBox.Text = "SL | User Name | First Name | Last Name | Contact Number | Email | Address | Account Number |  Balance \n";
            int index = 0;
            foreach (string userName in userNameList)
            {
                displayRichTextBox.Text += userName + "\t" + firstNameList[index] + " " + lastNameList[index]
                    + "\t" + contactNoList[index] + "\t" + emailList[index] + "\t" + addressList[index]
                        + "\t" + inputAccountNoList[index] + "\t" + balanceList[index] + "\n";
                index++;

            }
        }//Desplay()

        // balanceButton_Click
        private void balanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(accountNumberTextBox.Text))
                {
                    ValidAccountNumber();
                } else { accountNumberLabel.Text = ""; }

                if (accountNumberTextBox.TextLength != 6)
                {
                    ValidAccountNumber();
                } else { accountNumberLabel.Text = ""; }


                if(inputAccountNoList.Contains(accountNumberTextBox.Text))
                {
                    amountTextBox.Text = Convert.ToString(balanceList.Last());
                } else
                {
                    ValidAccountNumber();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// balanceButton_Click

        // depositButton_Click
        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(accountNumberTextBox.Text))
                {
                    ValidAccountNumber();
                }
                else { accountNumberLabel.Text = ""; }

                if (accountNumberTextBox.TextLength != 6)
                {
                    ValidAccountNumber();
                }
                else { accountNumberLabel.Text = ""; }
                
                if (inputAccountNoList.Contains(accountNumberTextBox.Text))
                {
                    // Deposit Calculation
                    double amountInput = 0;
                    if(!string.IsNullOrEmpty(amountTextBox.Text))
                    {
                        int i = inputAccountNoList.IndexOf(accountNumberTextBox.Text);
                        amountInput = Convert.ToDouble(amountTextBox.Text);
                        balanceList[i] = balanceList[i] + amountInput;
                        //balanceList.Add(amountInput);
                        amountTextBox.Text = "";
                        Desplay();
                    }
                    else { MessageBox.Show("There is no value to deposit!"); }
                } // End Deposit Calculation
                else
                {
                    ValidAccountNumber();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// depositButton_Click


        //withdrawButton_Click
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(accountNumberTextBox.Text))
                {
                    ValidAccountNumber();
                }
                else { accountNumberLabel.Text = ""; }

                if (accountNumberTextBox.TextLength != 6)
                {
                    ValidAccountNumber();
                }
                else { accountNumberLabel.Text = ""; }

                if (inputAccountNoList.Contains(accountNumberTextBox.Text))
                {
                    // Withdraw Calculation
                    double amountInput = 0;
                    if (!string.IsNullOrEmpty(amountTextBox.Text))
                    {
                        int i = inputAccountNoList.IndexOf(accountNumberTextBox.Text);
                        if (balanceList[i] > 0)
                        {
                            amountInput = Convert.ToDouble(amountTextBox.Text);
                            if (balanceList[i].CompareTo(amountInput) >= 0)
                            {
                                balanceList[i] = balanceList[i] - amountInput;
                                amountTextBox.Text = "";
                                Desplay();
                            }
                            else { MessageBox.Show("You do not have enough balance!"); }
                        }
                        else { MessageBox.Show("You do not have enough balance!"); }
                    }
                    else { MessageBox.Show("There is no amount to withdrawing!"); }

                } // end Withdraw Calculation
                else
                {
                    ValidAccountNumber();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//withdrawButton_Click

        private void ValidAccountNumber()
        {
            accountNumberTextBox.Focus();
            accountNumberLabel.Text = "Please Enter a Valid Account Number!";
            accountNumberLabel.ForeColor = Color.Red;
            amountTextBox.Text = "";
            return;
        }

    }
}
