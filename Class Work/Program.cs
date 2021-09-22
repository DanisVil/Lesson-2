using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            Console.WriteLine("{0} <= sbyte <= {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0} <= byte <= {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} <= short <= {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("{0} <= ushort <= {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0} <= int <= {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} <= uint <= {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0} <= long <= {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("{0} <= ulong <= {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0} <= float <= {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} <= double <= {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("{0} <= decimal <= {1}", decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("task2");
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой город:");
            string city = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите свой PIN-код:");
            ushort pincode = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Ваше имя - {0}, город - {1}, возраст - {2}, PIN-код - {3}", name, city, age, pincode);

            Console.WriteLine("task3");
            Console.WriteLine("Введите строку");
            string inverse = Console.ReadLine();
            if (Char.IsLower(inverse[0]))
            {
                Console.WriteLine(inverse.ToUpper());
            }
            else
            {
                Console.WriteLine(inverse.ToLower());
            }

            Console.WriteLine("task4");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string side_str = Console.ReadLine();
            int contain_count = 0;
            for (int i = 0; i <= str.Length - side_str.Length; i++)
            {
                if (str.Substring(i, side_str.Length) == side_str)
                {
                    contain_count++;
                }
            }
            Console.WriteLine(contain_count);

            Console.WriteLine("task5");
            Console.WriteLine("Введите скорость таракана в км/ч :");
            float cockroach_speed = (float)Math.Floor(250 * Convert.ToSingle(Console.ReadLine()) / 9);
            Console.WriteLine("Скорость таракана в см/с: {0}", cockroach_speed);

            Console.WriteLine("task6");
            Console.WriteLine("Введите возраст отца:");
            int father_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст сына:");
            int son_age = Convert.ToInt32(Console.ReadLine());
            int bauble = SomeScamFunction(father_age, son_age);

            Console.WriteLine("task7");
            Console.WriteLine("Введите цену бутылку:");
            int norm_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку:");
            int sale_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            int holiday_price = Convert.ToInt32(Console.ReadLine());
            int bottle_count = (int) Math.Floor((float) 100 * holiday_price / (norm_price * sale_price));
            Console.WriteLine("Нужно купить {0} бутылку(и/ок)", bottle_count);

            Console.ReadKey();
        }
        static int SomeScamFunction(int father_age, int son_age)
        {
            int n = father_age - 2 * son_age;
            if (n < 0)
            {
                Console.WriteLine("Отец был вдвое старше сына {0} год(а)(лет) назад", Math.Abs(n));
            }
            if (n > 0)
            {
                Console.WriteLine("Отец будет вдвое старше сына через {0} год(а)(лет)", Math.Abs(n));
            }
            if (n == 0)
            {
                Console.WriteLine("Отец вдвое старше сына");
            }
            return Math.Abs(n);
        }
    }
}
