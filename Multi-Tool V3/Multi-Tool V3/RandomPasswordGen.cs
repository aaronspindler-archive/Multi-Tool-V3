using System;
using System.IO;
using System.Windows.Forms;
using Multi_Tool_V3.Properties;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class RandomPasswordGen : Form
    {
        //Objects
        private readonly char[] allCharacters =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8',
            '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '_', '-', '+', '=', '<', '>', '?'
        };

        private readonly Random gen = new Random();

        private readonly char[] lettersAndNums =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8',
            '9', '0'
        };

        private readonly char[] lowerAndNums =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };

        private readonly char[] numberPasswordArray = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        private readonly UsefulCode uc = new UsefulCode();

        //Variables

        private long lengthPasswords = 16;
        private long numPasswords = 1;
        private int passwordType = 4;
        private int randomNumber;

        public RandomPasswordGen()
        {
            InitializeComponent();
        }

        //Password Character Blocks

        private void createPasswordsButton_Click(object sender, EventArgs e)
        {
            passwordType = Settings.Default.randomPasswordSetting;

            if (passwordType != 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var writer = new StreamWriter(saveFileDialog.FileName);
                    if ((numPasswords >= 1) && (lengthPasswords >= 1))
                    {
                        // Numbers
                        if (passwordType == 1)
                        {
                            for (int i = 0; i < numPasswords; i++)
                            {
                                for (int j = 0; j < lengthPasswords; j++)
                                {
                                    randomNumber = gen.Next(10);
                                    writer.Write(numberPasswordArray[randomNumber]);
                                }
                                Settings.Default.numberOfPasswordsCreated =
                                    Settings.Default.numberOfPasswordsCreated + 1;
                                Settings.Default.Save();
                                writer.WriteLine();
                            }
                            outputWindow.Text = ("Your passwords have been successfully written to: " +
                                                 saveFileDialog.FileName);
                        }
                        else
                        {
                            // Numbers and Lower Case
                            if (passwordType == 2)
                            {
                                for (int i = 0; i < numPasswords; i++)
                                {
                                    for (int j = 0; j < lengthPasswords; j++)
                                    {
                                        randomNumber = gen.Next(36);
                                        writer.Write(lowerAndNums[randomNumber]);
                                    }
                                    Settings.Default.numberOfPasswordsCreated =
                                        Settings.Default.numberOfPasswordsCreated + 1;
                                    Settings.Default.Save();
                                    writer.WriteLine();
                                }
                                outputWindow.Text = ("Your passwords have been successfully written to: " +
                                                     saveFileDialog.FileName);
                            }
                            else
                            {
                                // Numbers and Letters
                                if (passwordType == 3)
                                {
                                    for (int i = 0; i < numPasswords; i++)
                                    {
                                        for (int j = 0; j < lengthPasswords; j++)
                                        {
                                            randomNumber = gen.Next(62);
                                            writer.Write(lettersAndNums[randomNumber]);
                                        }
                                        Settings.Default.numberOfPasswordsCreated =
                                            Settings.Default.numberOfPasswordsCreated + 1;
                                        Settings.Default.Save();
                                        writer.WriteLine();
                                    }
                                    outputWindow.Text = ("Your passwords have been successfully written to: " +
                                                         saveFileDialog.FileName);
                                }
                                else
                                {
                                    // All Characters
                                    if (passwordType == 4)
                                    {
                                        for (int i = 0; i < numPasswords; i++)
                                        {
                                            for (int j = 0; j < lengthPasswords; j++)
                                            {
                                                randomNumber = gen.Next(77);
                                                writer.Write(allCharacters[randomNumber]);
                                            }
                                            Settings.Default.numberOfPasswordsCreated =
                                                Settings.Default.numberOfPasswordsCreated + 1;
                                            Settings.Default.Save();
                                            writer.WriteLine();
                                        }
                                        outputWindow.Text = ("Your passwords have been successfully written to: " +
                                                             saveFileDialog.FileName);
                                    }
                                    else
                                    {
                                        // No Option Selected
                                        if (passwordType == 0)
                                        {
                                            outputWindow.Text = ("Please select a password type in the menus above.");
                                            uc.ErrorOccured(
                                                "Please select a password option in the Options -> Password Type Menu");
                                        }
                                    }
                                }
                            }
                        }
                        writer.Close();
                    }
                    else
                    {
                        uc.ErrorOccured("You have input an incorrect value.");
                    }
                }
                else
                {
                    uc.ErrorOccured("You did not click Ok / Did not select a file.");
                }
            }
            else
            {
                uc.ErrorOccured("You have not selected a password type.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lengthPasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            lengthPasswordTextBox.Text = ("");
        }

        private void lengthPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lengthPasswordTextBox.Text != (""))
            {
                lengthPasswords = Convert.ToInt64(lengthPasswordTextBox.Text);
            }
        }

        private void numPasswordsTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            numPasswordsTextBox.Text = ("");
        }

        private void numPasswordsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numPasswordsTextBox.Text != (""))
            {
                numPasswords = Convert.ToInt64(numPasswordsTextBox.Text);
            }
        }

        private void passwordTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpgo = new RandomPasswordGenSettings();
            rpgo.Show();
        }

        private void RandomPasswordGenerator_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }
    }
}