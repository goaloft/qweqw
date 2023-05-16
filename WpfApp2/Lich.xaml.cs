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
    public partial class Lich : Page
    {
        public Lich()
        {
            InitializeComponent();
            DataContext = new User1() // Создаем экземпляр класса User1 и передаем его в DataContext
            {
                FirstName = "",
                LastName = "",
                Email = "",
            };
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Сохраняем информацию о пользователе
            User user = DataContext as User;
            // TODO: реализуйте логику сохранения информации о пользователе
            MessageBox.Show("Изменения сохранены!");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tovar());

        }
    }

    public class User1
    {
        public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    }
}
