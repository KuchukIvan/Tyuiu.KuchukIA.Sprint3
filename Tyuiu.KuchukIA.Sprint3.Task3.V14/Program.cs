using System;
using Tyuiu.KuchukIA.Sprint3.Task3.V14.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #3                                                                                  *");
        Console.WriteLine("* Вариант #14                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed                       *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        string str = "dgt ghedd bed";
        char replaceable = 'd';
        char replacement = '’';

        Console.WriteLine("Исходная строка: " + str);
        Console.WriteLine("Заменяемый символ: " + replaceable);
        Console.WriteLine("Заменяющий символ: " + replacement);


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        Console.WriteLine("Новая строка: " + ds.ReplaceCharInString(str, replaceable, replacement));


        Console.ReadKey();

    }
}
