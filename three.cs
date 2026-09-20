//using System;

//class three
//{
//    static void Main()
//    {
//        string vibor = "1";
//        while (vibor == "1")
//        {
//            Console.Write("Введите размер массива: ");
//            int n = int.Parse(Console.ReadLine());

//            if (n <= 0)
//            {
//                Console.WriteLine("Размер массива должен быть положительным числом.");
//                return;
//            }

//            int[] a = new int[n];

//            Console.WriteLine($"Введите {n} элементов массива:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}] = ");
//                a[i] = int.Parse(Console.ReadLine());
//            }

//            Console.Write("Введённый массив: ");
//            foreach (int x in a)
//                Console.Write(x + " ");
//            Console.WriteLine();
//            Console.WriteLine("Ввести размер массива заново - 1: ");
//            Console.WriteLine("Выйти из программы - 2: ");
//            vibor = Console.ReadLine();
//            if (vibor != "1" && vibor != "2")
//            {
//                Console.WriteLine("Такого ответа нет!!!!!!!!!!!!!!!!!!!!");

//                Console.WriteLine("Ввести размер массива заново - 1: ");
//                Console.WriteLine("Выйти из программы - 2: ");
//                vibor = Console.ReadLine();

//            }
//        }
//    }
//}