using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PasswordGeneratorForm : Form
    {
        #region Constants
            const int defaultPwdLengthPosition = 6; // = 16
            const int nrOfOptions = 9;

            // First and last positions of exclude options in config vector
            const int exclusionsStartPos = 4;
            const int exclusionsEndPos = 5;
        #endregion

        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load default settings <br/>
        /// - Length: 16 <br/>
        /// - Numbers <br/>
        /// - Lowercase Letters <br/>
        /// - Uppercase Letters
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            pwdLengthComboBox.SelectedIndex = defaultPwdLengthPosition;
            numbersCheckBox.Checked = true;
            lowercaseCheckBox.Checked = true;
            uppercaseCheckBox.Checked = true;
        }

        /// <summary>
        /// Generate new secure password with chosen settings
        /// </summary>
        private void generatePwdButton_Click(object sender, EventArgs e)
        {
            // Generate configuration to pass to generator
            bool[] config = new bool[nrOfOptions];
            int currentPos = 8;
            foreach (var control in this.Controls)  // Iterates backwards through all controls
                if (control is CheckBox)
                {
                    config[currentPos] = ((CheckBox)control).Checked;

                    // If it is an exclude option
                    if (currentPos >= exclusionsStartPos && currentPos <= exclusionsEndPos)
                        config[currentPos] = !config[currentPos];

                    currentPos--;
                }
            int pwdLength = int.Parse(pwdLengthComboBox.SelectedItem.ToString());

            // Create password generator based on given config
            PasswordGenerator passwordGenerator = new PasswordGenerator(pwdLength, config);

            // Generate & print password
            pwdReadyTextBox.Text = passwordGenerator.GeneratePassword();
        }
    }
}
