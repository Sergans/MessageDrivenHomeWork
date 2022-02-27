using System;
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
       public Table BookFreeTable(int CountOfPersons)
       {
            var table = _tables.FirstOrDefault(t=>t.SeatsCount>CountOfPersons&&t.State==State.Free);
            Thread.Sleep(1000 * 5);
            if (table != null)
            {
                table?.SetState(State.Booked);
                return table;
            }

            return null;
       }
        public void BookFreeTableAsync(int CountOfPersons)
        {
           
            Task.Run(async () =>
            {
                var table = _tables.FirstOrDefault(t => t.SeatsCount > CountOfPersons && t.State == State.Free);
                await Task.Delay(1000 * 5);
                table?.SetState(State.Booked);

                Console.WriteLine(table is null ? $"К сожалению столиков нет" : $"Готово, Ваш столик номер{table.Id}");
            });
         }
        public Table FreeTable(int idTable)
        {
            
            var table = _tables.FirstOrDefault(t => t.Id == idTable && t.State == State.Booked);
            Thread.Sleep(1000 * 5);
            if (table != null)
            {
                table?.SetState(State.Free);
                return table;
            }
            
            return null;
        }
        public void FreeTableAsync(int idTable)
        {
            
            Task.Run(async () =>
            {
                var table = _tables.FirstOrDefault(t => t.Id == idTable && t.State == State.Booked);
                await Task.Delay(1000 * 5);
                table?.SetState(State.Free);

                Console.WriteLine(table is null ? $"Данный стол был свободен" : $"Готово,бронь стола номер-{table.Id} снята");
            });
  
        }

    }
}
