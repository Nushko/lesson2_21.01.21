using System;

namespace lesson2_21._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить
            каждой переменной большее из этих значений, а если равны, то присвоить переменным
            нулевые значения. Вывести новые значения переменных A и B.
            **/
            
            Console.WriteLine("Введите два числа: ");
            int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine());
            
            if ( A != B)
            {
                A = Math.Max(A, B);
                B = A;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine($"A = {A}, B = {B}.");

            /**
            Консольный калькулятор. Создайте две переменные с именами
            operand1 и operand2.Задайте переменным некоторые произвольные значения.
            Предложите пользователю ввести знак арифметической операции. Примите значение,
            введенное пользователем, и поместите его в строковую переменную sign.Для
            организации выбора алгоритма вычислительного процесса, используйте переключатель
            switch.Выведите на экран результат выполнения арифметической операции. В случае
            использования операции деления, организуйте проверку попытки деления на ноль. И
            если таковая имеется, то отмените выполнение арифметической операции и уведомите
            об ошибке пользователя.
            **/

            Console.WriteLine("Калькулятор");
            Console.WriteLine("Введите два числа: ");
            double operand1 = Math.Round(double.Parse(Console.ReadLine())), operand2 = double.Parse(Console.ReadLine());
                
            Console.Write("Введите знак арифметической операции (+, -, *, /): ");
            string sigh = Console.ReadLine();
            
            switch (sigh)
            {
                case "+":
                Console.WriteLine($"{operand1} + {operand2} = {Math.Round(operand1 + operand2)}.");
                break;

                case "-":
                Console.WriteLine($"{operand1} - {operand2} = {Math.Round(operand1 - operand2)}.");
                break;

                case "*":
                Console.WriteLine($"{operand1} * {operand2} = {Math.Round(operand1 * operand2)}.");
                break;

                case "/":
                if (operand2 == 0)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: деление на ноль.");
                Console.ForegroundColor = ConsoleColor.White;
                break;
                }
                Console.WriteLine($"{operand1} / {operand2} = {Math.Round(operand1 / operand2)}.");
                break;

                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: вы ввели неправильный знак.");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            /**
            Напишите программу определения, попадает ли указанное пользователем число от 0 до
            100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [50 - 100]. Если да, то укажите, в
            какой именно промежуток. Если пользователь указывает число, не входящее ни в один
            из имеющихся числовых промежутков, то выводится соответствующее сообщение.
            **/

            Console.Write("Введите число: ");
            int prom = int.Parse(Console.ReadLine());

            if (prom < 0 || prom > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: число не находится в промежутке 0 - 100.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (prom < 14)
                {
                    Console.WriteLine("Число находится в промежутке 0 - 14.");
                }
                else if (prom < 35)
                {
                    Console.WriteLine("Число находится в промежутке 15 - 35.");
                }
                else if (prom < 51)
                {
                    Console.WriteLine("Число находится в промежутке 36 - 50.");
                }
                else
                {
                    Console.WriteLine("Число находится в промежутке 50 - 100.");
                }
            }

            /**
            Написать программу вычисления стоимости покупки с учетом скидки. Скидка в 3%
            предоставляется в том случае, если сумма покупки больше 500 сомони, в 5% - если
            сумма больше 1000 сомони 
            **/

            Console.Write("Введите стоимость покупки: ");
            double sumnum = double.Parse(Console.ReadLine());

            if (sumnum > 1000)
            {
                Console.WriteLine($"Общая сумма со скидкой 5% = {Math.Round(sumnum - (sumnum / 100 * 5), 2)}.");
            }
            else if (sumnum > 500)
            {
                Console.WriteLine($"Общая сумма со скидкой 3% = {Math.Round(sumnum - (sumnum / 100 * 3), 2)}.");
            }
            else
            {
                Console.WriteLine($"Общая сумма не меняется.");
            }

            /**
            Даны четыре числа. Если они не образуют возрастающую последовательность,
            вывести минимальный из них; если числа равны, найти их произведение, иначе
            сообщение «Числа расположены по возрастанию».
            **/

            Console.WriteLine("Введите четыре числа: ");
            int num1 = int.Parse(Console.ReadLine()), min1 = num1;
            int num2 = int.Parse(Console.ReadLine()); min1 = Math.Min(min1, num2);
            int num3 = int.Parse(Console.ReadLine()); min1 = Math.Min(min1, num3);
            int num4 = int.Parse(Console.ReadLine()); min1 = Math.Min(min1, num4);
            
            if (num1 == num2 && num1 == num3 && num1 == num4)
            {
                Console.WriteLine($"Произведение чисел = {num1 * 4}.");
            }
            else if (num1 < num2)
            {
                if (num2 < num3)
                {
                    if (num3 < num4)
                    {
                        Console.WriteLine("Числа расположены по возрастанию.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Минимальное число: {min1}.");
            }

            /**
            Запрашиваются три числа для переменных a, b, c. Значения переменных поменять
            таким образом, чтобы a >= b >= c.
            **/

            Console.WriteLine("Введите три числа: ");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
            
            if ( b < c)
            {
                b += c; 
                c = b - c; 
                b -= c;
            }
            if (a < b)
            {
                a += b;
                b = a - b;
                a -= b;
            }
            if (b < c)
            {
                b += c;
                c = b - c;
                b -= c;
            }
            Console.WriteLine($"Теперь a = {a}, b = {b}, c = {c}, а значит {a} >= {b} >= {c}.");
            Console.ReadKey();
        }
    }
}
