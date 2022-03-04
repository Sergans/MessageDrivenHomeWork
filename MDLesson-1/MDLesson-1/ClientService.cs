using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLesson_1
{
    public class ClientService
    {
        public Restaurant _restaurant;
        public const string message = "ГОТОВО";
        
        public ClientService(Restaurant restaurant)
        {
            _restaurant = restaurant;
        }
        public void ClientRequest(int requestId)
        {
            
            switch (requestId)
            {
                
                case 1:Console.WriteLine("Введите количество человек");
                    int countPersons = int.Parse(Console.ReadLine());
                    Console.WriteLine("Добрый день! Вам придет уведомление");
                    _restaurant.BookFreeTableAsync(countPersons);
                   
                    break;
                case 2:
                    Console.WriteLine("Введите количество человек");
                    int count_persons = int.Parse(Console.ReadLine());
                    Console.WriteLine("Добрый день! Подождите секунду я подберу для Вас столик и подтвержу Вашу бронь");
                    var table=_restaurant.BookFreeTable(count_persons);
                    Console.WriteLine(table is null ? $"{message}:К сожалению столиков нет" : $"{message}:Ваш столик номер-{table.Id}");
                    break;
                case 3:
                    Console.WriteLine("Введите номер стола");
                    int nomberTable = int.Parse(Console.ReadLine());
                    Console.WriteLine("Добрый день! Подождите секунду я посмотрю список и отменю бронь");
                    table=_restaurant.FreeTable(nomberTable);
                    Console.WriteLine(table is null ? $"{message}:Данный стол был свободен" : $"{message}:Бронь стола номер-{table.Id} снята");
                    break;
                case 4:
                    Console.WriteLine("Введите номер стола");
                    int nomber_table = int.Parse(Console.ReadLine());
                    Console.WriteLine("Добрый день! Вам придет уведомление об отмене");
                    _restaurant.FreeTableAsync(nomber_table);
                    break;
                    default: Console.WriteLine("Неверный код запроса");
                    break;

            }
            
                

            
        }
    }
}
