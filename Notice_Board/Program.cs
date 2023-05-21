using Notice_Board.Model;
using Notice_Board.Repository;
using Notice_Board.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Notice_Board
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            CategoryRepository.GetInstance().Load();
            CountryRepository.GetInstance().Load();

            NoticeRepository.GetInstance().Load();
            UserRepository.GetInstance().Load();
            
            RegistrationForm.GetInstance();
            LoginForm.GetInstance();

            MainForm mainForm = MainForm.Instance;
            mainForm.SetContent(new HomeForm(null));
            Application.Run(mainForm);
        }


    }
}
