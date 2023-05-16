
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WpfApp2;


namespace WpfApp2
{
    public partial class Regist : Page
    {
        AppContext db;

        public Regist()
        {
            InitializeComponent();

            db = new AppContext();

        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string login = usernameBox.Text.Trim();
            string password = passwordBox.Password.Trim();
            

            if (login.Length < 3)
            {
                usernameBox.ToolTip = "Что-то пошло не так. Попробуйте еще раз.";
                
            }
            else if (password.Length < 3)
            {
                passwordBox.ToolTip = "Что-то пошло не так. Попробуйте еще раз.";
                
            }
            else
            {
                usernameBox.ToolTip = "";
                
                passwordBox.ToolTip = "";
                

                MessageBox.Show("Вы успешно зарегистрированы!");

                User user = new User(login, password);
                db.Userss.Add(user);
                db.SaveChanges();

                NavigationService.Navigate(new Avtor());
            }

            


        }

        private void BtnToSignIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Avtor());
        }
    }
}
