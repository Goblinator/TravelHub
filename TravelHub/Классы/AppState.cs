using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub
{
    public class AppState
    {
        private static Dictionary<string, dynamic> _state = new Dictionary<string, dynamic>(); // Создание словаря для хранения состояния приложения

        public static dynamic Get(string key) // Метод для получения объекта из состояния приложения по ключу
        {
            if (_state.ContainsKey(key)) return _state[key]; // Если ключ существует в словаре, возвращаем связанное с ним значение
            return false; // Возвращаем false, если ключ не найден
        }

        public static void Delete(string key) // Метод для удаления объекта из состояния приложения по ключу
        {
            _state.Remove(key); // Удаляем элемент из словаря по ключу
        }

        public static void Clear() // Метод для очистки всего состояния приложения (удаление всех объектов)
        {
            _state.Clear(); // Очищаем словарь, удаляя все объекты
        }

        public static Dictionary<string, dynamic> All() // Метод для получения всех объектов из состояния приложения
        {
            return _state; // Возвращаем весь словарь
        }

        public static void Add(string key, dynamic value) // Метод для добавления объекта в состояние приложения
        {
            if (_state.ContainsKey(key)) return; // Если ключ уже существует в словаре, не выполняем дублирование
            _state[key] = value; // Добавляем объект в словарь с указанным ключом
        }
    }
}
