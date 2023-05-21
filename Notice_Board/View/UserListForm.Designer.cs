namespace Notice_Board.View
{
    partial class UserListForm
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
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new Notice_Board.View.FancyButton();
            this.changeButton = new Notice_Board.View.FancyButton();
            this.backButton = new Notice_Board.View.FancyButton();
            this.adminDeleteButton = new Notice_Board.View.FancyButton();
            this.adminChangeButton = new Notice_Board.View.FancyButton();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToOrderColumns = true;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.userDataGridView.Location = new System.Drawing.Point(20, 86);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(868, 663);
            this.userDataGridView.TabIndex = 0;
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AllowUserToOrderColumns = true;
            this.adminDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.adminDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.adminDataGridView.Location = new System.Drawing.Point(1021, 86);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.RowHeadersWidth = 51;
            this.adminDataGridView.RowTemplate.Height = 24;
            this.adminDataGridView.Size = new System.Drawing.Size(854, 663);
            this.adminDataGridView.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 20;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(664, 764);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(224, 77);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Видалити користувача";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseCompatibleTextRendering = true;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.changeButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.changeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changeButton.BorderRadius = 20;
            this.changeButton.BorderSize = 0;
            this.changeButton.FlatAppearance.BorderSize = 0;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(664, 847);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(224, 77);
            this.changeButton.TabIndex = 21;
            this.changeButton.Text = "Змінити користувача";
            this.changeButton.TextColor = System.Drawing.Color.White;
            this.changeButton.UseCompatibleTextRendering = true;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(852, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(224, 77);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Повернутись на головну";
            this.backButton.TextColor = System.Drawing.Color.White;
            this.backButton.UseCompatibleTextRendering = true;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminDeleteButton
            // 
            this.adminDeleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminDeleteButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.adminDeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adminDeleteButton.BorderRadius = 20;
            this.adminDeleteButton.BorderSize = 0;
            this.adminDeleteButton.FlatAppearance.BorderSize = 0;
            this.adminDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminDeleteButton.ForeColor = System.Drawing.Color.White;
            this.adminDeleteButton.Location = new System.Drawing.Point(1021, 764);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(224, 77);
            this.adminDeleteButton.TabIndex = 23;
            this.adminDeleteButton.Text = "Видалити адміністратора";
            this.adminDeleteButton.TextColor = System.Drawing.Color.White;
            this.adminDeleteButton.UseCompatibleTextRendering = true;
            this.adminDeleteButton.UseVisualStyleBackColor = false;
            this.adminDeleteButton.Click += new System.EventHandler(this.adminDeleteButton_Click);
            // 
            // adminChangeButton
            // 
            this.adminChangeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminChangeButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.adminChangeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adminChangeButton.BorderRadius = 20;
            this.adminChangeButton.BorderSize = 0;
            this.adminChangeButton.FlatAppearance.BorderSize = 0;
            this.adminChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminChangeButton.ForeColor = System.Drawing.Color.White;
            this.adminChangeButton.Location = new System.Drawing.Point(1021, 847);
            this.adminChangeButton.Name = "adminChangeButton";
            this.adminChangeButton.Size = new System.Drawing.Size(224, 77);
            this.adminChangeButton.TabIndex = 24;
            this.adminChangeButton.Text = "Змінити адміністратора";
            this.adminChangeButton.TextColor = System.Drawing.Color.White;
            this.adminChangeButton.UseCompatibleTextRendering = true;
            this.adminChangeButton.UseVisualStyleBackColor = false;
            this.adminChangeButton.Click += new System.EventHandler(this.adminChangeButton_Click);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminChangeButton);
            this.Controls.Add(this.adminDeleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.userDataGridView);
            this.Name = "UserListForm";
            this.Size = new System.Drawing.Size(1990, 1061);
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private FancyButton deleteButton;
        private FancyButton changeButton;
        private FancyButton backButton;
        private FancyButton adminDeleteButton;
        private FancyButton adminChangeButton;
    }
}
