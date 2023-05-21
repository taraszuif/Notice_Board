using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Notice_Board.View
{
    public partial class PersonalCabinetForm : UserControl
    {
        private Person currentUser;
        private Person changingUser;

        public PersonalCabinetForm(Person user)
        {
            InitializeComponent();
            this.currentUser = user;
            Fill();
        }
        public PersonalCabinetForm(Person user, Person changingUser)
        {
            InitializeComponent();
            this.currentUser = user;
            this.changingUser = changingUser;
            Fill();
        }
        private void Fill()
        {

            var countries = CountryRepository.GetInstance();
            foreach (var country in countries)
            {
                countryComboBox.Items.Add(country.Name);
                countryCodeComboBox.Items.Add($"{country.ShortName} {country.PhoneCode}");

            }
        }
        private void PersonalCabinetForm_Load(object sender, EventArgs e)
        {
            loginTextBox.Texts = currentUser.Login;
            passwordTextBox.Texts = currentUser.Password;
            ageTextBox.Texts = currentUser.Age + "";
            emailTextBox.Texts = currentUser.Email;
            firstNameTextBox.Texts = currentUser.FirstName;
            lastNameTextBox.Texts = currentUser.LastName;
            phoneTextBox.Texts = currentUser.Phone;
            countryComboBox.SelectedItem = currentUser.Country;
            string[] phones = currentUser.Phone.Split(' ');
            string code = phones[0] + " " + phones[1];
            string phone = phones[2];
            phoneTextBox.Texts = phone;
            countryCodeComboBox.SelectedItem = code;
            noticeCount.Text = "Створено оголошень: " + NoticeRepository.GetInstance().GetNoticeCountByUser(changingUser == null ? currentUser.Login : changingUser.Login);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new HomeForm(changingUser != null ? changingUser : currentUser));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(loginTextBox.Texts))
                {
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Введіть логін.";
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
                    hintLabel.Text = "Виберіть код країни.";
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
                if (currentUser is Administrator)
                {

                    Person newUser = new Administrator(
                        firstNameTextBox.Texts,
                        lastNameTextBox.Texts,
                        age,
                        countryComboBox.SelectedItem.ToString(),
                        $"{countryCodeComboBox.SelectedItem.ToString()} {phoneTextBox.Texts}",
                        emailTextBox.Texts,
                        loginTextBox.Texts,
                        passwordTextBox.Texts, currentUser.CreationDate);

                    UserRepository.GetInstance().Update(newUser);
                    hintLabel.ForeColor = Color.Green;
                    currentUser = newUser;

                }
                else
                {
                    Person newUser = new User(
                 firstNameTextBox.Texts,
                 lastNameTextBox.Texts,
                 age,
                 countryComboBox.SelectedItem.ToString(),
                 $"{countryCodeComboBox.SelectedItem.ToString()} {phoneTextBox.Texts}",
                 emailTextBox.Texts,
                 loginTextBox.Texts,
                 passwordTextBox.Texts, currentUser.CreationDate);

                    UserRepository.GetInstance().Update(newUser);
                    hintLabel.ForeColor = Color.Green;
                    currentUser = newUser;

                }
                hintLabel.Text = "Ви успішно змінили інформацію.";
            }
            catch (Exception ex)
            {
                hintLabel.ForeColor = Color.Red;
                hintLabel.Text = ex.Message;

            }
        }
    }
}
