using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice_Board.View
{
    public partial class RegistrationForm : UserControl
    {
        private static RegistrationForm instance;
        public static RegistrationForm GetInstance()
        {
            if (instance == null)
            {
                instance = new RegistrationForm();
            }
            return instance;
        }

        public RegistrationForm()
        {
            InitializeComponent();
            var countries = CountryRepository.GetInstance();
            foreach (var country in countries)
            {
                countryComboBox.Items.Add(country.Name);
                countryCodeComboBox.Items.Add($"{country.ShortName} {country.PhoneCode}");
            }

        }



        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            loginButton.Left = (this.ClientSize.Width - loginButton.Width) / 2 - 30;
            loginButton.Top = (int)((this.ClientSize.Height - loginButton.Height) / 1.2);
            loginButton.BringToFront();
            registerButton.BringToFront();
            registerButton.Left = (this.ClientSize.Width - registerButton.Width) / 2;
            registerButton.Top = (int)((this.ClientSize.Height - registerButton.Height) / 1.2) - 125;
            hintLabel.Left = registerButton.Left;
            hintLabel.Top = registerButton.Top - 30;

            int spacing = (int)(this.ClientSize.Width - (loginTextBox.Width * 4)) / 4;
            int heightspacing = (int)((this.ClientSize.Height - loginTextBox.Height) / 6);
            int baseChange = 0;
            int secondChange = 75;

            Arrange(loginLabel, loginTextBox, 1, baseChange);
            Arrange(passwordLabel, passwordTextBox, 1, secondChange);
            Arrange(firstNameLabel, firstNameTextBox, 2, baseChange);
            Arrange(lastNameLabel, lastNameTextBox, 2, secondChange);
            Arrange(countryLabel, countryComboBox, 3, baseChange);
            Arrange(emailLabel, emailTextBox, 3, secondChange);
            Arrange(labelAge, ageTextBox, 4, baseChange);
            Arrange(phoneCodeLabel, countryCodeComboBox, 4, secondChange);
            Arrange(phoneLabel, phoneTextBox, 4.35, secondChange);
        }

        private void Arrange(Label label, Control control, double spacingMultiplier, int heightChange)
        {
            int spacing = (int)(this.ClientSize.Width - (loginTextBox.Width * 4)) / 4 + 150;
            int heightspacing = (int)((this.ClientSize.Height - loginTextBox.Height) / 6) + heightChange;
            int labelMinus = 30;
            label.Top = heightspacing - labelMinus;
            label.Left = (int)(spacing * spacingMultiplier);
            control.Top = heightspacing;
            control.Left = (int)(spacing * spacingMultiplier);
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(loginTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть логін.";
                    return;
                }
                if(UserRepository.GetInstance().Exists(loginTextBox.Texts)) {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Обраний логін вже зайнято.";
                    return;
                }

                if (String.IsNullOrEmpty(passwordTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть пароль.";
                    return;
                }
                if (String.IsNullOrEmpty(firstNameTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть ім'я.";
                    return;
                }

                if (String.IsNullOrEmpty(lastNameTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть прізвище.";
                    return;
                }

                if (String.IsNullOrEmpty(ageTextBox.Texts) || !int.TryParse(ageTextBox.Texts, out int age))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть вік у правильному форматі.";
                    return;
                }

                if (countryComboBox.SelectedItem == null)
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Виберіть країну.";
                    return;
                }

                if (countryCodeComboBox.SelectedItem == null)
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Виберіть телефонний код країни.";
                    return;
                }

                if (String.IsNullOrEmpty(phoneTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть номер телефону.";
                    return;
                }

                if (String.IsNullOrEmpty(emailTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть електронну пошту.";
                    return;
                }


                // Всі дані є валідними, створюємо нового користувача
                User newUser = new User(
                    firstNameTextBox.Texts,
                    lastNameTextBox.Texts,
                    age,
                    countryComboBox.SelectedItem.ToString(),
                    $"{countryCodeComboBox.SelectedItem.ToString()} {phoneTextBox.Texts}",
                    emailTextBox.Texts,
                    loginTextBox.Texts,
                    passwordTextBox.Texts);
                UserRepository.GetInstance().Create(newUser);
                hintLabel.ForeColor = Color.Green;
                hintLabel.Text = "Ви успішно зареєструвалися. Можете війти.";
            }
            catch (Exception ex)
            {
                hintLabel.ForeColor = Color.Red;
                hintLabel.Text = ex.Message;

            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            MainForm.Instance.SetContent(loginForm);
        }

  
    }
}
