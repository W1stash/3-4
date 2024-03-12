using System;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину одномерного массива: ");
            int i = int.Parse(Console.ReadLine());
            OneDimension array1 = new OneDimension(i);
            ((IArray)array1).Init();
            Console.WriteLine("Вывод:");
            ((IArray)array1).Print();

            Console.WriteLine();

            Console.Write("Введите длину двумерного массива: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов двумерного массива: ");
            int b = int.Parse(Console.ReadLine());
            TwoDimension array2 = new TwoDimension(a, b);
            ((IArray)array2).Init();
            Console.WriteLine("Вывод:");
            ((IArray)array2).Print();

            Console.ReadKey();
        }
    }
}
