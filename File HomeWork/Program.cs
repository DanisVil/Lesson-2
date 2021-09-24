using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A1.1");
            Console.WriteLine("Введите секунды:");
            uint seconds = Convert.ToUInt32(Console.ReadLine());
            uint hours = seconds % 86400 / 3600;
            uint minutes = seconds % 3600 / 60;
            uint seconds_left = seconds % 60;
            Console.WriteLine("{0} час(а/ов), {1} минута(а/ы), {2} секунд(а/ы)", hours, minutes, seconds_left);

            Console.WriteLine("A1.2");
            Console.WriteLine("Введите первую сторону прямоугольника:");
            ushort rectangle_a = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            ushort rectangle_b = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата:");
            ushort square_side = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Из прямоугольника можно вырезать {0} квадратов", rectangle_a / square_side * rectangle_b / square_side);

            Console.WriteLine("A1.3");
            Console.WriteLine("Введите кол-во месяцев:");
            ushort delta_month = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine((delta_month + 1) % 12);

            Console.WriteLine("A1.4");
            Console.WriteLine("Введите двузначное число");
            byte two_digit_num = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("{0} десятков, {1} единиц, {2} сумма цифр, {3} произведение", two_digit_num / 10, two_digit_num % 10, two_digit_num / 10 + two_digit_num % 10, (two_digit_num / 10) * (two_digit_num % 10));

            Console.WriteLine("A1.5");
            Console.WriteLine("Введите трёхзначное число:");
            ushort three_digit_num = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(three_digit_num % 100 * 10 + three_digit_num / 100);

            Console.WriteLine("A1.6");
            ushort result = 237;
            Console.WriteLine("Исходное число равно {0}", result % 100 * 10 + result / 100);

            Console.WriteLine("A1.7");
            Console.WriteLine("Введите а2:");
            byte num_of_ten1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите а1:");
            byte num_of_unit1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите b2:");
            byte num_of_ten2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите b1:");
            byte num_of_unit2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Число десятков = {0}, единиц = {1}", num_of_ten1 + num_of_ten2 + (num_of_unit1 + num_of_unit2) / 10, (num_of_unit1 + num_of_unit2) % 10);

            Console.WriteLine("A1.8--");

            Console.WriteLine("A1.9");
            bool a19a = true;
            bool a19b = false;
            bool a19c = false;
            Console.WriteLine("a) {0}\nb) {1}\nc) {2}", a19a || a19b, a19a && a19b, a19b || a19c);

            Console.WriteLine("A1.10");
            Console.WriteLine("a)");
            foreach (bool x in new bool [2] { false, true })
            {
                foreach (bool y in new bool[2] { false, true })
                {
                    foreach (bool z in new bool[2] { false, true })
                    {
                        Console.WriteLine("x: {0}; y: {1}; z: {2}; f: {3}", x, y, z, !(x || y) && (!x || !z));
                    }
                }
            }
            Console.WriteLine("b)");
            foreach (bool x in new bool[2] { false, true })
            {
                foreach (bool y in new bool[2] { false, true })
                {
                    foreach (bool z in new bool[2] { false, true })
                    {
                        Console.WriteLine("x: {0}; y: {1}; z: {2}; f: {3}", x, y, z, !(!x && y) || (x && !z));
                    }
                }
            }
            Console.WriteLine("c)");
            foreach (bool x in new bool[2] { false, true })
            {
                foreach (bool y in new bool[2] { false, true })
                {
                    foreach (bool z in new bool[2] { false, true })
                    {
                        Console.WriteLine("x: {0}; y: {1}; z: {2}; f: {3}", x, y, z, x || !y && !(x || !z));
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
