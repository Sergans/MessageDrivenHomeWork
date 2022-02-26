﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MDLesson_1
{
    public class Restaurant
    {
       private readonly List<Table>_tables=new List<Table>();
        public Restaurant()
        {
            for (ushort i=1; i <=10;i++)
            {
              _tables.Add(new Table(i));
            }
        }
       public void BookFreeTable(int CountOfPersons)
       {
            Console.WriteLine("Добрый день! Подождите секунду я подберу для Вас столик и подтвержу Вашу бронь");
            var table = _tables.FirstOrDefault(t=>t.SeatsCount>CountOfPersons&&t.State==State.Free);
            Thread.Sleep(1000 * 5);

            Console.WriteLine(table is null ? $"К сожалению столиков нет" : $"Готово, Ваш столик номер{table.Id}");
       }
        public void BookFreeTableAsync(int CountOfPersons)
        {
            Console.WriteLine("Добрый день! Подождите секунду я подберу для Вас столик. Вам придет уведомление");
            Task.Run(async () =>
            {
                var table = _tables.FirstOrDefault(t => t.SeatsCount > CountOfPersons && t.State == State.Free);
                await Task.Delay(1000 * 5);
                table?.SetState(State.Booked);

                Console.WriteLine(table is null ? $"К сожалению столиков нет" : $"Готово, Ваш столик номер{table.Id}");
            });
         }
        public bool FreeTable(int idTable)
        {
           foreach (var table in _tables)
            {
                if(table.Id == idTable && table.State == State.Booked)
                {
                    table.State= State.Free;
                    return true;
                }
            }

           return false;
            
        }

    }
}
