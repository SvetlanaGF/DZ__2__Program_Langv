﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Задача 15: Определить по номеру дня недели является ли он выходным.");
Console.WriteLine("Введите номер дня недели (от 1 до 7):  ");
int number15 = Convert.ToInt32(Console.ReadLine());
    if (number15 == 6) Console.WriteLine($"{number15}-й день недели суббота. Суббота выходной день.");
    else 
        if (number15 == 7) Console.WriteLine($"{number15}-й день недели воскресенье. Воскресенье выходной день.");
        else 
            if (number15 < 1 || number15 > 7) Console.WriteLine($"В неделе 7 дней. Вы ввели неверный номер для определения.");
            else Console.WriteLine($"{number15}-й день недели рабочий.");