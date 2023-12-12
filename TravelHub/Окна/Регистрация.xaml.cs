using System.Text.RegularExpressions;
using System.Windows;

namespace TravelHub
{
    /// <summary>
    /// Interaction logic for Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            // Функционал регистрации

            if (loginInput.Text == "" || Password.Password == "" || password2.Password == "" || NameInput.Text == "" || SurnameInput.Text == "" || PatronymicInput.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("Убедитесь, что все поля введены");
            }
            else
            {
                if (Password.Password != password2.Password)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return;
                }
                else
                {
                    int ADM = 2;
                    Utility.createUser(loginInput.Text, NameInput.Text, SurnameInput.Text, PatronymicInput.Text, Utility.HashPassword(Password.Password), ADM, PhoneNumber.Text);
                    MessageBox.Show("Вы зарегистрированы как покупатель");
                    Авторизация authView = new Авторизация();
                    authView.Show();
                    Close();
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возвращение на окно аутентификации

            Авторизация window = new Авторизация();
            window.Show();
            Close();
        }

        private void PhoneNumber_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);
        }
    }
}
