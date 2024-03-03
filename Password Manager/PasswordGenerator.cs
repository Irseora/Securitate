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
            // Position of first & last exclude flag in config array
            const int posOfFirstExcludeFlag = 4;
            const int posOfLastExcludeFlag = 5;

            // Number to subtract from iterator, when checking excludes
            const int toSubFromIt = 4;
        #endregion

        #region Private Properties
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
                "0123456789",                           /*Number*/
                "abcdefghijklmnopqrstuvwxyz",           /*Lowercase Letters*/
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ"            /*Uppercase Letters*/
            };

            string[] excludeCharSets = new string[]
            {
                "il1Lo0O",                              /*Similar Characters*/
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

        /// <summary>
        /// Generates a password according to given config
        /// </summary>
        /// <returns>Generated password as a string</returns>
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
                    char randomCharacter = charSets[randomCharSet][randomPosInCharSet];

                    // Can the chosen character be added, or does it need to be excluded?
                    bool canAdd = true;

                    // Check excluded character sets
                    for (int i = posOfFirstExcludeFlag; i <= posOfLastExcludeFlag; i++)
                        if (!configFlags[i])
                            if (excludeCharSets[i - toSubFromIt].Contains(randomCharacter))
                                canAdd = false;

                    if (canAdd) password += randomCharacter;
                }
            }

            return password;
        }
    }
}
