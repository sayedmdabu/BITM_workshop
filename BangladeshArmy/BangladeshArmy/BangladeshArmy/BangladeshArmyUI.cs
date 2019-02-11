using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangladeshArmy
{
    public partial class BangladeshArmyUI : Form
    {
        public BangladeshArmyUI()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soldierNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Target1ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void target2ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void target3ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void target4ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        List<string> soldierNoList = new List<string>();
        List<string> soldierNameList = new List<string>();
        List<double> oneScoreList = new List<double>();
        List<double> twoScoreList = new List<double>();
        List<double> threeScoreList = new List<double>();
        List<double> fourScoreList = new List<double>();
        List<double> totalList = new List<double>();
        List<double> averageList = new List<double>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if( string.IsNullOrEmpty(soldierNoTextBox.Text) || string.IsNullOrEmpty(soldierNameTextBox.Text) ||
                    string.IsNullOrEmpty(Target1ScoreTextBox.Text) || string.IsNullOrEmpty(target2ScoreTextBox.Text) || 
                    string.IsNullOrEmpty(target3ScoreTextBox.Text) || string.IsNullOrEmpty(target4ScoreTextBox.Text) )
                {
                    CheckEmptyTextBox();
                }
                else
                {
                    if(soldierNoList.Contains(soldierNoTextBox.Text))
                    {
                        soldierNoTextBox.Focus();
                        soldierNoLabel.Text = "Please Enter Unique Soldier No!";
                        soldierNoLabel.ForeColor = Color.Red;
                        return;
                    } else { soldierNoLabel.Text = ""; }

                    soldierNoList.Add(soldierNoTextBox.Text);
                    soldierNameList.Add(soldierNameTextBox.Text);
                    oneScoreList.Add(Convert.ToDouble(Target1ScoreTextBox.Text));
                    twoScoreList.Add(Convert.ToDouble(target2ScoreTextBox.Text));
                    threeScoreList.Add(Convert.ToDouble(target3ScoreTextBox.Text));
                    fourScoreList.Add(Convert.ToDouble(target4ScoreTextBox.Text));

                    double total = oneScoreList.Last() + twoScoreList.Last() + threeScoreList.Last() + fourScoreList.Last();
                    double average = total / 4;

                    totalList.Add(total);
                    averageList.Add(average);

                    MessageBox.Show("Successfully Saved all Information.");


                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckEmptyTextBox()
        {
            if (string.IsNullOrEmpty(soldierNoTextBox.Text))
            {
                soldierNoTextBox.Focus();
                soldierNoLabel.Text = "Please Enter Soldier No!";
                soldierNoLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                soldierNoTextBox.Focus();
                soldierNoLabel.Text = "";
            }

            if (string.IsNullOrEmpty(soldierNameTextBox.Text))
            {
                soldierNameTextBox.Focus();
                soldierNameLabel.Text = "Please Enter Soldier Name!";
                soldierNameLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                soldierNameTextBox.Focus();
                soldierNameLabel.Text = "";
            }

            if (string.IsNullOrEmpty(Target1ScoreTextBox.Text))
            {
                Target1ScoreTextBox.Focus();
                target1ScoreLabel.Text = "Please Enter Score!";
                target1ScoreLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                Target1ScoreTextBox.Focus();
                target1ScoreLabel.Text = "";
            }

            if (string.IsNullOrEmpty(target2ScoreTextBox.Text))
            {
                target2ScoreTextBox.Focus();
                target2ScoreLabel.Text = "Please Enter Score!";
                target2ScoreLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                target2ScoreTextBox.Focus();
                target2ScoreLabel.Text = "";
            }

            if (string.IsNullOrEmpty(target3ScoreTextBox.Text))
            {
                target3ScoreTextBox.Focus();
                target3ScoreLabel.Text = "Please Enter Score!";
                target3ScoreLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                target3ScoreTextBox.Focus();
                target3ScoreLabel.Text = "";
            }

            if (string.IsNullOrEmpty(target4ScoreTextBox.Text))
            {
                target4ScoreTextBox.Focus();
                target4ScoreLabel.Text = "Please Enter Score!";
                target4ScoreLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                target4ScoreTextBox.Focus();
                target4ScoreLabel.Text = "";
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                Display();
                

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display()
        {
            displayRichTextBox.Clear();

            int index = 0;
            foreach (string soldierNo in soldierNoList)
            {
                displayRichTextBox.Text += soldierNo + "\t" + soldierNameList[index] + "\t" + totalList[index] + "\t" + averageList[index] + "\n";
                index++;

            }

            int i = averageList.IndexOf(averageList.Max());
            topAverageScoreTextBox.Text = soldierNameList[i];
            int j = totalList.IndexOf(totalList.Max());
            topTotalScoreTextBox.Text = soldierNameList[j];
        }

       

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Clear();

                if (soldierNoRadioButton.Checked)
                {
                    if (soldierNoList.Contains(searchByTtextBox.Text))
                    {
                        int i = soldierNoList.IndexOf(searchByTtextBox.Text);
                        displayRichTextBox.Text += soldierNoList[i] + "\t" + soldierNameList[i] + "\t" + totalList[i] + "\t" + averageList[i] + "\n";
                    }
                    else
                    {
                        MessageBox.Show("There is an Invalid ID!");
                    }
                }
                else if (soldierNameRadioButton.Checked)
                {
                    if (soldierNameList.Contains(searchByTtextBox.Text))
                    {
                        int i = soldierNameList.IndexOf(searchByTtextBox.Text);

                        displayRichTextBox.Text += soldierNoList[i] + "\t" + soldierNameList[i] + "\t" + totalList[i] + "\t" + averageList[i] + "\n";

                    }
                    else
                    {
                        MessageBox.Show("There is an Invalid Name!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Search Option!");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}
