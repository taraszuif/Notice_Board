namespace Notice_Board.View
{
    partial class PersonalCabinetForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new Notice_Board.View.FancyButton();
            this.ageTextBox = new Notice_Board.View.FancyTextBox();
            this.emailTextBox = new Notice_Board.View.FancyTextBox();
            this.phoneTextBox = new Notice_Board.View.FancyTextBox();
            this.countryComboBox = new Notice_Board.View.FancyComboBox();
            this.countryCodeComboBox = new Notice_Board.View.FancyComboBox();
            this.lastNameTextBox = new Notice_Board.View.FancyTextBox();
            this.firstNameTextBox = new Notice_Board.View.FancyTextBox();
            this.passwordTextBox = new Notice_Board.View.FancyTextBox();
            this.loginTextBox = new Notice_Board.View.FancyTextBox();
            this.phoneCodeLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.backButton = new Notice_Board.View.FancyButton();
            this.hintLabel = new System.Windows.Forms.Label();
            this.noticeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.BackColor = System.Drawing.Color.Gold;
            this.saveButton.BackgroundColor = System.Drawing.Color.Gold;
            this.saveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveButton.BorderRadius = 20;
            this.saveButton.BorderSize = 2;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(813, 638);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(500, 125);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Зберегти зміни";
            this.saveButton.TextColor = System.Drawing.Color.Black;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ageTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.ageTextBox.BorderSize = 2;
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.Black;
            this.ageTextBox.Location = new System.Drawing.Point(1393, 405);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageTextBox.Multiline = false;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ageTextBox.PasswordChar = false;
            this.ageTextBox.Size = new System.Drawing.Size(300, 40);
            this.ageTextBox.TabIndex = 51;
            this.ageTextBox.Texts = "";
            this.ageTextBox.UnderlinedStyle = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.emailTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.emailTextBox.BorderSize = 2;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(1393, 224);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextBox.PasswordChar = false;
            this.emailTextBox.Size = new System.Drawing.Size(300, 40);
            this.emailTextBox.TabIndex = 50;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.phoneTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.phoneTextBox.BorderSize = 2;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.Location = new System.Drawing.Point(1098, 401);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Multiline = false;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.phoneTextBox.PasswordChar = false;
            this.phoneTextBox.Size = new System.Drawing.Size(196, 40);
            this.phoneTextBox.TabIndex = 49;
            this.phoneTextBox.Texts = "";
            this.phoneTextBox.UnderlinedStyle = true;
            // 
            // countryComboBox
            // 
            this.countryComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countryComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.countryComboBox.BorderSize = 1;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.countryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.countryComboBox.ForeColor = System.Drawing.Color.Black;
            this.countryComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.countryComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.countryComboBox.ListTextColor = System.Drawing.Color.Black;
            this.countryComboBox.Location = new System.Drawing.Point(973, 224);
            this.countryComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.countryComboBox.Size = new System.Drawing.Size(300, 35);
            this.countryComboBox.TabIndex = 48;
            this.countryComboBox.Texts = "";
            // 
            // countryCodeComboBox
            // 
            this.countryCodeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countryCodeComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.countryCodeComboBox.BorderSize = 1;
            this.countryCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.countryCodeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.countryCodeComboBox.ForeColor = System.Drawing.Color.Black;
            this.countryCodeComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.countryCodeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.countryCodeComboBox.ListTextColor = System.Drawing.Color.Black;
            this.countryCodeComboBox.Location = new System.Drawing.Point(968, 401);
            this.countryCodeComboBox.MinimumSize = new System.Drawing.Size(50, 30);
            this.countryCodeComboBox.Name = "countryCodeComboBox";
            this.countryCodeComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.countryCodeComboBox.Size = new System.Drawing.Size(123, 35);
            this.countryCodeComboBox.TabIndex = 47;
            this.countryCodeComboBox.Texts = "";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lastNameTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.lastNameTextBox.BorderSize = 2;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(579, 401);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Multiline = false;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.lastNameTextBox.PasswordChar = false;
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 40);
            this.lastNameTextBox.TabIndex = 46;
            this.lastNameTextBox.Texts = "";
            this.lastNameTextBox.UnderlinedStyle = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.firstNameTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.firstNameTextBox.BorderSize = 2;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.Location = new System.Drawing.Point(579, 225);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Multiline = false;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.firstNameTextBox.PasswordChar = false;
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 40);
            this.firstNameTextBox.TabIndex = 45;
            this.firstNameTextBox.Texts = "";
            this.firstNameTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(159, 401);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.Size = new System.Drawing.Size(300, 40);
            this.passwordTextBox.TabIndex = 44;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.loginTextBox.BorderSize = 2;
            this.loginTextBox.Enabled = false;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.Location = new System.Drawing.Point(159, 225);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Multiline = false;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.loginTextBox.PasswordChar = false;
            this.loginTextBox.Size = new System.Drawing.Size(300, 40);
            this.loginTextBox.TabIndex = 43;
            this.loginTextBox.Texts = "";
            this.loginTextBox.UnderlinedStyle = true;
            // 
            // phoneCodeLabel
            // 
            this.phoneCodeLabel.AutoSize = true;
            this.phoneCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCodeLabel.Location = new System.Drawing.Point(962, 366);
            this.phoneCodeLabel.Name = "phoneCodeLabel";
            this.phoneCodeLabel.Size = new System.Drawing.Size(65, 32);
            this.phoneCodeLabel.TabIndex = 42;
            this.phoneCodeLabel.Text = "Код";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(573, 365);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(141, 32);
            this.lastNameLabel.TabIndex = 41;
            this.lastNameLabel.Text = "Прізвище";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(1387, 369);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(54, 32);
            this.labelAge.TabIndex = 40;
            this.labelAge.Text = "Вік";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(967, 189);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(103, 32);
            this.countryLabel.TabIndex = 39;
            this.countryLabel.Text = "Країна";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(573, 189);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(61, 32);
            this.firstNameLabel.TabIndex = 38;
            this.firstNameLabel.Text = "Ім\'я";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(1387, 188);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(233, 32);
            this.emailLabel.TabIndex = 37;
            this.emailLabel.Text = "Поштовий адрес";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(1066, 365);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(134, 32);
            this.phoneLabel.TabIndex = 36;
            this.phoneLabel.Text = "Телефон";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(153, 365);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(113, 32);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(153, 189);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(238, 32);
            this.loginLabel.TabIndex = 34;
            this.loginLabel.Text = "Логін(псевдонім)";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backButton.BorderRadius = 20;
            this.backButton.BorderSize = 0;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1379, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(362, 102);
            this.backButton.TabIndex = 52;
            this.backButton.Text = "Повернутись на головну";
            this.backButton.TextColor = System.Drawing.Color.White;
            this.backButton.UseCompatibleTextRendering = true;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintLabel.Location = new System.Drawing.Point(807, 590);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(0, 32);
            this.hintLabel.TabIndex = 53;
            // 
            // noticeCount
            // 
            this.noticeCount.AutoSize = true;
            this.noticeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noticeCount.Location = new System.Drawing.Point(153, 68);
            this.noticeCount.Name = "noticeCount";
            this.noticeCount.Size = new System.Drawing.Size(308, 32);
            this.noticeCount.TabIndex = 54;
            this.noticeCount.Text = "Створено оголошень: ";
            // 
            // PersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noticeCount);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.countryCodeComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.phoneCodeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "PersonalCabinetForm";
            this.Size = new System.Drawing.Size(2170, 941);
            this.Load += new System.EventHandler(this.PersonalCabinetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FancyButton saveButton;
        private FancyTextBox ageTextBox;
        private FancyTextBox emailTextBox;
        private FancyTextBox phoneTextBox;
        private FancyComboBox countryComboBox;
        private FancyComboBox countryCodeComboBox;
        private FancyTextBox lastNameTextBox;
        private FancyTextBox firstNameTextBox;
        private FancyTextBox passwordTextBox;
        private FancyTextBox loginTextBox;
        private System.Windows.Forms.Label phoneCodeLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private FancyButton backButton;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label noticeCount;
    }
}
