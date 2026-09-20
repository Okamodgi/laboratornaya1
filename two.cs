//using System;

//class two
//{
//    static void Main()
//    {
//        string vibor = "1";
//        while (vibor == "1")
//        {
//            const int n = 10;
//            const int minVal = 0;
//            const int maxVal = 99;

//            int[] a = new int[n];
//            Random rnd = new Random();

//            for (int i = 0; i < n; i++)
//                a[i] = rnd.Next(minVal, maxVal + 1);

//            Console.WriteLine($"Массив, заполненный случайными числами от {minVal} до {maxVal}:");
//            foreach (int x in a)
//                Console.Write(x + " ");
//            Console.WriteLine();
//            Console.WriteLine("повторить - 1: ");
//            Console.WriteLine("Выйти из программы - 2: ");
//            vibor = Console.ReadLine();
//            if (vibor != "1" && vibor != "2")
//            {
//                Console.WriteLine("Такого ответа нет!!!!!!!!!!!!!!!!!!!!");

//                Console.WriteLine("повторить - 1: ");
//                Console.WriteLine("Выйти из программы - 2: ");
//                vibor = Console.ReadLine();

//            }
//        }
//    }
//}
