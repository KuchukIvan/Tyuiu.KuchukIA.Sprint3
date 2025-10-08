using System;
using Tyuiu.KuchukIA.Sprint3.Task0.V21.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #0                                                                                  *");
        Console.WriteLine("* Вариант #21                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при a=1,5   *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        double value = 1.5;
        int startValue = 1;
        int stopValue = 13;

        Console.WriteLine("a = " + value);
        Console.WriteLine("Стартовое значение равно " + startValue);
        Console.WriteLine("Конечное значение равно " + stopValue);


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Сумма ряда равна " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();

    }
}
