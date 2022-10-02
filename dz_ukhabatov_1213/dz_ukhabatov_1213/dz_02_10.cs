using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ukhabatov_1213
{
    internal class dz_02_10
    {
        public void zadanie_1()
        {
            int[] numbers = new int[10];
            var r = new Random();
            int a = 1;
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numbers.Length; i++)
                numbers[i] = r.Next(50, 100);

            for(int i = 0; i < numbers.Length; i++)
                if(i < n)
                    a *= numbers[i];

            Console.WriteLine(a);
        }

        public void zadanie_2()
        {
            int[] numbers = new int[10];
            var r = new Random();
            int a = 1;

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = r.Next(5, 500);

            for (int i = 0; i < numbers.Length; i++)
                if (i % 3 == 0 && i % 6 != 0)
                    a *= numbers[i];

            Console.WriteLine(a);
        }
    }
}
