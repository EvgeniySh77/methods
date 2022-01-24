using System;

namespace methods
{
    class Program
    {
        static void Main()
        {             
            (string name, string[] dishes) User;

            Console.Write("Введите свое имя: ");
            User.name = Console.ReadLine();

            User.dishes = new string[5];
            for (int i = 0; i < User.dishes.Length; i++)
            {
                Console.Write($"Введите свое любимое блюдо номер {i + 1}: ");
                User.dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
