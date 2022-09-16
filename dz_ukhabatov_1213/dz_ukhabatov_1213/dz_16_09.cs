using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ukhabatov_1213
{
    public class dz_16_09
    {
        double counter(double x)
        {
            if (x <= 5)
            {
                var y = (5 - x * 2 / 2);

                Console.WriteLine($"y = {y}, x = {x}");

                return this.counter(x + 0.5);
            }
            else
            {
                return 0;
            }
        }
        public void table_func()
        {
            this.counter(-5);
        }

        public void fibonachi()
        {
            var x = 0;
            var y = 1;
            var z = 0;

            while (y <= 100)
            {
                z = y;
                y = x + y;
                x = z;
                Console.WriteLine(x);
            }
        }

        public int findNumber()
        {
            Console.Write("Найти числа от: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("До: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Ошибка. Первое чило не может быть больше второго!");
                return 0;
            }

            Random r = new Random();
            int c = r.Next(a, b);

            int v;

            do
            {
                v = Convert.ToInt32(Console.ReadLine());
                if (v > c)
                {
                    Console.WriteLine("Заданное число меньше");
                }
                else if (v != c)
                {
                    Console.WriteLine("Заданное число больше");
                }

            } while (v != c);
            Console.WriteLine("Вы угадали число!");
            return 1;
        }
    }
}
