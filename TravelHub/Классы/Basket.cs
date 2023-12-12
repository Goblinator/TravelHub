using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub
{
    public class Basket
    {
        private static List<int> _basket = new List<int>(); // Список для хранения ID номеров в корзине

        public static List<int> getBasket() // Метод для получения содержимого корзины (списка ID номеров)
        {
            return _basket;
        }

        public static void addproduct(int value) // Метод для добавления ID номера в корзину
        {
            _basket.Add(value);
        }

        public static void ClearBasket() // Метод для очистки корзины (удаление всех номеров)
        {
            _basket = new List<int>(); // Создание нового пустого списка для корзины
        }

        public static void Delete(int id) // Метод для удаления конкретного номера из корзины по его ID
        {
            _basket.Remove(id); // Удаление номера из списка корзины по его ID
        }
    }
}
