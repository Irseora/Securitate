namespace Password_Manager
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.pwdLengthLabel = new System.Windows.Forms.Label();
            this.pwdLengthComboBox = new System.Windows.Forms.ComboBox();
            this.symbolsLabel = new System.Windows.Forms.Label();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.lowercaseLabel = new System.Windows.Forms.Label();
            this.lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseLabel = new System.Windows.Forms.Label();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.similarLabel = new System.Windows.Forms.Label();
            this.ambiguousLabel = new System.Windows.Forms.Label();
            this.ambiguousCheckBox = new System.Windows.Forms.CheckBox();
            this.noInternetCheckBox = new System.Windows.Forms.CheckBox();
            this.noInternetLabel = new System.Windows.Forms.Label();
            this.autoSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSelectLabel = new System.Windows.Forms.Label();
            this.saveSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.saveSettingsLabel = new System.Windows.Forms.Label();
            this.loadSettingsLabel = new System.Windows.Forms.Label();
            this.loadURLLabel = new System.Windows.Forms.Label();
            this.generatePwdButton = new System.Windows.Forms.Button();
            this.generateEmailButton = new System.Windows.Forms.Button();
            this.pwdReadyTextBox = new System.Windows.Forms.TextBox();
            this.pwdReadyLabel = new System.Windows.Forms.Label();
            this.rememberSentenceLabel = new System.Windows.Forms.Label();
            this.rememberSentenceTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(356, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Secure Password Generator";
            // 
            // pwdLengthLabel
            // 
            this.pwdLengthLabel.AutoSize = true;
            this.pwdLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pwdLengthLabel.Location = new System.Drawing.Point(19, 90);
            this.pwdLengthLabel.Name = "pwdLengthLabel";
            this.pwdLengthLabel.Size = new System.Drawing.Size(121, 17);
            this.pwdLengthLabel.TabIndex = 1;
            this.pwdLengthLabel.Text = "Password Length:";
            // 
            // pwdLengthComboBox
            // 
            this.pwdLengthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pwdLengthComboBox.FormattingEnabled = true;
            this.pwdLengthComboBox.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.pwdLengthComboBox.Location = new System.Drawing.Point(248, 88);
            this.pwdLengthComboBox.Name = "pwdLengthComboBox";
            this.pwdLengthComboBox.Size = new System.Drawing.Size(121, 24);
            this.pwdLengthComboBox.TabIndex = 2;
            // 
            // symbolsLabel
            // 
            this.symbolsLabel.AutoSize = true;
            this.symbolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.symbolsLabel.Location = new System.Drawing.Point(19, 119);
            this.symbolsLabel.Name = "symbolsLabel";
            this.symbolsLabel.Size = new System.Drawing.Size(114, 17);
            this.symbolsLabel.TabIndex = 3;
            this.symbolsLabel.Text = "Include Symbols:";
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.symbolsCheckBox.Location = new System.Drawing.Point(248, 118);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(107, 21);
            this.symbolsCheckBox.TabIndex = 4;
            this.symbolsCheckBox.Text = "(e.g. @#$%)";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numbersLabel.Location = new System.Drawing.Point(19, 146);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(118, 17);
            this.numbersLabel.TabIndex = 5;
            this.numbersLabel.Text = "Include Numbers:";
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numbersCheckBox.Location = new System.Drawing.Point(248, 145);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(113, 21);
            this.numbersCheckBox.TabIndex = 6;
            this.numbersCheckBox.Text = "(e.g. 123456)";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowercaseLabel
            // 
            this.lowercaseLabel.AutoSize = true;
            this.lowercaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lowercaseLabel.Location = new System.Drawing.Point(19, 173);
            this.lowercaseLabel.Name = "lowercaseLabel";
            this.lowercaseLabel.Size = new System.Drawing.Size(202, 17);
            this.lowercaseLabel.TabIndex = 7;
            this.lowercaseLabel.Text = "Include Lowercase Characters:";
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lowercaseCheckBox.Location = new System.Drawing.Point(248, 172);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(124, 21);
            this.lowercaseCheckBox.TabIndex = 8;
            this.lowercaseCheckBox.Text = "(e.g. abcdefgh)";
            this.lowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uppercaseCheckBox.Location = new System.Drawing.Point(248, 199);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(140, 21);
            this.uppercaseCheckBox.TabIndex = 9;
            this.uppercaseCheckBox.Text = "(e.g. ABCDEFGH)";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // uppercaseLabel
            // 
            this.uppercaseLabel.AutoSize = true;
            this.uppercaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uppercaseLabel.Location = new System.Drawing.Point(19, 200);
            this.uppercaseLabel.Name = "uppercaseLabel";
            this.uppercaseLabel.Size = new System.Drawing.Size(203, 17);
            this.uppercaseLabel.TabIndex = 10;
            this.uppercaseLabel.Text = "Include Uppercase Characters:";
            // 
            // similarCheckBox
            // 
            this.similarCheckBox.AutoSize = true;
            this.similarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.similarCheckBox.Location = new System.Drawing.Point(248, 226);
            this.similarCheckBox.Name = "similarCheckBox";
            this.similarCheckBox.Size = new System.Drawing.Size(162, 21);
            this.similarCheckBox.TabIndex = 11;
            this.similarCheckBox.Text = "(e.g. i, l, 1, L, o, 0, O)";
            this.similarCheckBox.UseVisualStyleBackColor = true;
            // 
            // similarLabel
            // 
            this.similarLabel.AutoSize = true;
            this.similarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.similarLabel.Location = new System.Drawing.Point(19, 227);
            this.similarLabel.Name = "similarLabel";
            this.similarLabel.Size = new System.Drawing.Size(180, 17);
            this.similarLabel.TabIndex = 12;
            this.similarLabel.Text = "Exclude Similar Characters:";
            // 
            // ambiguousLabel
            // 
            this.ambiguousLabel.AutoSize = true;
            this.ambiguousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ambiguousLabel.Location = new System.Drawing.Point(19, 254);
            this.ambiguousLabel.Name = "ambiguousLabel";
            this.ambiguousLabel.Size = new System.Drawing.Size(208, 17);
            this.ambiguousLabel.TabIndex = 13;
            this.ambiguousLabel.Text = "Exclude Ambiguous Characters:";
            // 
            // ambiguousCheckBox
            // 
            this.ambiguousCheckBox.AutoSize = true;
            this.ambiguousCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ambiguousCheckBox.Location = new System.Drawing.Point(248, 253);
            this.ambiguousCheckBox.Name = "ambiguousCheckBox";
            this.ambiguousCheckBox.Size = new System.Drawing.Size(222, 21);
            this.ambiguousCheckBox.TabIndex = 14;
            this.ambiguousCheckBox.Text = "(e.g. { } [ ] ( ) / \\ \' \" ` ~ , ; : . < >)";
            this.ambiguousCheckBox.UseVisualStyleBackColor = true;
            // 
            // noInternetCheckBox
            // 
            this.noInternetCheckBox.AutoSize = true;
            this.noInternetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noInternetCheckBox.Location = new System.Drawing.Point(248, 280);
            this.noInternetCheckBox.Name = "noInternetCheckBox";
            this.noInternetCheckBox.Size = new System.Drawing.Size(244, 21);
            this.noInternetCheckBox.TabIndex = 15;
            this.noInternetCheckBox.Text = "(do NOT send across the Internet)";
            this.noInternetCheckBox.UseVisualStyleBackColor = true;
            // 
            // noInternetLabel
            // 
            this.noInternetLabel.AutoSize = true;
            this.noInternetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noInternetLabel.Location = new System.Drawing.Point(19, 281);
            this.noInternetLabel.Name = "noInternetLabel";
            this.noInternetLabel.Size = new System.Drawing.Size(173, 17);
            this.noInternetLabel.TabIndex = 16;
            this.noInternetLabel.Text = "Generate on Your Device:";
            // 
            // autoSelectCheckBox
            // 
            this.autoSelectCheckBox.AutoSize = true;
            this.autoSelectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoSelectCheckBox.Location = new System.Drawing.Point(248, 307);
            this.autoSelectCheckBox.Name = "autoSelectCheckBox";
            this.autoSelectCheckBox.Size = new System.Drawing.Size(248, 21);
            this.autoSelectCheckBox.TabIndex = 17;
            this.autoSelectCheckBox.Text = "(select the password automatically)";
            this.autoSelectCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoSelectLabel
            // 
            this.autoSelectLabel.AutoSize = true;
            this.autoSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autoSelectLabel.Location = new System.Drawing.Point(19, 308);
            this.autoSelectLabel.Name = "autoSelectLabel";
            this.autoSelectLabel.Size = new System.Drawing.Size(85, 17);
            this.autoSelectLabel.TabIndex = 18;
            this.autoSelectLabel.Text = "Auto-Select:";
            // 
            // saveSettingsCheckBox
            // 
            this.saveSettingsCheckBox.AutoSize = true;
            this.saveSettingsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveSettingsCheckBox.Location = new System.Drawing.Point(248, 334);
            this.saveSettingsCheckBox.Name = "saveSettingsCheckBox";
            this.saveSettingsCheckBox.Size = new System.Drawing.Size(285, 21);
            this.saveSettingsCheckBox.TabIndex = 19;
            this.saveSettingsCheckBox.Text = "(save all the settings above for later use)";
            this.saveSettingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingsLabel
            // 
            this.saveSettingsLabel.AutoSize = true;
            this.saveSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveSettingsLabel.Location = new System.Drawing.Point(19, 335);
            this.saveSettingsLabel.Name = "saveSettingsLabel";
            this.saveSettingsLabel.Size = new System.Drawing.Size(147, 17);
            this.saveSettingsLabel.TabIndex = 20;
            this.saveSettingsLabel.Text = "Save My Preferences:";
            // 
            // loadSettingsLabel
            // 
            this.loadSettingsLabel.AutoSize = true;
            this.loadSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loadSettingsLabel.Location = new System.Drawing.Point(19, 364);
            this.loadSettingsLabel.Name = "loadSettingsLabel";
            this.loadSettingsLabel.Size = new System.Drawing.Size(187, 17);
            this.loadSettingsLabel.TabIndex = 22;
            this.loadSettingsLabel.Text = "Load My Settings Anywhere:";
            // 
            // loadURLLabel
            // 
            this.loadURLLabel.AutoSize = true;
            this.loadURLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loadURLLabel.Location = new System.Drawing.Point(245, 364);
            this.loadURLLabel.Name = "loadURLLabel";
            this.loadURLLabel.Size = new System.Drawing.Size(332, 17);
            this.loadURLLabel.TabIndex = 23;
            this.loadURLLabel.Text = "URL to load my settings on other computers quickly";
            // 
            // generatePwdButton
            // 
            this.generatePwdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generatePwdButton.Location = new System.Drawing.Point(248, 394);
            this.generatePwdButton.Name = "generatePwdButton";
            this.generatePwdButton.Size = new System.Drawing.Size(179, 28);
            this.generatePwdButton.TabIndex = 24;
            this.generatePwdButton.Text = "Generate Password";
            this.generatePwdButton.UseVisualStyleBackColor = true;
            this.generatePwdButton.Click += new System.EventHandler(this.generatePwdButton_Click);
            // 
            // generateEmailButton
            // 
            this.generateEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generateEmailButton.Location = new System.Drawing.Point(433, 394);
            this.generateEmailButton.Name = "generateEmailButton";
            this.generateEmailButton.Size = new System.Drawing.Size(193, 28);
            this.generateEmailButton.TabIndex = 25;
            this.generateEmailButton.Text = "Generate Disposable Email";
            this.generateEmailButton.UseVisualStyleBackColor = true;
            // 
            // pwdReadyTextBox
            // 
            this.pwdReadyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pwdReadyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pwdReadyTextBox.Location = new System.Drawing.Point(248, 439);
            this.pwdReadyTextBox.Name = "pwdReadyTextBox";
            this.pwdReadyTextBox.ReadOnly = true;
            this.pwdReadyTextBox.Size = new System.Drawing.Size(378, 23);
            this.pwdReadyTextBox.TabIndex = 26;
            this.pwdReadyTextBox.Text = "Your new password will appear here.";
            // 
            // pwdReadyLabel
            // 
            this.pwdReadyLabel.AutoSize = true;
            this.pwdReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pwdReadyLabel.Location = new System.Drawing.Point(19, 442);
            this.pwdReadyLabel.Name = "pwdReadyLabel";
            this.pwdReadyLabel.Size = new System.Drawing.Size(138, 17);
            this.pwdReadyLabel.TabIndex = 27;
            this.pwdReadyLabel.Text = "Your New Password:";
            // 
            // rememberSentenceLabel
            // 
            this.rememberSentenceLabel.AutoSize = true;
            this.rememberSentenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rememberSentenceLabel.Location = new System.Drawing.Point(245, 475);
            this.rememberSentenceLabel.Name = "rememberSentenceLabel";
            this.rememberSentenceLabel.Size = new System.Drawing.Size(508, 17);
            this.rememberSentenceLabel.TabIndex = 28;
            this.rememberSentenceLabel.Text = "Remember your password with the first character of each word in this sentence.";
            // 
            // rememberSentenceTextLabel
            // 
            this.rememberSentenceTextLabel.AutoSize = true;
            this.rememberSentenceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rememberSentenceTextLabel.Location = new System.Drawing.Point(19, 475);
            this.rememberSentenceTextLabel.Name = "rememberSentenceTextLabel";
            this.rememberSentenceTextLabel.Size = new System.Drawing.Size(180, 17);
            this.rememberSentenceTextLabel.TabIndex = 29;
            this.rememberSentenceTextLabel.Text = "Remember Your Password:";
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 517);
            this.Controls.Add(this.rememberSentenceTextLabel);
            this.Controls.Add(this.rememberSentenceLabel);
            this.Controls.Add(this.pwdReadyLabel);
            this.Controls.Add(this.pwdReadyTextBox);
            this.Controls.Add(this.generateEmailButton);
            this.Controls.Add(this.generatePwdButton);
            this.Controls.Add(this.loadURLLabel);
            this.Controls.Add(this.loadSettingsLabel);
            this.Controls.Add(this.saveSettingsLabel);
            this.Controls.Add(this.saveSettingsCheckBox);
            this.Controls.Add(this.autoSelectLabel);
            this.Controls.Add(this.autoSelectCheckBox);
            this.Controls.Add(this.noInternetLabel);
            this.Controls.Add(this.noInternetCheckBox);
            this.Controls.Add(this.ambiguousCheckBox);
            this.Controls.Add(this.ambiguousLabel);
            this.Controls.Add(this.similarLabel);
            this.Controls.Add(this.similarCheckBox);
            this.Controls.Add(this.uppercaseLabel);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.lowercaseCheckBox);
            this.Controls.Add(this.lowercaseLabel);
            this.Controls.Add(this.numbersCheckBox);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.symbolsCheckBox);
            this.Controls.Add(this.symbolsLabel);
            this.Controls.Add(this.pwdLengthComboBox);
            this.Controls.Add(this.pwdLengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Secure Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pwdLengthLabel;
        private System.Windows.Forms.ComboBox pwdLengthComboBox;
        private System.Windows.Forms.Label symbolsLabel;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.Label lowercaseLabel;
        private System.Windows.Forms.CheckBox lowercaseCheckBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.Label uppercaseLabel;
        private System.Windows.Forms.CheckBox similarCheckBox;
        private System.Windows.Forms.Label similarLabel;
        private System.Windows.Forms.Label ambiguousLabel;
        private System.Windows.Forms.CheckBox ambiguousCheckBox;
        private System.Windows.Forms.CheckBox noInternetCheckBox;
        private System.Windows.Forms.Label noInternetLabel;
        private System.Windows.Forms.CheckBox autoSelectCheckBox;
        private System.Windows.Forms.Label autoSelectLabel;
        private System.Windows.Forms.CheckBox saveSettingsCheckBox;
        private System.Windows.Forms.Label saveSettingsLabel;
        private System.Windows.Forms.Label loadSettingsLabel;
        private System.Windows.Forms.Label loadURLLabel;
        private System.Windows.Forms.Button generatePwdButton;
        private System.Windows.Forms.Button generateEmailButton;
        private System.Windows.Forms.TextBox pwdReadyTextBox;
        private System.Windows.Forms.Label pwdReadyLabel;
        private System.Windows.Forms.Label rememberSentenceLabel;
        private System.Windows.Forms.Label rememberSentenceTextLabel;
    }
}

