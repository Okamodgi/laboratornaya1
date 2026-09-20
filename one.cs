//using System;

//class one
//{
//    static void Main()
//    {
//        string vibor = "1";
//        while (vibor == "1")
//        {
//            Console.WriteLine("Введите размер массива: ");
//            string input = Console.ReadLine();
//            int size = int.Parse(input);

//            int[] numbers = new int[size];

//            Random random = new Random();

//            Console.WriteLine("Массив случайных чисел:");

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                numbers[i] = random.Next(0, 100);
//                Console.Write(numbers[i] + " ");
//            }
//            Console.WriteLine();

//            int min = numbers[0];
//            int max = numbers[0];

//            for (int i = 1; i < numbers.Length; i++)
//            {
//                if (numbers[i] < min)
//                {
//                    min = numbers[i];
//                }

//                if (numbers[i] > max)
//                {
//                    max = numbers[i];
//                }
//            }

//            int difference = max - min;

//            Console.WriteLine($"Минимальный элемент: {min}");
//            Console.WriteLine($"Максимальный элемент: {max}");
//            Console.WriteLine($"Разница между max и min: {difference}");

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
