using System;

namespace Lab3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int x = a; x <= b; x++)
                sum += x;

            Console.WriteLine("Сумма чисел в интвервале [{0}, {1}] равна {2}", a, b, sum);
            Console.ReadKey();
        }
    }
}
