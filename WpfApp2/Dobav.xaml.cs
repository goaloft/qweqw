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

namespace WpfApp2
{
    public partial class Dobav : Page
    {
        AppContext db;

        public Dobav()
        {
            InitializeComponent();
            Loaded += Avtor_Loaded;
            db = new AppContext();
        }

        private void Avtor_Loaded(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Height = 800;
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new AppContext())
            {
                string username = usernameBox.Text;
                string password = passwordBox.Password;


                context.Userss.Add(new User
                {
                    Login = username,
                    Password = password,
                    id= 1
                    
                });

                int result = context.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Вы успешно зарегистрированы!");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так. Попробуйте еще раз.");
                }
            }
        }

        private void BtnToDataPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataPage());
        }
    }
}
