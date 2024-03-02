using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class PasswordGenerator
    {
        #region Character Sets
        string symbols = "!@#$%^&*-_=+";
        string numbers = "0123456789";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string similars = "il1Lo0O\'\"`";
        string ambiguous = "{}[]()/\\\'\"`~,;:.<>?";
        #endregion

        #region Constants
        const int nrOfCharSets = 6;
        #endregion

        public PasswordGenerator(bool[] config)
        {

        }
    }
}
