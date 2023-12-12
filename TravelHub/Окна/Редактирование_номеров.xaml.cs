using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TravelHub.Данные;

namespace TravelHub
{
    /// <summary>
    /// Interaction logic for Редактирование_номеров.xaml
    /// </summary>
    public partial class Редактирование_номеров : Window
    {
        public Редактирование_номеров()
        {
            InitializeComponent();
            DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.ToList();
            ТипChange.ItemsSource = TravelHubEntities.GetContext().Тип.ToList();
            ТипSearch.ItemsSource = TravelHubEntities.GetContext().Тип.ToList();
            СтатусChange.ItemsSource = TravelHubEntities.GetContext().Статус.ToList();
        }
        private bool isDirty = true;
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия кнопки удаления
            e.CanExecute = isDirty;
        }
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Удаление файлов
            var RemovingPers = DataGridNomer.SelectedItems.Cast<Номер>().ToList();

            if (MessageBox.Show($"Удалить {RemovingPers.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelHubEntities.GetContext().Номер.RemoveRange(RemovingPers);
                    // Выбираем определенное количество элементов и удаляем их, сохраняем бд, обновляем таблицу.
                    TravelHubEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено");
                    DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            isDirty = false;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия кнопки изменения
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Изменение файлов через метод BeginEdit()
            DataGridNomer.IsReadOnly = false;
            DataGridNomer.BeginEdit();
            isDirty = false;
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Сохранение информации
            try
            {
                TravelHubEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isDirty = true;
            DataGridNomer.IsReadOnly = true;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия кнопки сохранения
            e.CanExecute = !isDirty;
        }
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Возврат последнего действия
            var context = TravelHubEntities.GetContext();
            var changedEntries = context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
            DataGridNomer.ItemsSource = null;
            DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.ToList();
            MessageBox.Show("Отмена действия");
            isDirty = true;
            DataGridNomer.IsReadOnly = true;
        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия на отмену
            e.CanExecute = !isDirty;
        }
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Создание новой строки в таблице
            DataGridNomer.IsReadOnly = false;
            Номер Prod = new Номер()
            {
                Название_номера = "",
                Цена = 0,
                Фото = null,
                ID_Типа = 1,
            };

            int Nomerid = TravelHubEntities.GetContext().Номер.Max(d => d.ID_Номера);
            if (Nomerid == 0)
            {
                Nomerid = 1;
            }
            else
            {
                Nomerid++;
            }

            Prod.ID_Номера = Nomerid;
            TravelHubEntities.GetContext().Номер.Add(Prod);
            try
            {
                TravelHubEntities.GetContext().SaveChanges();
                DataGridNomer.ItemsSource = null;
                DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.ToList();
                MessageBox.Show("Данные готовы к добавлению");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isDirty = false;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия на кнопку создания
            e.CanExecute = isDirty;
        }

        private void NameSearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Кнопка поиска названия номера по нажатию клавиши
            ТипSearch.Text = "";
            string Name = NameSearch.Text;
            var check = TravelHubEntities.GetContext().Номер.Where(c => c.Название_номера.Contains(Name)).ToList();
            if (check.FirstOrDefault() == null)
            {
                MessageBox.Show("Название неправильно записано или не введено", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                DataGridNomer.ItemsSource = null;
                DataGridNomer.ItemsSource = (System.Collections.IEnumerable)check;
            }
        }
        private void ТипSearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Поиск по типам
            string SecName = ТипSearch.Text;
            Тип secIDQuery = (Тип)TravelHubEntities.GetContext().Тип.Where(c => c.Название_типа.Contains(SecName)).FirstOrDefault();
            int secID = secIDQuery.ID_Типа;
            DataGridNomer.ItemsSource = null;
            DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.Where(c => c.ID_Типа == secID).ToList();
        }

        private void RefreshCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Возможность нажатия на кнопку обновления
            e.CanExecute = isDirty;
        }

        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Обновление всех данных
            ТипSearch.Text = "";
            NameSearch.Text = "";
            DataGridNomer.ItemsSource = null;
            DataGridNomer.ItemsSource = TravelHubEntities.GetContext().Номер.ToList();
            isDirty = false;
            BorderFind.Visibility = Visibility.Visible;
        }

        private void NameSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // При изменении текста в поиске названия
            NameSearchButton.IsEnabled = true;
            НаличиеСкладSearchButton.IsEnabled = false;
        }

        private void ТипSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // При изменении выбора в поиске категории
            NameSearchButton.IsEnabled = false;
            НаличиеСкладSearchButton.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в меню сотрудника
            Меню_сотрудника window = new Меню_сотрудника();
            window.Show();
            this.Close();
        }
    }
}
