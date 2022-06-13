/*Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.

 Задание 2
Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.

 Задание 3
Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры. Например,
если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.

 Задание 4
Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897. Если пользователь ввел не шестизначное число требуется вывести
сообщение об ошибке.

 Задание 5
Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.

Задание 6
Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий или наоборот.

Задание 7
Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.*/

using System;

namespace HW_1_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hwt;
            do { 
                Console.WriteLine("\nInput a number of task the homework from 1 to 7. \nIf you want to exit - input 0.");
                hwt = int.Parse(Console.ReadLine());
                    switch (hwt)
                    {
                        case 1://Задание 1 Вывести определенный текст при числе кратном 3, 5 или и 3 и 5
                            Console.WriteLine("Enter a positive integer number from 1 to 100");
                            int a = int.Parse(Console.ReadLine());
                            if (a >= 1 && a <= 100)
                            {
                                if (a % 3 == 0 && a % 5 == 0)
                                    Console.WriteLine("Fizz Buzz");
                                else if (a % 3 == 0)
                                    Console.WriteLine("Fizz");
                                else if (a % 5 == 0)
                                    Console.WriteLine("Buzz");
                                else
                                    Console.WriteLine(a);
                            }
                            else
                                Console.WriteLine("You entered the wrong number!");
                            break;
                        case 2://Задание 2 Вычислить процент от числа
                            Console.WriteLine("Enter any number");
                            double a1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input a number of percent you want to take from before entered number");
                            int perc = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{Math.Abs(perc)}% from number {a1} = {a1 * Math.Abs(perc) / 100}");
                            break;
                        case 3://Задание 3 Создать число из 4 введенных цифр
                            Console.WriteLine("Enter four any numbers");
                            string num1 = Console.ReadLine();
                            string num2 = Console.ReadLine();
                            string num3 = Console.ReadLine();
                            string num4 = Console.ReadLine();
                            a = int.Parse(num1 + num2 + num3 + num4);
                            Console.WriteLine(a);
                        break;
                        case 4://Задание 4 Обмен цифрами в двух разрядах шестизначного числа
                            Console.WriteLine("Enter a six-digit positive integer number");
                            num1 = Console.ReadLine();
                            if (num1.Length == 6)
                                {
                                    Console.WriteLine("Enter a first digit from 1 to 6");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter a second digit from 1 to 6 and different from first digit");
                                    int b = int.Parse(Console.ReadLine());
                                    char strtmp;
                                    strtmp = num1[a-1];
                                    num1 = num1.Replace(num1[a-1], num1[b-1]);
                                    num1 = num1.Remove(b-1, 1);
                                    num1 = num1.Insert(b-1, strtmp+"");
                                    Console.WriteLine(num1);
                                }
                            else
                                Console.WriteLine("You entered no six-digit number! Repeat one more time.");
                        break;
                        case 5://Задание 5 Показать сезон и день недели по введеной дате
                            string [] weekday = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
                            string [] seasons = {"Winter", "Spring", "Summer", "Autumn"};
                            int[] kodOfMonth = { 1, 4, 4, 0, 2, 5, 0, 3, 6, 1, 4, 6};
                            int[] kodOfCentury = {6, 4, 2, 0};
                            Console.WriteLine("Enter a date with pattern dd.mm.yyyy (For example 15.07.2012)");
                            num1 = Console.ReadLine();
                            string[] data = num1.Split(new char[] { '.' });
                            int day = int.Parse(data[0]);
                            int month = int.Parse(data[1]);  
                            int year = int.Parse(data[2]);
                            int century = year / 100;
                            int leapYear = (year % 4 == 0 && month < 3) ? ((year % 100 != 0) ? 1 : ((year % 400 != 0) ? 0 : 1)) : 0;
                            int kod = kodOfCentury[century % 4];
                            int kodOfYear = (kod + year % 100 + year % 100 / 4) % 7;
                            int kodOfSeason = month / 3 < 4 ? month / 3 : 0;
                            int kodOfWeekday = (day + kodOfMonth[month - 1] + kodOfYear) % 7;
                            Console.WriteLine($"Season - {seasons[kodOfSeason]} and day of week - {weekday[(leapYear == 1 && kodOfWeekday == 0)? 6 : kodOfWeekday - leapYear]}");
                        break;
                        case 6://Задание 6 Преобразования температуры из Цельсия в Фаренгейт и наоборот
                            Console.WriteLine("Enter temperature");
                            double temper = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input zero if you want to convert temperature from Celsius to Fahrenheit or any other number for reverse conversion");
                            a = int.Parse(Console.ReadLine());
                            if (a == 0)
                                Console.WriteLine($"{temper}°С = {temper*9/5+32}°F");
                            else
                                Console.WriteLine($"{temper}°F = {(temper-32)*5/9}°C");
                        break;
                        case 7://Задание 7 Вывести все четные числа между двумя заданными числами
                            Console.WriteLine("Input two positive integers number and you see all even numbers between them on the screen");
                            a = Math.Abs(int.Parse(Console.ReadLine()));
                            int c = Math.Abs(int.Parse(Console.ReadLine()));
                            if (a>c)
                            {
                                int tmp = a;
                                a = c;
                                c = tmp;
                            }
                            for (int i = a; i <= c; i++) {
                                if (i%2==0)
                                Console.WriteLine($"{i}");
                            }
                        break;
                        case 0://Выйти из программы
                        continue;
                    default:
                            Console.WriteLine("\nYou chose wrong number of task! Try one more time.\n");
                        break;
                    };
            } while (hwt != 0);
        }
    }
}
