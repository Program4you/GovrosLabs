using System;

namespace Lab5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            int odd_sum = 0; // сумма нечётных
            int even_sum = 0; // сумма чётных

            for (int x = a; x <= b; x++)
                if (x % 2 == 0)
                    even_sum += x; // если число чётное, то увеличиваем сумму чётных
                else
                    odd_sum += x; // иначе увеличиваем сумму нечётных

            Console.WriteLine("Сумма нечётных чисел в интервале [{0}, {1}] равна {2}", a, b, odd_sum);
            Console.WriteLine("Сумма чётных чисел в интервале [{0}, {1}] равна {2}", a, b, even_sum);
            Console.ReadKey();
        }
    }
}
