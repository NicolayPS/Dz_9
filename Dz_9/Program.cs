using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача №1\nСмоделируйте работу простого калькулятора. \nПрограмма должна запрашивать 2 числа, а затем – код операции \n(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). \nПосле этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных..\n\nВведите количество попыток для этой программы:");
            int t = 0;
            try
            {
                t = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            int o = 1;
            while (o <= t)
            {


                Console.WriteLine("\nПопытка №{0} из {1}!\n................", o, t);
                #region ввод данных, выбор опции
                int num1 = 0; int num2 = 0;
                Console.WriteLine("Вас приветствует калькулятор!");
                try
                {
                    Console.Write("Введите первое целое число. X=");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Ошибка! ");
                    Console.WriteLine(ex.Message);
                    Console.Write("Введите первое целое число. X=");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                try
                {
                    Console.Write("Введите второе целое число. Y=");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Ошибка! ");
                    Console.WriteLine(ex.Message);
                    Console.Write("Введите второе целое число. Y=");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("\t1 - Сложение");
                Console.WriteLine("\t2 - Вычитание");
                Console.WriteLine("\t3 - Произведение");
                Console.WriteLine("\t4 - Частное");
                Console.Write("Ваш выбор: ");
                #endregion

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Результат = {0}", (num1 + num2));
                        break;
                    case "2":
                        Console.WriteLine("Результат = {0}", (num1 - num2));
                        break;
                    case "3":
                        Console.WriteLine("Результат = {0}", (num1 * num2));
                        break;
                    case "4":
                        while (num2 == 0)
                        {
                            Console.Write("Ошибка деления на 0\nВыберете другое Y=");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Результат = {0}", (num1 / num2));
                        break;
                    default:
                        Console.Write("Ошибка! Нет операции с указаным номером");
                        break;
                }


                Console.Write("Нажмите любую кнопку для продолжения!");
                Console.ReadKey();
                o++;
            }
            Console.WriteLine("\nНажмите любую кнопку для закрытия программы!");
            Console.ReadKey();
        }
    }
}
