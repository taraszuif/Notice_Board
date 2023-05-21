using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice_Board.View
{
    public partial class HomeForm : UserControl
    {
        private int _currentPage = 1;
        private List<Notice> _notices;
        private List<Panel> _views;
        private Person currentUser;
        private int i = 20;
        private int countItemOnPage = 2;


        public HomeForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _notices = NoticeRepository.GetInstance().GetAll();
            _views = new List<Panel>();
            currentUser = user; 
            LoadNotices(_notices);
            LoadNoticesForCurrentPage();

            LoadUserButtons();

            foreach (Category category in CategoryRepository.GetInstance().GetAll())
            {
                filterComboBox.Items.Add(category.ToString());
            }
        }

  

        private void LoadUserButtons()
        {
            if (currentUser == null)
            {
                loginButton.Visible = true;
                loginButton.Enabled = true;
                logoutButton.Visible = false;
                logoutButton.Enabled = false;
                privateAreaButton.Enabled = false;
                privateAreaButton.Visible = false;
                addNoticeButton.Visible = false;
                addNoticeButton.Enabled = false;
                viewUsersButton.Visible = false;
                viewUsersButton.Enabled = false;
            }
            else if (currentUser is Administrator)
            {
                loginButton.Visible = false;
                loginButton.Enabled = false;
                logoutButton.Visible = true;
                logoutButton.Enabled = true;
                privateAreaButton.Enabled = true;
                privateAreaButton.Visible = true;
                addNoticeButton.Visible = true;
                addNoticeButton.Enabled = true;
                viewUsersButton.Visible = true;
                viewUsersButton.Enabled = true;
            }
            else if (currentUser is User)
            {
                loginButton.Visible = false;
                loginButton.Enabled = false;
                logoutButton.Visible = true;
                logoutButton.Enabled = true;
                privateAreaButton.Enabled = true;
                privateAreaButton.Visible = true;
                addNoticeButton.Visible = true;
                addNoticeButton.Enabled = true;
                viewUsersButton.Visible = false;
                viewUsersButton.Enabled = false;
            }
        }

        private void LoadNotices(List<Notice> notices)
        {

            foreach (Notice notice1 in notices)
            {
                bool owner = (currentUser != null) && (notice1.Creator.Equals(currentUser.Login) || currentUser is Administrator);
                try
                {
                    NoticeView first = new NoticeView(notice1, owner, currentUser);

                    Panel panel = new Panel();
                    panel.Controls.Clear();
                    panel.Size = new System.Drawing.Size(500, 400);

                    panel.Controls.Add(first);
                    panel.TabIndex = i;
                    panel.Name = "Panel" + i;

                    first.Dock = DockStyle.Fill;
                    first.Show();
                    _views.Add(panel);
                    this.Controls.Add(panel);
                    i++;
                }
                catch (KeyNotFoundException e)
                {
                    NoticeRepository.GetInstance().Delete(notice1.Id);
                    continue;
                }
            }

        }
        private void LoadNoticesForCurrentPage()
        {
            int startIndex = (_currentPage - 1) * countItemOnPage;
            int endIndex = startIndex + countItemOnPage - 1;
            endIndex = Math.Min(endIndex, _views.Count - 1);

            HideAll();

            for (int i = startIndex; i <= endIndex; i++)
            {
                _views[i].Location = new Point(0, 0);
                noticesFlowLayoutPanel.Controls.Add(_views[i]);
            }
        }

        private void HideAll()
        {
            foreach (Panel panel in _views)
            {
                panel.Location = new Point(10000, 10000);
            }
            noticesFlowLayoutPanel.Controls.Clear();
        }

        private void ChangePage(int delta)
        {
            int newPage = _currentPage + delta;

            if (newPage >= 1 && ((delta > 0 && (newPage - 1) * countItemOnPage < _views.Count) || (delta < 0 && newPage > 0)))
            {
                _currentPage = newPage;
                LoadNoticesForCurrentPage();
                pageLabel.Text = "Сторінка " + newPage;
                pageTextBox.Texts = newPage.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChangePage(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void pageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(pageTextBox.Texts, out int newPage))
            {
                if (newPage >= 1 && (newPage - 1) * countItemOnPage < _views.Count)
                {
                    _currentPage = newPage;
                    LoadNoticesForCurrentPage();
                    pageLabel.Text = "Сторінка " + newPage;
                    pageTextBox.Texts = newPage.ToString();
                }
            }
        }

        private void filterComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)filterComboBox.SelectedItem;
            this._notices = NoticeRepository.GetInstance().FilterByCategory(selected);
            HideAll();
            _views.Clear();
            LoadNotices(this._notices);
            _currentPage = 1;
            pageLabel.Text = "Сторінка 1";
            pageTextBox.Texts = "1";
            LoadNoticesForCurrentPage();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = MainForm.Instance;
            mainForm.SetContent(new HomeForm(null));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            MainForm.Instance.SetContent(loginForm);
        }

        private void sortComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = sortComboBox.SelectedIndex;
            switch (selected)
            {
                case 0:
                    {
                        this._notices = NoticeRepository.GetInstance().SortByPriceAscending(this._notices);
                        HideAll();
                        _views.Clear();
                        LoadNotices(this._notices);
                        _currentPage = 1;
                        pageLabel.Text = "Сторінка 1";
                        pageTextBox.Texts = "1";
                        LoadNoticesForCurrentPage();
                        break;
                    }
                case 1:
                    {
                        this._notices = NoticeRepository.GetInstance().SortByPriceDescending(this._notices);
                        HideAll();
                        _views.Clear();
                        LoadNotices(this._notices);
                        _currentPage = 1;
                        pageLabel.Text = "Сторінка 1";
                        pageTextBox.Texts = "1";
                        LoadNoticesForCurrentPage();
                        break;
                    }


            }
        }

        private void countOnPage_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = int.Parse(countOnPage.SelectedItem.ToString());
            countItemOnPage = selected;
            _currentPage = 1;
            pageLabel.Text = "Сторінка 1";
            pageTextBox.Texts = "1";
            LoadNoticesForCurrentPage();

        }



        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new UserListForm(currentUser));
        }



        private void addNoticeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new AddNoticeForm(currentUser));
        }

        private void privateAreaButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new PersonalCabinetForm(currentUser));
        }
    }
}
