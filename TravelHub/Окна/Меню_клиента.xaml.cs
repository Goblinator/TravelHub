using System.Windows;
using System.Windows.Input;

namespace TravelHub
{
    /// <summary>
    /// Логика взаимодействия для Меню_клиента.xaml
    /// </summary>
    public partial class Меню_клиента : Window
    {
        public Меню_клиента()
        {
            InitializeComponent();  //Определяем тип пользователя и выводим его логин на экран
            {
                if (AppState.Get("userType") == "guest")
                {
                    toBuyerOrders.Visibility = Visibility.Hidden;
                    userNameBox.Content = "Гость";
                }
                else
                {
                    userNameBox.Content = AppState.Get("our_user").Login;
                }
            }
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Выход из программы
        {
            Application.Current.Shutdown();
        }

        private void CloseCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность выполнения
        {
            e.CanExecute = true;
        }

        private void toBuyCat_Click(object sender, RoutedEventArgs e) //Переход в каталог покупателя
        {
            Каталог_номеров buycat = new Каталог_номеров();
            buycat.Show();
            this.Close();
        }

        private void toBucket_Click(object sender, RoutedEventArgs e) //Переход в корзину
        {
            Бронирование_номера buyord = new Бронирование_номера();
            buyord.Show();
            this.Close();
        }
    }
}
