// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Задача 13: Вывести вторую цифру трехзначного числа или сообщить, что третьей цифры нет.");
Console.WriteLine("Введите трехзначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// string number1 = Convert.ToString(number);
string number1 = Convert.ToString(Console.ReadLine());
if (number1.Length > 2)
{
   Console.WriteLine($"Третья цифра введенного Вами числа {number1} - это {number1[2]}");
}
else Console.WriteLine("Вы ввели не трехзначное число.");
