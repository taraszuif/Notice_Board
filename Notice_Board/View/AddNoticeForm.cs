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
    public partial class AddNoticeForm : UserControl
    {
        private Person currentUser;
        private bool update = false;
        private Notice notice;
        public AddNoticeForm(Person user)
        {
            InitializeComponent();
            this.currentUser = user;
            Fill();

        }

        private void Fill()
        {
            foreach (Category category in CategoryRepository.GetInstance().GetAll())
            {
                categoryComboBox.Items.Add(category.ToString());
            }
            var countries = CountryRepository.GetInstance();
            foreach (var country in countries)
            {
                countryComboBox.Items.Add(country.Name);
            }
        }
        public AddNoticeForm(Person user, Notice notice)
        {
            InitializeComponent();
            this.currentUser = user;
            Fill();
            UpdateNotice(notice);
            update = true;
            this.notice = notice;


        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = MainForm.Instance;
            mainForm.SetContent(new HomeForm(currentUser));
        }



        private void UpdateNotice(Notice noticeToUpdate)
        {
            addNoticeButton.Text = "Змінити оголошення";
            mainLabel.Text = "Змінити оголошення";
            titleTextBox.Texts = noticeToUpdate.Title;
            descriptionTextBox.Texts = noticeToUpdate.Description;
            priceTextBox.Texts = noticeToUpdate.Price.ToString();
            adressTextBox.Texts = noticeToUpdate.TextAddress;
            countryComboBox.SelectedItem = noticeToUpdate.Country;
            categoryComboBox.SelectedItem = noticeToUpdate.Category;
            phoneCheckBox.Checked = noticeToUpdate.ShowPhone;
            emailCheckBox.Checked = noticeToUpdate.ShowEmail;
        }

        private void CreateNotice()
        {
            try
            {
                if (String.IsNullOrEmpty(titleTextBox.Texts))
                {
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Введіть заголовок.";
                    return;
                }

                if (String.IsNullOrEmpty(descriptionTextBox.Texts))
                {
                    errorLabel.Visible = true;

                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Введіть опис.";
                    return;
                }

                if (!decimal.TryParse(priceTextBox.Texts, out decimal price))
                {
                    errorLabel.Visible = true;

                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Введіть ціну в правильному форматі.";
                    return;
                }

                if (String.IsNullOrEmpty(adressTextBox.Texts))
                {
                    errorLabel.Visible = true;

                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Введіть адресу.";
                    return;
                }

                if (countryComboBox.SelectedItem == null)
                {
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Виберіть країну.";
                    return;
                }

                if (categoryComboBox.SelectedItem == null)
                {
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Виберіть категорію.";
                    return;
                }

                // Всі дані є валідними, створюємо нове оголошення
                if (update)
                {
                    Notice newNotice = new Notice(notice.Id, notice.CreationDate,
                        price,
                        notice.Creator,
                        descriptionTextBox.Texts,
                        titleTextBox.Texts,
                        categoryComboBox.SelectedItem.ToString(),
                        countryComboBox.SelectedItem.ToString(),
                        adressTextBox.Texts,
                        phoneCheckBox.Checked,
                        emailCheckBox.Checked);

                    NoticeRepository.GetInstance().Update(newNotice); errorLabel.Visible = true;

                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Text = "Ви успішно змінили оголошення.";
                }
                else
                {
                    Notice newNotice = new Notice(
                    price,
                    currentUser.Login,
                    descriptionTextBox.Texts,
                    titleTextBox.Texts,
                    categoryComboBox.SelectedItem.ToString(),
                    countryComboBox.SelectedItem.ToString(),
                    adressTextBox.Texts,
                    phoneCheckBox.Checked,
                    emailCheckBox.Checked);

                    NoticeRepository.GetInstance().Create(newNotice);
                    errorLabel.ForeColor = Color.Green; errorLabel.Visible = true;

                    errorLabel.Text = "Ви успішно створили оголошення.";
                }
                MainForm mainForm = MainForm.Instance;
                mainForm.SetContent(new HomeForm(currentUser));
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;

                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.Message;
            }
        }

        private void addNoticeButton_Click(object sender, EventArgs e)
        {
            CreateNotice();
        }
    }
}
