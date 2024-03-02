using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class PasswordGenerator
    {
        #region Constants
            // First and last positions of exclude options in config vector
            const int exclusionsStartPos = 4;
            const int exclusionsEndPos = 5;
        #endregion

        #region Private
        /// <summary>
        /// Length of password
        /// </summary>
        int passwordLength;

            /// <summary>
            /// Custom settings of the password generator
            /// 0 - include symbols <br/>
            /// 1 - include numbers <br/>
            /// 2 - include lowercase letters <br/>
            /// 3 - include uppercase letters <br/>
            /// 4 - include similar characters <br/>
            /// 5 - include ambiguous characters <br/>
            /// 6 - generate on device (no internet) <br/>
            /// 7 - auto-select password <br/>
            /// 8 - save config
            /// </summary>
            bool[] configFlags;

            Random rnd = new Random();

            string[] charSets = new string[]
            {
                "!@#$%^&*-_=+{}[]()/\\'\"`~,;:.<>?",    /*Symbols*/
                "0123456789",                           /*Numbers*/
                "abcdefghijklmnopqrstuvwxyz",           /*Lowercase Letters*/
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ"            /*Uppercase Letters*/
            };

            string[] toExcludeCharSets = new string[]
            {
                    "il1Lo0O\'\"`",                         /*Similar Characters*/
                    "{}[]()/\\\'\"`~,;:.<>?"                /*Ambiguous Characters*/
            };
        #endregion

        /// <summary>
        /// Create a password generator based on provided config
        /// </summary>
        /// <param name="pwdLength">Length of passwords</param>
        /// <param name="config">Configuration of passwords</param>
        public PasswordGenerator(int pwdLength, bool[] config)
        {
            passwordLength = pwdLength;
            configFlags = config;
        }

        public string GeneratePassword()
        {
            string password = "";

            while (password.Length < passwordLength)
            {
                // Pick a random character set
                int randomCharSet = rnd.Next(0, charSets.Length);
                if (configFlags[randomCharSet])
                {
                    // Pick a random character from chosen set
                    int randomPosInCharSet = rnd.Next(0, charSets[randomCharSet].Length);

                    if (!ShouldBeExcluded(randomCharSet, randomPosInCharSet))
                        password += charSets[randomCharSet][randomPosInCharSet];
                }
            }

            return password;
        }

        /// <summary>
        /// Check if chosen random character should be excluded
        /// </summary>
        /// <param name="randomCharSet"></param>
        /// <param name="randomPosInCharSet"></param>
        /// <returns></returns>
        private bool ShouldBeExcluded(int randomCharSet, int randomPosInCharSet)
        {
            for (int i = exclusionsStartPos; i <= exclusionsEndPos; i++)
                if (!configFlags[i])
                    for (int j = 0; j < toExcludeCharSets[i].Length; j++)
                        if (toExcludeCharSets[i][j] == charSets[randomCharSet][randomPosInCharSet])
                            return true;

            return false;
        }
    }
}
