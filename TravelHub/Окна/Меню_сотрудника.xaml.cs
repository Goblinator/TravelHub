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
using System.Windows.Shapes;

namespace TravelHub
{
    /// <summary>
    /// Логика взаимодействия для Меню_сотрудника.xaml
    /// </summary>
    public partial class Меню_сотрудника : Window
    {
        public Меню_сотрудника()
        {
            InitializeComponent();  //Получение роли пользователя
            {
            userNameBox.Content = AppState.Get("our_user").Login;
            }
        }

        private void Execution_CanExecuted(object sender, ExecutedRoutedEventArgs e) //Выход из приложения
        {
            Application.Current.Shutdown();
        }


        private void toPerCat_Click(object sender, RoutedEventArgs e) //Переход к каталогу номеров
        {
            Редактирование_номеров percat = new Редактирование_номеров();
            percat.Show();
            this.Close();
        }

    }
}
