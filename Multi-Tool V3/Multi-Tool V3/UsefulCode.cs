using System;
using System.Globalization;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    internal class UsefulCode
    {
        public void ErrorOccured(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string GetCurrentTime()
        {
            var time = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
            return time;
        }

        public string MakeRandomPassword(int passwordType, int passwordLength)
        {
            //Password Types
            //0 - No Type Selected
            //1 - Numbers
            //2 - Letters (Uppercase and Lowercase)
            //3 - Numbers and Letters (Uppercase and Lowercase)
            //4 - All Characters (Numbers, Letters, and Special Characters)

            //Variables
            Random gen = new Random();
            string passwordToString = ("");
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lettersAndNumbers = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] allCharacters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '<', '>', '?' };
            char[] passwordArray = { };
            int randomNumber = 0;

            if (passwordType == 0)
            {
                ErrorOccured("No password type selected!");
            }
            else
            {
                if (passwordType == 1)
                {
                    for (var i = 0; i < passwordLength; i++)
                    {
                        randomNumber = gen.Next(10);
                        passwordArray[i] = numbers[randomNumber];
                    }
                    passwordToString = passwordArray.ToString();
                }
                else
                {
                    if (passwordType == 2)
                    {
                        for (var i = 0; i < passwordLength; i++)
                        {
                            randomNumber = gen.Next(52);
                            passwordArray[i] = letters[randomNumber];
                        }
                        passwordToString = passwordArray.ToString();
                    }
                    else
                    {
                        if (passwordType == 3)
                        {
                            for (var i = 0; i < passwordLength; i++)
                            {
                                randomNumber = gen.Next(62);
                                passwordArray[i] = lettersAndNumbers[randomNumber];
                            }
                            passwordToString = passwordArray.ToString();
                        }
                        else
                        {
                            if (passwordType == 4)
                            {
                                for (var i = 0; i < passwordLength; i++)
                                {
                                    randomNumber = gen.Next(73);
                                    passwordArray[i] = allCharacters[randomNumber];
                                }
                                passwordToString = passwordArray.ToString();
                            }
                        }
                    }
                }
            }
            Multi_Tool_V3.Properties.Settings.Default.numberOfListsRandomized =
            Multi_Tool_V3.Properties.Settings.Default.numberOfListsRandomized + 1;
            Multi_Tool_V3.Properties.Settings.Default.Save();
            return passwordToString;
        }
    }
}