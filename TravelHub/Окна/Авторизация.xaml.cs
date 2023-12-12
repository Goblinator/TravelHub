using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TravelHub.Данные;

namespace TravelHub
{
    /// <summary>
    /// Interaction logic for Авторизация.xaml
    /// </summary>
    public partial class Авторизация : Window
    {
        int tries; // Переменная для отслеживания количества попыток входа
        static string symbols = "1234567890"; // Набор символов для создания капчи
        static Random r = new Random(); // Генератор случайных чисел
        static bool cc = false; // Флаг для отслеживания состояния капчи

        public Авторизация()
        {
            InitializeComponent();
            CaptchaGrid.Visibility = Visibility.Hidden; // Начальное скрытие элементов для капчи
        }

        private void ButtonEnterApp_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик нажатия кнопки входа в приложение

            Пользователь userData = new Пользователь();

            // Попытка получить данные о пользователе из базы данных
            userData = TravelHubEntities.GetContext().Пользователь.Where(u => u.Login == LoginInput.Text && u.Password == PasswordInput.Password).FirstOrDefault();

            if (tries >= 3 && userData == null)
            {
                DateTime date = DateTime.Now;
                MessageBox.Show($"Вы ввели неправильные данные больше трёх раз. Система заблокирована на {10} секунд");

                // Блокировка элементов управления на 10 секунд после трех неудачных попыток
                while (date.AddSeconds(10) > DateTime.Now)
                {
                    LoginInput.IsEnabled = false;
                    PasswordInput.IsEnabled = false;
                    ButtonEnterApp.IsEnabled = false;
                }

                LoginInput.IsEnabled = true;
                PasswordInput.IsEnabled = true;
                ButtonEnterApp.IsEnabled = true;
            }

            if (LoginInput.Text == "" || PasswordInput.Password == "")
            {
                if (cc && CapthaInput.Text != "")
                {
                    MessageBox.Show("Неверная капча");
                    updCaptcha();
                    tries++;
                    return;
                }
                MessageBox.Show("Убедитесь что все поля введены");
            }
            else
            {
                if (cc)
                {
                    if (CapthaInput.Text != Captcha.Text)
                    {
                        MessageBox.Show("Неверная капча");
                        updCaptcha();
                        tries++;
                        return;
                    }
                }

                // Попытка аутентификации пользователя
                Пользователь our_user = Utility.GetUserByLogin(LoginInput.Text);

                if (our_user != null && Utility.VerifyPassword(PasswordInput.Password, our_user.Password))
                {
                    // Пользователь успешно аутентифицирован

                    // Добавляем информацию о сессии пользователя в AppState
                    AppState.Add("isLogin", true);
                    AppState.Add("userType", "our_user");
                    AppState.Add("our_user", our_user);

                    TravelHubEntities.GetContext().SaveChanges();

                    if (our_user.ID_Роли == 1)
                    {
                        MessageBox.Show("Добро пожаловать администратор!");
                        Меню_сотрудника adminPanel = new Меню_сотрудника();
                        adminPanel.Show();
                        Close();
                        return;
                    }
                    else if (our_user.ID_Роли == 2)
                    {
                        TravelHubEntities.GetContext().SaveChanges();
                        MessageBox.Show("Удачных покупок!");
                        Меню_клиента buyerMenu = new Меню_клиента();
                        buyerMenu.Show();
                        Close();
                        return;
                    }
                }
                else
                {
                    CaptchaGrid.Visibility = Visibility.Visible;
                    cc = true;
                    updCaptcha();
                    tries++;
                    MessageBox.Show("Неверный логин или пароль. Пройдите проверку капчи");
                }
            }
        }

        private void updCaptcha()
        {
            // Генерация случайной капчи
            var index = r.Next(symbols.Length);
            var index2 = r.Next(symbols.Length);
            var index3 = r.Next(symbols.Length);
            var index4 = r.Next(symbols.Length);

            Captcha.Text = index.ToString() + index2.ToString() + index3.ToString() + index4.ToString();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Обработчик команды для выхода из приложения
            Application.Current.Shutdown();
        }

        private void ButtonEnterAsGuest_Click(object sender, RoutedEventArgs e)
        {
            // Вход как гость
            MessageBox.Show("Для того чтобы сделать заказ - зарегистрируйтесь");
            AppState.Add("isLogin", true);
            AppState.Add("userType", "guest");
            Меню_клиента window = new Меню_клиента();
            window.Show();
            Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу регистрации
            Регистрация registerForm = new Регистрация();
            registerForm.Show();
            Close();
        }
    }
}