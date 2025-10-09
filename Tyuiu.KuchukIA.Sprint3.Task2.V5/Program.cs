using System;
using Tyuiu.KuchukIA.Sprint3.Task2.V5.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #2                                                                                  *");
        Console.WriteLine("* Вариант #5                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* аписать программу используя цикл do...while, которая вычисляет сумму ряда по формуле,       *");
        Console.WriteLine("* при a=0,75                                                                                  *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        double value = 0.75;
        int startValue = 1;
        int stopValue = 20;

        Console.WriteLine("Знаение a = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));


        Console.ReadKey();

    }
}
