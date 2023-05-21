namespace Notice_Board.View
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageLabel = new System.Windows.Forms.Label();
            this.noticesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.viewUsersButton = new Notice_Board.View.FancyButton();
            this.addNoticeButton = new Notice_Board.View.FancyButton();
            this.logoutButton = new Notice_Board.View.FancyButton();
            this.loginButton = new Notice_Board.View.FancyButton();
            this.privateAreaButton = new Notice_Board.View.FancyButton();
            this.pageTextBox = new Notice_Board.View.FancyTextBox();
            this.nextButton = new Notice_Board.View.FancyButton();
            this.backButton = new Notice_Board.View.FancyButton();
            this.countOnPage = new Notice_Board.View.FancyComboBox();
            this.sortComboBox = new Notice_Board.View.FancyComboBox();
            this.filterComboBox = new Notice_Board.View.FancyComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageLabel.Location = new System.Drawing.Point(911, 824);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(155, 32);
            this.pageLabel.TabIndex = 6;
            this.pageLabel.Text = "Сторінка 1";
            // 
            // noticesFlowLayoutPanel
            // 
            this.noticesFlowLayoutPanel.AutoScroll = true;
            this.noticesFlowLayoutPanel.Location = new System.Drawing.Point(21, 169);
            this.noticesFlowLayoutPanel.Name = "noticesFlowLayoutPanel";
            this.noticesFlowLayoutPanel.Size = new System.Drawing.Size(2431, 635);
            this.noticesFlowLayoutPanel.TabIndex = 18;
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.viewUsersButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.viewUsersButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewUsersButton.BorderRadius = 20;
            this.viewUsersButton.BorderSize = 0;
            this.viewUsersButton.FlatAppearance.BorderSize = 0;
            this.viewUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewUsersButton.ForeColor = System.Drawing.Color.White;
            this.viewUsersButton.Location = new System.Drawing.Point(1059, 21);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(217, 106);
            this.viewUsersButton.TabIndex = 19;
            this.viewUsersButton.Text = "Користувачі";
            this.viewUsersButton.TextColor = System.Drawing.Color.White;
            this.viewUsersButton.UseCompatibleTextRendering = true;
            this.viewUsersButton.UseVisualStyleBackColor = false;
            this.viewUsersButton.Click += new System.EventHandler(this.viewUsersButton_Click);
            // 
            // addNoticeButton
            // 
            this.addNoticeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addNoticeButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addNoticeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addNoticeButton.BorderRadius = 20;
            this.addNoticeButton.BorderSize = 0;
            this.addNoticeButton.FlatAppearance.BorderSize = 0;
            this.addNoticeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNoticeButton.ForeColor = System.Drawing.Color.White;
            this.addNoticeButton.Location = new System.Drawing.Point(1282, 21);
            this.addNoticeButton.Name = "addNoticeButton";
            this.addNoticeButton.Size = new System.Drawing.Size(224, 106);
            this.addNoticeButton.TabIndex = 17;
            this.addNoticeButton.Text = "Додати оголошення";
            this.addNoticeButton.TextColor = System.Drawing.Color.White;
            this.addNoticeButton.UseVisualStyleBackColor = false;
            this.addNoticeButton.Click += new System.EventHandler(this.addNoticeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logoutButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.logoutButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutButton.BorderRadius = 20;
            this.logoutButton.BorderSize = 0;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1704, 29);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(207, 90);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Вийти";
            this.logoutButton.TextColor = System.Drawing.Color.White;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginButton.BorderRadius = 20;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(1704, 29);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(207, 90);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Війти";
            this.loginButton.TextColor = System.Drawing.Color.White;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // privateAreaButton
            // 
            this.privateAreaButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.privateAreaButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.privateAreaButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.privateAreaButton.BorderRadius = 20;
            this.privateAreaButton.BorderSize = 0;
            this.privateAreaButton.FlatAppearance.BorderSize = 0;
            this.privateAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privateAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateAreaButton.ForeColor = System.Drawing.Color.White;
            this.privateAreaButton.Location = new System.Drawing.Point(1512, 28);
            this.privateAreaButton.Name = "privateAreaButton";
            this.privateAreaButton.Size = new System.Drawing.Size(186, 91);
            this.privateAreaButton.TabIndex = 14;
            this.privateAreaButton.Text = "Особистий кабінет";
            this.privateAreaButton.TextColor = System.Drawing.Color.White;
            this.privateAreaButton.UseVisualStyleBackColor = false;
            this.privateAreaButton.Click += new System.EventHandler(this.privateAreaButton_Click);
            // 
            // pageTextBox
            // 
            this.pageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pageTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pageTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pageTextBox.BorderSize = 2;
            this.pageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTextBox.ForeColor = System.Drawing.Color.Black;
            this.pageTextBox.Location = new System.Drawing.Point(958, 860);
            this.pageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pageTextBox.Multiline = false;
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.pageTextBox.PasswordChar = false;
            this.pageTextBox.Size = new System.Drawing.Size(46, 44);
            this.pageTextBox.TabIndex = 13;
            this.pageTextBox.Texts = "1";
            this.pageTextBox.UnderlinedStyle = false;
            this.pageTextBox._TextChanged += new System.EventHandler(this.pageTextBox_TextChanged);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nextButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nextButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextButton.BorderRadius = 20;
            this.nextButton.BorderSize = 0;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(1155, 824);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 99);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Вперед";
            this.nextButton.TextColor = System.Drawing.Color.White;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(663, 824);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 99);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.TextColor = System.Drawing.Color.White;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // countOnPage
            // 
            this.countOnPage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.countOnPage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countOnPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countOnPage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.countOnPage.BorderSize = 1;
            this.countOnPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countOnPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOnPage.ForeColor = System.Drawing.Color.Black;
            this.countOnPage.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.countOnPage.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.countOnPage.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.countOnPage.ListTextColor = System.Drawing.Color.Black;
            this.countOnPage.Location = new System.Drawing.Point(703, 77);
            this.countOnPage.MinimumSize = new System.Drawing.Size(200, 30);
            this.countOnPage.Name = "countOnPage";
            this.countOnPage.Padding = new System.Windows.Forms.Padding(1);
            this.countOnPage.Size = new System.Drawing.Size(313, 50);
            this.countOnPage.TabIndex = 22;
            this.countOnPage.Texts = "Кількість на сторінці";
            this.countOnPage.OnSelectedIndexChanged += new System.EventHandler(this.countOnPage_OnSelectedIndexChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sortComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sortComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sortComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.sortComboBox.BorderSize = 1;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.ForeColor = System.Drawing.Color.Black;
            this.sortComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.sortComboBox.Items.AddRange(new object[] {
            "По зростанню",
            "По спаданню"});
            this.sortComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sortComboBox.ListTextColor = System.Drawing.Color.Black;
            this.sortComboBox.Location = new System.Drawing.Point(703, 21);
            this.sortComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.sortComboBox.Size = new System.Drawing.Size(313, 50);
            this.sortComboBox.TabIndex = 21;
            this.sortComboBox.Texts = "Сортувати за ціною";
            this.sortComboBox.OnSelectedIndexChanged += new System.EventHandler(this.sortComboBox_OnSelectedIndexChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filterComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.filterComboBox.BorderSize = 1;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.ForeColor = System.Drawing.Color.Black;
            this.filterComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.filterComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.filterComboBox.ListTextColor = System.Drawing.Color.Black;
            this.filterComboBox.Location = new System.Drawing.Point(143, 21);
            this.filterComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.filterComboBox.Size = new System.Drawing.Size(492, 50);
            this.filterComboBox.TabIndex = 20;
            this.filterComboBox.Texts = "Фільтрувати за категорією";
            this.filterComboBox.OnSelectedIndexChanged += new System.EventHandler(this.filterComboBox_OnSelectedIndexChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countOnPage);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.viewUsersButton);
            this.Controls.Add(this.noticesFlowLayoutPanel);
            this.Controls.Add(this.addNoticeButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.privateAreaButton);
            this.Controls.Add(this.pageTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pageLabel);
            this.Name = "HomeForm";
            this.Size = new System.Drawing.Size(2920, 1920);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label pageLabel;
        private FancyButton backButton;
        private FancyButton nextButton;
        private FancyTextBox pageTextBox;
        private FancyButton privateAreaButton;
        private FancyButton loginButton;
        private FancyButton logoutButton;
        private FancyButton addNoticeButton;
        private System.Windows.Forms.FlowLayoutPanel noticesFlowLayoutPanel;
        private FancyButton viewUsersButton;
        private FancyComboBox filterComboBox;
        private FancyComboBox sortComboBox;
        private FancyComboBox countOnPage;
    }
}