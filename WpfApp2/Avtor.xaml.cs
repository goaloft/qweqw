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
using WpfApp2;

namespace WpfApp2
{

    public partial class Avtor : Page
    {
        AppContext db;

        public Avtor()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            //var CurrentUser = db.Userss.FirstOrDefault(u => u.Login.Equals(TxbLogin.Text) && u.Password.Equals(TxbPassword.Password));


            //if (CurrentUser != null)
            //{

            //    if (CurrentUser.Login.Equals("Admin"))
            //    {

            //        NavigationService.Navigate(new DataPage());
            //    }
            //    else
            //    {
            //        NavigationService.Navigate(new Tovar());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Данного пользователя не существует", "Ошибка");
            //}
            string login = TxbLogin.Text.Trim();
            string password = TxbPassword.Password.Trim();
            string nameUserType = TxbLogin.Text.Trim();
            if (login.Length < 3)
            {
                TxbLogin.ToolTip = "Что-то пошло не так. Попробуйте еще раз.";
            }
            else if (password.Length < 3)
            {
                TxbPassword.ToolTip = "Что-то пошло не так. Попробуйте еще раз.";
            }
            else
            {
                TxbLogin.ToolTip = "";
                TxbPassword.ToolTip = "";

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Userss.Where(b => b.Login == login && b.Password ==
                    password).FirstOrDefault();
                    if (authUser.Login.Equals("Admin"))
                    {

                        NavigationService.Navigate(new DataPage());
                    }
                    else
                    {
                        NavigationService.Navigate(new Tovar());
                    }
                }

                //UserType userType = null;
                //using (AppContext db = new AppContext())
                //{
                //    userType = db.UserTypes.Where(w => w.NameUserType == nameUserType).FirstOrDefault();
                //    if (userType.idUserType.Equals("Admin"))
                //    {

                //        NavigationService.Navigate(new DataPage());
                //    }
                //}

                if (authUser != null)

                    MessageBox.Show("Вход успешен");
                else
                    MessageBox.Show("Введены неправильные данные");

            }
            
        }
        private void Click2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Regist());

        }

    }

}


