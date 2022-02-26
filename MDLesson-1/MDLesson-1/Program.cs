using System;
using System.Diagnostics;
using MDLesson_1;

Restaurant res = new Restaurant();
while (true)
{
    Console.WriteLine("Привет, желаете забронировать столик?\n1 Мы уведомим Вас по СМС \n2 Ожидайте на линии");

    if (!int.TryParse(Console.ReadLine(), out var choice) && choice is not (1 or 2))
    {
        Console.WriteLine("Введите 1 или 2");
        continue;
    }
    var stopWath = new Stopwatch();
    stopWath.Start();
    if (choice == 1)
    {
        res.BookFreeTableAsync(1);
    }
    else
    {
        res.BookFreeTable(1);
    }
    Console.WriteLine("Спасибо за Ваше обращение");
    stopWath.Stop();
    var ts=stopWath.Elapsed;
    Console.WriteLine($"{ts.Seconds:00}:{ts.Milliseconds:00}");
}

public enum State { Free=0,Booked=1}

