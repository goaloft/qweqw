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
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        AppContext db;

        public DataPage()
        {
            InitializeComponent();
            Loaded += DataPage_Loaded;
            db = new AppContext();
        }

        private void DataPage_Loaded(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Height = 720;
            Window.GetWindow(this).Width = 1080;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Avtor());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            UsersGrid.ItemsSource = db.Userss.ToList();
        }

        private void RemoveBtn_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя", "уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentClient = UsersGrid.SelectedItem as User;
                db.Userss.Remove(CurrentClient);
                db.SaveChanges();
                UsersGrid.ItemsSource = db.Userss.ToList();
                MessageBox.Show("Верно");
            }

        }

        private void AddBtn_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Dobav());
        }

        //private void ChangeBtn_click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        var CurrentClient = UsersGrid.SelectedItem as Client;
        //        NavigationService.Navigate(new (CurrentClient));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}
    }
}
