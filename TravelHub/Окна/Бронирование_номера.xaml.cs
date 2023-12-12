using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using TravelHub.Данные;

namespace TravelHub
{
    /// <summary>
    /// Логика взаимодействия для Бронирование.xaml
    /// </summary>
    public partial class Бронирование_номера : Window
    {
        // Список номеров в корзине
        private List<Номер> basketItems = new List<Номер>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Вывод итоговой суммы номеров в корзине при загрузке окна
            resultSum.Content = $"Итоговая сумма:{basketItems.Sum(product => product.Цена)}";
        }

        // Проверка числа номеров в корзине для отображения кнопок
        private void checkBasketCount()
        {
            Del.Visibility = Visibility.Hidden;
            Buy.Visibility = Visibility.Hidden;
            if (Basket.getBasket().Count > 0)
            {
                Buy.Visibility = Visibility.Visible;
                Del.Visibility = Visibility.Visible;
            }
        }

        public Бронирование_номера()
        {
            InitializeComponent();

            CheckInDatePicker.DisplayDateStart = DateTime.Now;
            CheckOutDatePicker.DisplayDateStart = DateTime.Now;

            // Заполнение выпадающего списка отелей с помощью данных из базы
            Points.ItemsSource = TravelHubEntities.GetContext().Отель.ToList();

            basketItems = new List<Номер>();
            foreach (int id in Basket.getBasket())
            {
                // Получение номеров из корзины и добавление их в список
                basketItems.Add(Utility.GetNOMER(id));
            }

            // Привязка списка номеров в корзине к элементу управления ListView
            BasketListView.ItemsSource = basketItems;

            if (AppState.Get("userType") == "our_user")
            {
                // Если пользователь - обычный пользователь, то отображаются его данные
                NameBl.Text = $"Ваше имя: \n{AppState.Get("our_user").Имя}";
                SurnameBl.Text = $"Ваша фамилия: \n{AppState.Get("our_user").Фамилия}";
                PatronymicBl.Text = $"Ваше отчество: \n{AppState.Get("our_user").Отчество}";
            }


            // Обновление итоговой суммы номеров и проверка корзины
            updateResultSum();
            this.checkBasketCount();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в меню покупателя
            Меню_клиента window = new Меню_клиента();
            window.Show();
            this.Close();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            // Удаление номера из корзины
            System.ComponentModel.IEditableCollectionView items = BasketListView.Items;

            if (BasketListView.SelectedItem == null)
            {
                string msg = "Выберите удаляемый номер ";
                MessageBox.Show(msg);
                return;
            }
            else
            {
                Номер selectedItem = BasketListView.SelectedItems[0] as Номер;
                Basket.Delete((int)selectedItem.ID_Номера);
                items.Remove(BasketListView.SelectedItem);
                updateResultSum();
            }
        }

        // Обновление итоговой суммы брони
        private void updateResultSum()
        {
            resultSum.Content = $"Итоговая сумма:\n{basketItems.Sum(product => product.Цена)}";
        }

        // Создание брони
        public void createOrder()
        {
            DateTime checkInDate = CheckInDatePicker.SelectedDate ?? DateTime.MinValue;
            DateTime checkOutDate = CheckOutDatePicker.SelectedDate ?? DateTime.MinValue;
            int selectedHotelId = Points.SelectedIndex + 1; // +1, так как индексация начинается с 0

            if (selectedHotelId == 0)
            {
                selectedHotelId = 1;
            }
            var status = 1;

            if(AppState.Get("userType") == "our_user")
            {
                // Создание брони для обычного пользователя
                Utility.createOrder(status, selectedHotelId, (int)AppState.Get("our_user").ID_Пользователя, AppState.Get("our_user").Имя, AppState.Get("our_user").Фамилия, AppState.Get("our_user").Отчество, checkInDate, checkOutDate);
                MessageBox.Show("Заказ создан. Мы перезвоним вам для уточнения деталей");
            }
        }

        private bool ReserveRoom(DateTime checkInDate, DateTime checkOutDate)
        {
            int selectedHotelId = Points.SelectedIndex + 1; // +1, так как индексация начинается с 0

            if (selectedHotelId == 0)
            {
                selectedHotelId = 1;
            }

            int status = 1;

            if (AppState.Get("userType") == "our_user")
            {
                // Создание брони для обычного пользователя
                if (Utility.ReserveRoom(selectedHotelId, (int)AppState.Get("our_user").ID_Пользователя, status, checkInDate, checkOutDate, AppState.Get("our_user").Имя, AppState.Get("our_user").Фамилия, AppState.Get("our_user").Отчество))
                {
                    return true;
                }
            }

            return false;
        }
        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Get("userType") == "our_user")
            {
                // Получение выбранных дат бронирования
                DateTime checkInDate = CheckInDatePicker.SelectedDate ?? DateTime.MinValue;
                DateTime checkOutDate = CheckOutDatePicker.SelectedDate ?? DateTime.MinValue;

                if (checkInDate == DateTime.MinValue || checkOutDate == DateTime.MinValue)
                {
                    MessageBox.Show("Выберите дату заселения и выселения.");
                    return;
                }

                // Создание брони, учитывая выбранные даты
                if (ReserveRoom(checkInDate, checkOutDate))
                {
                    createOrder();
                }
                else
                {
                    MessageBox.Show("Выбранный номер уже забронирован на указанные даты.");
                }
            }
        }

        private void DelMEnu_Click(object sender, RoutedEventArgs e)
        {
            System.ComponentModel.IEditableCollectionView items = BasketListView.Items;

            if (BasketListView.SelectedItem == null)
            {
                string msg = "Выберите удаляемый номер ";
                MessageBox.Show(msg);
                return;
            }
            else
            {
                Номер selectedItem = BasketListView.SelectedItems[0] as Номер;
                Basket.Delete((int)selectedItem.ID_Номера);
                items.Remove(BasketListView.SelectedItem);
                updateResultSum();
            }
        }
    }
}
