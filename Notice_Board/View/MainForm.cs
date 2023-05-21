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
    public partial class MainForm : Form
    {
        private static MainForm instance;

        public static MainForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainForm();
                }

                return instance;
            }
        }

        private MainForm()
        {
            InitializeComponent();
        }


        public void SetContent(UserControl content)
        {
            foreach (Control control in panelContent.Controls)
            {
                    panelContent.Controls.Remove(control);   
            }

            panelContent.Controls.Add(content);
            content.Dock = DockStyle.Fill;
            content.Show();

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CategoryRepository.GetInstance().Save();
            CountryRepository.GetInstance().Save();
            UserRepository.GetInstance().Save();
            NoticeRepository.GetInstance().Save();
        }
    }
}