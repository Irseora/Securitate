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
        const int defaultPwdLength = 16;
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
            pwdLengthComboBox.SelectedItem = defaultPwdLength;
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
            bool[] config = new bool[9];
            int currentPos = 0;
            foreach (var control in this.Controls)
                if (control is CheckBox)
                    config[currentPos++] = ((CheckBox)control).Checked;

            //
            PasswordGenerator passwordGenerator = new PasswordGenerator(config);
        }
    }
}
