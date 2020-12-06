using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.Написать программу, которая считывает символы с клавиатуры, 
            пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.*/


            /*int spaceValue = 0;
            ConsoleKeyInfo Symbol;
            Console.WriteLine("Введите символ (для окончания ввода нажмите точку)");
            do
            {
                Symbol = Console.ReadKey();
                //Console.WriteLine();
                //Console.Clear();
                Console.WriteLine(Symbol.Key);
                if (Symbol.KeyChar == ' ')
                {
                    spaceValue++;
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Количество введенных пробелов = " + spaceValue);*/




            /*2.Ввести с клавиатуры номер трамвайного билета(6 - значное число) и про-верить является ли данный билет счастливым
            (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).*/

            /*Console.WriteLine("Введите номер трамвайного билета (6-значное число)");
            int ticket = int.Parse(Console.ReadLine());

            int firstNumbersSum = (ticket / 100000) + (ticket / 10000 % 10) + (ticket / 1000 % 10);
            int secondNumberSum = (ticket / 100 % 10) + (ticket / 10 % 10) + (ticket % 10);
            if(firstNumbersSum== secondNumberSum)
            {
                Console.WriteLine($"{firstNumbersSum} = {secondNumberSum} | У вас счастливый билет!");
            }
            else
            {
                Console.WriteLine($"{firstNumbersSum} != {secondNumberSum}  | У вас обычный билет");
            }*/




            /*3.Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
            Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы 
            верхнего регистра и наоборот.*/


            /*ConsoleKeyInfo symbol;
            do { 
            Console.WriteLine("Введите символ для конвертации регистра");
            symbol = Console.ReadKey();
            if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
            {
                if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine(" - " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                else
                    {
                        Console.WriteLine(" - " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
            }
 
                if (Convert.ToInt32(symbol.KeyChar) == 27)
                {
                    break;
                }
            } while (true);*/





            /*4.Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, 
                равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:*/

            /*Console.WriteLine("Введите два положительных числа А и В (А<B)");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for(int i =A; i <= B; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }*/





            /* 5.Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. 
                 Например, если было введено число 345, то программа должна вывести число 543.*/

            Console.WriteLine("Введите целое число (>0)");
            string someNumber = Console.ReadLine();
            char[] someNumberArray = someNumber.ToCharArray();
            Array.Reverse(someNumberArray);
            Console.WriteLine(someNumberArray);
            

        }
    }
}
