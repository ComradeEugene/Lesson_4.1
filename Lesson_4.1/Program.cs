using System;

namespace Lesson_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Sum = 0;
            Random RandomNum = new Random();

            Console.WriteLine("Введите количество строк");
            int Lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            int Columns = int.Parse(Console.ReadLine());

            int[,] arr = new int[Lines, Columns];
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    arr[i, j] = RandomNum.Next(100);
                    Sum += arr[i, j];
                }
            }
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{arr[i, j], 5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов: {Sum}");
            Console.ReadKey();
        }
    }
}