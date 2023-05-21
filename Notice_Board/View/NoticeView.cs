using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice_Board.View
{
    public partial class NoticeView : UserControl
    {
        private Notice notice;
        private bool owner;
        private Person currentUser;
        public NoticeView(Notice notice, bool owner, Person currentUser)
        {
            InitializeComponent();
            this.notice = notice;
            this.owner = owner;
            this.currentUser = currentUser;

        }

        private void NoticeView_Load(object sender, EventArgs e)
        {
            titleLabel.Text = notice.Title;
            priceLabel.Text = "Ціна:" + notice.Price.ToString();

            descriptionLabel.Text = notice.Description;

            changeButton.Enabled = owner;
            changeButton.Visible = owner;
            deleteButton.Enabled = owner;
            deleteButton.Visible = owner;

            Person creator1 = UserRepository.GetInstance().Read(notice.Creator.Trim());
            contactLabel.Text = "Контакти:" + $"{(notice.ShowPhone ? $"Телефон: {creator1.Phone} " : "")}{(notice.ShowEmail ? $"Пошта: {creator1.Email}" : "")}";


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new AddNoticeForm(currentUser, notice));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            NoticeRepository.GetInstance().Delete(notice.Id);
            MainForm.Instance.SetContent(new HomeForm(currentUser));
        }
    }
}
