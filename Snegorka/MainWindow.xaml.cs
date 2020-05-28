using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snegorka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DbContextLocal contextLocal = new DbContextLocal();
        static DbContextGlobal contextGlobal = new DbContextGlobal();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = contextLocal.users.ToList();
            List<User> usersG = contextGlobal.users.ToList();

            foreach (User user in users)
            {
                if(TB_login.Text == user.Login && TB_password.Text == user.Password)
                {
                    System.Windows.MessageBox.Show("Test5");
                }
            }
        }

        private void TB_login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TB_login.Text == "Введите логин")
            {
                TB_login.Text = "";
                TB_login.FontStyle = FontStyles.Normal;
                TB_login.Foreground = Brushes.Black;
            }
        }

        private void TB_login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TB_login.Text == "")
            {
                TB_login.Text = "Введите логин";
                TB_login.FontStyle = FontStyles.Italic;
                TB_login.Foreground = Brushes.Gray;
            }
        }


        private void TB_password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TB_password.Text == "Введите пароль")
            {
                TB_password.Text = "";
                TB_password.FontStyle = FontStyles.Normal;
                TB_password.Foreground = Brushes.Black;
            }
        }

        private void TB_password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TB_password.Text == "")
            {
                TB_password.Text = "Введите пароль";
                TB_password.FontStyle = FontStyles.Italic;
                TB_password.Foreground = Brushes.Gray;
            }
        }
    }
}
