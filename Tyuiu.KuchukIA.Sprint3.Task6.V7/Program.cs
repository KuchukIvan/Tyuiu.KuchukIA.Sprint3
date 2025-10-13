using System;
using Tyuiu.KuchukIA.Sprint3.Task6.V7.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #6                                                                                  *");
        Console.WriteLine("* Вариант #7                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих                           *");
        Console.WriteLine("* числовому отрезку [17, 26] сумму всех делителей                                               *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        int startValue = 17;
        int stopValue = 26;

        Console.WriteLine("Начало отрека = " + startValue);
        Console.WriteLine("Конец отрека = " + stopValue);


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        Console.WriteLine("Сумма всех делителей: " + ds.GetSumTheDivisors(startValue, stopValue));


        Console.ReadKey();

    }
}
