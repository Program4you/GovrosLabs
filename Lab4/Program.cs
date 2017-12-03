using System;

namespace Lab4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int odd_sum = 0; // сумма нечётных
            int even_sum = 0; // сумма чётных

            for (int x = 1; x <= n; x++)
                if (x % 2 == 0)
                    even_sum += x; // если число чётное, то увеличиваем сумму чётных
                else
                    odd_sum += x; // иначе увеличиваем сумму нечётных

            Console.WriteLine("Сумма нечётных чисел от 1 до {0} равна {1}", n, odd_sum);
            Console.WriteLine("Сумма чётных чисел от 2 до {0} равна {1}", n, even_sum);
            Console.ReadKey();
        }
    }
}
