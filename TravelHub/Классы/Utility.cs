using TravelHub.Данные;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace TravelHub
{
    public class Utility
    {
        private static TravelHubEntities Hot = new TravelHubEntities();

        // Получение данных пользователя по логину
        public static Пользователь GetUserByLogin(string login)
        {
            return Hot.Пользователь.FirstOrDefault(our_user => our_user.Login == login);
        }

        // Получение номера по его ID
        public static Номер GetNOMER(int id)
        {
            return Hot.Номер.Find(id);
        }

        // Создание брони
        public static List<Номер> GetAvailableRooms(int hotelId, DateTime checkInDate, DateTime checkOutDate)
        {
            List<Номер> availableRooms = new List<Номер>();

            // Получаем список всех номеров в отеле
            var allRooms = Hot.Номер
                .Where(номер => номер.ID_Отеля == hotelId)
                .ToList();

            // Получаем список номеров, забронированных на указанные даты
            var reservedRooms = Hot.Бронирование
                .Where(бронь => бронь.ID_Отеля == hotelId &&
                               (бронь.Дата_заселения <= checkOutDate &&
                                бронь.Дата_выселения >= checkInDate))
                .Select(бронь => бронь.ID_Номера)
                .ToList();

            // Выбираем доступные номера (которые не были забронированы на указанные даты)
            foreach (var room in allRooms)
            {
                if (!reservedRooms.Contains(room.ID_Номера))
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }
        public static bool ReserveRoom(int hotelId, int userId, int status, dynamic checkInDate, dynamic checkOutDate, string name, string surname, string patronymic)
        {
            // Получение свободных номеров в выбранном отеле
            List<Номер> availableRooms = GetAvailableRooms(hotelId, checkInDate, checkOutDate);

            if (availableRooms.Count > 0)
            {
                // Выбор первого свободного номера
                Номер roomToReserve = availableRooms.First();

                // Создание брони

                return true;
            }

            return false;
        }
        public static void createOrder(int status, int hotel, int userId, string name, string surname, string patronymic, dynamic checkInDate, dynamic checkOutDate)
        {
            Бронирование our_order = new Бронирование();
            our_order.Дата_заселения = checkInDate;
            our_order.Дата_выселения = checkOutDate;
            our_order.ID_Пользователя = userId;
            our_order.Имя = name;
            our_order.Фамилия = surname;
            our_order.Отчество = patronymic;
            our_order.ID_Статуса = status;
            our_order.ID_Отеля = hotel;

            Hot.Бронирование.Add(our_order);
            Hot.SaveChanges();

            foreach (int id in Basket.getBasket())
            {

                Hot.Список_брони.Add(new Список_брони() { ID_Брони = our_order.ID_Брони, ID_Номера = GetNOMER(id).ID_Номера });
                Hot.SaveChanges();
            }
        }

        // Создание пользователя
        public static void createUser(string login, string Name, string Фамилия, string Отчество, string Password, int ADM, string PhoneNumber)
        {
            Hot.Пользователь.Add(new Пользователь() { Login = login, Имя = Name, Фамилия = Фамилия, Отчество = Отчество, Password = Password, ID_Роли = ADM, Номер_телефона = PhoneNumber });
            Hot.SaveChanges();
        }

        // Хеширование пароля
        public static string HashPassword(string Password)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Проверка пароля
        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            var enteredPasswordHash = HashPassword(enteredPassword);
            return string.Equals(enteredPasswordHash, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        // Поиск номеров по тексту
        public static List<Номер> searchNOMERS(string text)
        {
            return Hot.Номер.Where(Номер => Номер.Название_номера.ToLower().Contains(text)).ToList();
        }
    }
}
