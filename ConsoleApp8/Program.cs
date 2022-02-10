//Описать класс для работы с двумерным массивом целых чисел. Реализовать возможность выполнение операции нахождения остатков от деления всех элементов массива на заданное число.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ConsoleApp8
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите размерность первого массива: ");
                int n = int.Parse(Console.ReadLine());

                Vector V = new Vector(n);

                Console.Write("Исходный первый массив: ");
                V.Show();

                Console.Write("Введите элемент на который будет делиться каждый элемент массива: ");
                int scal = int.Parse(Console.ReadLine());
                V = V % scal;
                V.Show();

Console.Write("Введите размерность второго массива: ");
n = int.Parse(Console.ReadLine());

V = new Vector(n);

Console.Write("Исходный второй массив: ");
V.Show();

Console.Write("Введите элемент на который будет делиться каждый элемент массива: ");
scal = int.Parse(Console.ReadLine());
V = V % scal;
V.Show();
}
}
}
