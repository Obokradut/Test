using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace pr_15_Dechenkov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext= this;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch{

                return false;
            }
        }

        private void txtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
