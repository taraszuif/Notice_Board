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
    public partial class UserListForm : UserControl
    {
        private Person currentUser;
        private BindingSource _userBinding;
        private BindingSource _adminBinding;
        private void SetupDataGridViews()
        {
            _userBinding = new BindingSource();
            _adminBinding = new BindingSource();


            _userBinding.DataSource = UserRepository.GetInstance().GetAllUsers();
            _adminBinding.DataSource = UserRepository.GetInstance().GetAllAdmins();

            userDataGridView.DataSource = _userBinding;
            adminDataGridView.DataSource = _adminBinding;

        }

        public UserListForm(Person user)
        {
            currentUser = user;
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetContent(new HomeForm(currentUser));
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            SetupDataGridViews();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedUser = userDataGridView.CurrentRow?.DataBoundItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("No user selected.");
                return;
            }

            UserRepository.GetInstance().Delete(selectedUser.Login);
            SetupDataGridViews();
        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            var selectedUser = userDataGridView.CurrentRow?.DataBoundItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("No user selected.");
                return;
            }
            PersonalCabinetForm cabinetForm = new PersonalCabinetForm(currentUser, selectedUser);
            MainForm.Instance.SetContent(cabinetForm);
        }

        private void adminChangeButton_Click(object sender, EventArgs e)
        {
            var selectedAdmin = adminDataGridView.CurrentRow?.DataBoundItem as Administrator;
            if (selectedAdmin == null)
            {
                MessageBox.Show("No admin selected.");
                return;
            }
            PersonalCabinetForm cabinetForm = new PersonalCabinetForm(currentUser, selectedAdmin);
            MainForm.Instance.SetContent(cabinetForm);
        }

        private void adminDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedAdmin = adminDataGridView.CurrentRow?.DataBoundItem as Administrator;
            if (selectedAdmin == null)
            {
                MessageBox.Show("No admin selected.");
                return;
            }

            UserRepository.GetInstance().Delete(selectedAdmin.Login);
            SetupDataGridViews();
        }
    }
}
