using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TravelHub.Данные;

namespace TravelHub
{
    /// <summary>
    /// Interaction logic for Каталог_номеров.xaml
    /// </summary>
    public partial class Каталог_номеров : Window
    {
        public Каталог_номеров()
        {
            InitializeComponent();
            if (AppState.Get("userType") == "guest")
            {
                // Определение типа пользователя и скрытие кнопок, если пользователь гость
                AddBasket.Visibility = Visibility.Hidden;
                ClearBasket.Visibility = Visibility.Hidden;
                Menu.Visibility = Visibility.Hidden;
            }

            if (!(bool)AppState.Get("isLogin"))
            {
                // Если пользователь не аутентифицирован, перенаправить на страницу авторизации
                Авторизация authView = new Авторизация();
                authView.Show();
                this.Close();
            }

            TravelHubEntities Hot = new TravelHubEntities();
            // Получение данных о номерах из базы данных
            productsListView.ItemsSource = Hot.Номер.ToList();

            this.checkBasketCount();
        }

        private void ClearBusket_Click(object sender, RoutedEventArgs e)
        {
            AddBasket.Visibility = Visibility.Visible;
            ClearBasket.Visibility = Visibility.Hidden;
            // Очистка корзины
            Basket.ClearBasket();
            this.checkBasketCount();
        }

        private void checkBasketCount()
        {
            // Проверка количества номеров в корзине и отображение соответствующих кнопок
            ClearBasket.Visibility = Visibility.Hidden;
            if (Basket.getBasket().Count > 0)
            {
                ClearBasket.Visibility = Visibility.Visible;
            }
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Поиск по тексту при вводе в соответствующем поле
            string text = SearchInput.Text;
            List<Номер> Номер = Utility.searchNOMERS(text);
            productsListView.ItemsSource = Номер;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в меню покупателя
            Меню_клиента window = new Меню_клиента();
            window.Show();
            this.Close();
        }
        private void CheckBasketCount() //Проверка численности для показа кнопок и т.д
        {
            ClearBasket.Visibility = Visibility.Hidden;
            AddBasket.Visibility = Visibility.Hidden;
            if (Basket.getBasket().Count > 0)
            {
                AddBasket.Visibility = Visibility.Visible;
                ClearBasket.Visibility = Visibility.Visible;
            }

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddBasket.Visibility = Visibility.Hidden;
            ClearBasket.Visibility = Visibility.Visible;
            // Добавление номера в корзину
            var current = (Номер)productsListView.SelectedItem;
            if (current == null)
            {
                MessageBox.Show("Выберите только одну услугу");
                this.CheckBasketCount();
            }
            else if (Basket.getBasket().Count < 1)
            {
                Basket.addproduct((int)current.ID_Номера);
                this.checkBasketCount();
            }
        }
    }
}
