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
    public partial class LoginForm : UserControl
    {
        private static LoginForm instance;

        public static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            int left = (this.ClientSize.Width - registerButton.Width) / 2;
            loginButton.Left = left - 30;
            loginButton.Top = (int)((this.ClientSize.Height - loginButton.Height) / 1.2);
            loginButton.BringToFront();
            registerButton.BringToFront();

            registerButton.Left = left;
            registerButton.Top = (int)((this.ClientSize.Height - loginButton.Height) / 1.2) - 125;
            hintLabel.Left = registerButton.Left;
            hintLabel.Top = registerButton.Top - 30;
            passwordTextBox.Top = hintLabel.Top - 150;
            passwordLabel.Top = passwordTextBox.Top - 30;
            passwordTextBox.Left = left;
            passwordLabel.Left = left;
            loginTextBox.Top = passwordLabel.Top - 50;
            loginTextBox.Left = left;
            loginLabel.Top = loginTextBox.Top - 30;
            loginLabel.Left = left;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо користувача з репозиторію
                Person user = UserRepository.GetInstance().Read(loginTextBox.Texts);

                // Перевіряємо, чи користувач існує і чи пароль вірний
                if (user != null && user.Password == passwordTextBox.Texts)
                {
                    // Користувач авторизований
                    MainForm.Instance.SetContent(new HomeForm(user));
                }
                else
                {
                    // Користувач не знайдений або пароль невірний
                    hintLabel.ForeColor = Color.Red;
                    hintLabel.Text = "Неправильний логін чи пароль.";
                }

            }
            catch (KeyNotFoundException)
            {
                hintLabel.ForeColor = Color.Red;
                hintLabel.Text = "Неправильний логін чи пароль.";
            }
            catch (Exception ex)
            {
                hintLabel.ForeColor = Color.Red;
                hintLabel.Text = "Непередбачувана помилка: " + ex.Message;
            }


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = RegistrationForm.GetInstance();
            MainForm.Instance.SetContent(registrationForm);
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = MainForm.Instance;
            mainForm.SetContent(new HomeForm(null));
        }
    }
}
