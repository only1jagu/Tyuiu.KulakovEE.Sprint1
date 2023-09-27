﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KulakovEE.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Кулаков Егор Евгеньевич | АСОиУб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  и осущевствляет перевод градусов Цельсия в градусы по Фаренгейту.      *");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите температуру в градусах Цельсия:");
            double temp;
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Температура в градусах Фаренгейта равна: " + ds.FahrenheitToСelsius(temp));
            Console.ReadKey();
        }
    }
}
