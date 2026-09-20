//using System;

//class four
//{
//    static void Main()
//    {
//        string vibor = "1";
//        while (vibor == "1")
//        {
//            Random random = new Random();
//            Console.Write("Введите количество строк: ");
//            string rowsInput = Console.ReadLine();
//            if (!int.TryParse(rowsInput, out int rows) || rows <= 0)
//            {
//                Console.WriteLine("Некорректное количество строк. Программа завершает работу.");
//                break;
//            }

//            Console.Write("Введите количество столбцов: ");
//            string colsInput = Console.ReadLine();
//            if (!int.TryParse(colsInput, out int cols) || cols <= 0)
//            {
//                Console.WriteLine("Некорректное количество столбцов. Программа завершает работу.");
//                break;
//            }
//            int[,] a = new int[rows, cols];

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    a[i, j] = random.Next(0, 100);
//                }
//            }

//            Console.WriteLine($"Исходная матрица ({rows} x {cols}):");
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                    Console.Write(a[i, j].ToString().PadLeft(4));
//                Console.WriteLine();
//            }

//            Console.WriteLine();
//            Console.WriteLine("Суммы по строкам:");
//            for (int i = 0; i < rows; i++)
//            {
//                int rowSum = 0;
//                for (int j = 0; j < cols; j++)
//                    rowSum += a[i, j];
//                Console.WriteLine($"Сумма строки {i}: {rowSum}");
//            }

//            Console.WriteLine();
//            Console.WriteLine("Суммы по столбцам:");
//            for (int j = 0; j < cols; j++)
//            {
//                int colSum = 0;
//                for (int i = 0; i < rows; i++)
//                    colSum += a[i, j];
//                Console.WriteLine($"Сумма столбца {j}: {colSum}");
//            }


//            for (int j = 0; j < cols; j++)
//            {
//                for (int pass = 0; pass < rows - 1; pass++)
//                {
//                    bool swapped = false;
//                    for (int i = 0; i < rows - 1 - pass; i++)
//                    {
//                        if (a[i, j] > a[i + 1, j])
//                        {
//                            int temp = a[i, j];
//                            a[i, j] = a[i + 1, j];
//                            a[i + 1, j] = temp;
//                            swapped = true;
//                        }
//                    }
//                    if (!swapped) break; 
//                }
//            }

//            Console.WriteLine("\nМатрица после сортировки столбцов:");
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                    Console.Write(a[i, j].ToString().PadLeft(4));
//                Console.WriteLine();
//            }


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
////задать размер, сортировка стобцов