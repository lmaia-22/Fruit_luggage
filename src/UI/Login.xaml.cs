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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UI
{

    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
        
            InitializeComponent();
        }

        private void Login_button(object sender, RoutedEventArgs e)
        {
            if (username_box.Text.Length == 0)
            {
                errormessage.Text = "Enter a valid Username.";
                username_box.Focus();
            }
            else
            {
                string username = username_box.Text;
                string password = password_box.Password;
                
            }
        }

    }
}
