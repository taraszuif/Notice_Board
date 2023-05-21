namespace Notice_Board.View
{
    partial class AddNoticeForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.countryNotice = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new Notice_Board.View.FancyTextBox();
            this.adressTextBox = new Notice_Board.View.FancyTextBox();
            this.priceTextBox = new Notice_Board.View.FancyTextBox();
            this.titleTextBox = new Notice_Board.View.FancyTextBox();
            this.countryComboBox = new Notice_Board.View.FancyComboBox();
            this.categoryComboBox = new Notice_Board.View.FancyComboBox();
            this.addNoticeButton = new Notice_Board.View.FancyButton();
            this.backButton = new Notice_Board.View.FancyButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(854, 19);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(425, 51);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Додати оголошення";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(119, 122);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 32);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Заголовок";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(119, 202);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(74, 32);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Ціна";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(119, 412);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(82, 32);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Опис";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(550, 118);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(111, 32);
            this.adressLabel.TabIndex = 6;
            this.adressLabel.Text = "Адреса";
            // 
            // countryNotice
            // 
            this.countryNotice.AutoSize = true;
            this.countryNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryNotice.Location = new System.Drawing.Point(1079, 118);
            this.countryNotice.Name = "countryNotice";
            this.countryNotice.Size = new System.Drawing.Size(103, 32);
            this.countryNotice.TabIndex = 11;
            this.countryNotice.Text = "Країна";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(919, 200);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(143, 32);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Категорія";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descriptionTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.descriptionTextBox.BorderSize = 2;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionTextBox.Location = new System.Drawing.Point(125, 448);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.descriptionTextBox.PasswordChar = false;
            this.descriptionTextBox.Size = new System.Drawing.Size(1767, 380);
            this.descriptionTextBox.TabIndex = 32;
            this.descriptionTextBox.Texts = "";
            this.descriptionTextBox.UnderlinedStyle = true;
            // 
            // adressTextBox
            // 
            this.adressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.adressTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.adressTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.adressTextBox.BorderSize = 2;
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.ForeColor = System.Drawing.Color.Black;
            this.adressTextBox.Location = new System.Drawing.Point(556, 158);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adressTextBox.Multiline = false;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.adressTextBox.PasswordChar = false;
            this.adressTextBox.Size = new System.Drawing.Size(300, 40);
            this.adressTextBox.TabIndex = 31;
            this.adressTextBox.Texts = "";
            this.adressTextBox.UnderlinedStyle = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.priceTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.priceTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.priceTextBox.BorderSize = 2;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.Black;
            this.priceTextBox.Location = new System.Drawing.Point(125, 238);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Multiline = false;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.priceTextBox.PasswordChar = false;
            this.priceTextBox.Size = new System.Drawing.Size(300, 40);
            this.priceTextBox.TabIndex = 30;
            this.priceTextBox.Texts = "";
            this.priceTextBox.UnderlinedStyle = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.titleTextBox.BorderFocusColor = System.Drawing.Color.Gold;
            this.titleTextBox.BorderSize = 2;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.ForeColor = System.Drawing.Color.Black;
            this.titleTextBox.Location = new System.Drawing.Point(125, 158);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.titleTextBox.PasswordChar = false;
            this.titleTextBox.Size = new System.Drawing.Size(300, 40);
            this.titleTextBox.TabIndex = 29;
            this.titleTextBox.Texts = "";
            this.titleTextBox.UnderlinedStyle = true;
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
            this.countryComboBox.Location = new System.Drawing.Point(1085, 158);
            this.countryComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.countryComboBox.Size = new System.Drawing.Size(300, 35);
            this.countryComboBox.TabIndex = 34;
            this.countryComboBox.Texts = "";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryComboBox.BorderSize = 1;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoryComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.categoryComboBox.ListTextColor = System.Drawing.Color.Black;
            this.categoryComboBox.Location = new System.Drawing.Point(925, 235);
            this.categoryComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.categoryComboBox.Size = new System.Drawing.Size(460, 50);
            this.categoryComboBox.TabIndex = 36;
            this.categoryComboBox.Texts = "";
            // 
            // addNoticeButton
            // 
            this.addNoticeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addNoticeButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addNoticeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addNoticeButton.BorderRadius = 20;
            this.addNoticeButton.BorderSize = 2;
            this.addNoticeButton.FlatAppearance.BorderSize = 0;
            this.addNoticeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNoticeButton.ForeColor = System.Drawing.Color.White;
            this.addNoticeButton.Location = new System.Drawing.Point(863, 835);
            this.addNoticeButton.Name = "addNoticeButton";
            this.addNoticeButton.Size = new System.Drawing.Size(500, 125);
            this.addNoticeButton.TabIndex = 38;
            this.addNoticeButton.Text = "Додати оголошення";
            this.addNoticeButton.TextColor = System.Drawing.Color.White;
            this.addNoticeButton.UseVisualStyleBackColor = false;
            this.addNoticeButton.Click += new System.EventHandler(this.addNoticeButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(1530, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(362, 102);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Повернутись на головну";
            this.backButton.TextColor = System.Drawing.Color.White;
            this.backButton.UseCompatibleTextRendering = true;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(690, 383);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(164, 32);
            this.errorLabel.TabIndex = 40;
            this.errorLabel.Text = "Помилка?..";
            this.errorLabel.Visible = false;
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCheckBox.Location = new System.Drawing.Point(1546, 157);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(296, 36);
            this.phoneCheckBox.TabIndex = 41;
            this.phoneCheckBox.Text = "Вказувати телефон";
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCheckBox.Location = new System.Drawing.Point(1546, 249);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(261, 36);
            this.emailCheckBox.TabIndex = 42;
            this.emailCheckBox.Text = "Вказувати пошту";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailCheckBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addNoticeButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.countryNotice);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "AddNoticeForm";
            this.Size = new System.Drawing.Size(2106, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label countryNotice;
        private System.Windows.Forms.Label categoryLabel;
        private FancyTextBox descriptionTextBox;
        private FancyTextBox adressTextBox;
        private FancyTextBox priceTextBox;
        private FancyTextBox titleTextBox;
        private FancyComboBox countryComboBox;
        private FancyComboBox categoryComboBox;
        private FancyButton addNoticeButton;
        private FancyButton backButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
    }
}
