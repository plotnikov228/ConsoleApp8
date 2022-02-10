using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Vector
    {
        int[] a;
        public int n;

        public Vector(int k)
        {
            a = new int[k];
            this.n = k;
            int i = 0;
            int c;

            do
            {
                try
                {
                    Console.Write($"Введите элемент a[{i}]: ");
                    c = int.Parse(Console.ReadLine());
                    a[i] = c;
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введённый элемент имеет неверный формат! ");
                }

            } while (i < k);

        }

        public void Show()
        {
            foreach (int k in a)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
        }


        public static Vector operator %(Vector m1, int m2)
        {

            for (int i = 0; i < m1.n; i++)
            {
                m1.a[i] = m1.a[i] % m2;
            }
            return m1;
        }

        public static Vector operator -(Vector m1, int m2)
        {

            for (int i = 0; i < m1.n; i++)
            {
                m1.a[i] = m1.a[i] - m2;
            }
            return m1;
        }
    }
}

