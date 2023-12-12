using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TravelHub.Commands
{
    public class DataCommands  // Команды редактирования для панели инструментов
    {
        public static RoutedCommand Delete { get; set; } // Команда для удаления
        public static RoutedCommand Edit { get; set; } // Команда для редактирования

        // Статический конструктор класса, инициализирует команды
        static DataCommands()
        {
            // Создание коллекции для хранения комбинаций клавиш (горячих клавиш)
            InputGestureCollection inputs = new InputGestureCollection();

            // Добавление комбинации клавиш Ctrl+E в коллекцию для команды Edit
            inputs.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E"));
            Edit = new RoutedCommand("Edit", typeof(DataCommands), inputs);

            // Создание новой коллекции для хранения другой комбинации клавиш (горячих клавиш)
            inputs = new InputGestureCollection();

            // Добавление комбинации клавиш Ctrl+D в коллекцию для команды Delete
            inputs.Add(new KeyGesture(Key.D, ModifierKeys.Control, "Ctrl+D"));
            Delete = new RoutedCommand("Delete", typeof(DataCommands), inputs);
        }
    }
}
