using System;
using Tyuiu.KuchukIA.Sprint3.Task1.V13.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #1                                                                                  *");
        Console.WriteLine("* Вариант #13                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле,    *");
        Console.WriteLine("* при n=1,2                                                                                   *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        double value = 1.2;
        int startValue = 1;
        int stopValue = 7;

        Console.WriteLine("Значение n = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        

        Console.ReadKey();

    }
}
