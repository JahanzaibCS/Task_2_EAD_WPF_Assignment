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

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            showPassword.Visibility = Visibility.Visible;
            showPassword.Text = Password.Password;
            Password.Visibility = Visibility.Hidden;
            hide.Visibility = Visibility.Visible;
            show1.Visibility = Visibility.Hidden;          
        }
        
        private void Hide(object sender, RoutedEventArgs e)
        {

            showPassword.Visibility = Visibility.Hidden;
            Password.Visibility = Visibility.Visible;
            Password.Password = showPassword.Text;
           
            hide.Visibility = Visibility.Hidden;
            show1.Visibility = Visibility.Visible;
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Password;
            if (userName.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("You have looged in successfully");
                UserName.Text = "";
                showPassword.Text = "";
                Password.Password = "";
            }
            else
            {
                MessageBox.Show("Please enter \"admin\" as a logIn Id and password");
            }
        }
    }
}


