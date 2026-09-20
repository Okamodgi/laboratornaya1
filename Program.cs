using System;

struct Student
{
    public string Famil;
    public string Name;
    public string Facult;
    public int Nomzach;
}

class five
{
    static void Main()
    {
        string vibor = "1";
        while (vibor == "1")
        {
            Console.WriteLine("Введите кол-во студентов: ");
            string input = Console.ReadLine();
            int nStud = int.Parse(input);

            Student[] stud = new Student[nStud];
            for (int i = 0; i < nStud; i++)
            {
                Console.WriteLine($"Введите фамилию студента {i + 1}");
                stud[i].Famil = Console.ReadLine();

                Console.WriteLine($"Введите имя студента {stud[i].Famil}");
                stud[i].Name = Console.ReadLine();

                Console.WriteLine($"Введите название факультета студента {stud[i].Famil} {stud[i].Name}");
                stud[i].Facult = Console.ReadLine();

                Console.WriteLine($"Введите номер зачётной книжки студента {stud[i].Famil} {stud[i].Name}");
                stud[i].Nomzach = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nСписок студентов:");
            foreach (Student s in stud)
            {
                Console.WriteLine($"Студент {s.Famil} {s.Name} обучается на факультете {s.Facult}, " +
                                   $"номер зачётной книжки {s.Nomzach}");
            }

            string vibor2 = "3";
            while (vibor2 == "3")
            {

                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 — поиск студента");
                Console.WriteLine("2 — удаление студента");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    Console.Write("\nВведите фамилию для поиска: ");
                    string searchFamil = Console.ReadLine();
                    Console.Write("Введите имя для поиска: ");
                    string searchName = Console.ReadLine();

                    bool found = false;
                    foreach (Student s in stud)
                    {
                        if (s.Famil == searchFamil && s.Name == searchName)
                        {
                            Console.WriteLine($"\nНайден студент: {s.Famil} {s.Name}, факультет {s.Facult}, " +
                                               $"номер зачётной книжки {s.Nomzach}");
                            found = true;
                            break;
                        }
                        {

                            if (!found)
                                Console.WriteLine($"\nСтудент с фамилией \"{searchFamil}\" и именем \"{searchName}\" не найден.");
                            vibor2 = Console.ReadLine();
                        }
                    }
                }
                else if (action == "2")
                {
                    Console.Write("\nВведите фамилию студента для удаления: ");
                    string delFamil = Console.ReadLine();
                    Console.Write("Введите имя студента для удаления: ");
                    string delName = Console.ReadLine();

                    int delIndex = -1;
                    for (int i = 0; i < stud.Length; i++)
                    {
                        if (stud[i].Famil == delFamil && stud[i].Name == delName)
                        {
                            delIndex = i;
                            break;
                        }
                    }

                    if (delIndex == -1)
                    {
                        Console.WriteLine($"\nСтудент с фамилией \"{delFamil}\" и именем \"{delName}\" не найден.");
                    }
                    else
                    {
                        Student[] newStud = new Student[stud.Length - 1];
                        int j = 0;
                        for (int i = 0; i < stud.Length; i++)
                        {
                            if (i != delIndex)
                            {
                                newStud[j] = stud[i];
                                j++;
                            }
                        }
                        stud = newStud;

                        Console.WriteLine($"\nСтудент {delFamil} {delName} удалён.");
                        Console.WriteLine("\nОбновлённый список студентов:");
                        foreach (Student s in stud)
                        {
                            Console.WriteLine($"Студент {s.Famil} {s.Name} обучается на факультете {s.Facult}, " +
                                               $"номер зачётной книжки {s.Nomzach}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор действия.");
                }
                Console.WriteLine("Хотите повторить операции?");
                Console.WriteLine("Да - 3, Нет - любое число");
                vibor2 = Console.ReadLine();
            }

            Console.WriteLine("повторить заполнение - 1: ");
            Console.WriteLine("Выйти из программы - 2: ");
            vibor = Console.ReadLine();
            if (vibor != "1" && vibor != "2")
            {
                Console.WriteLine("Такого ответа нет!!!!!!!!!!!!!!!!!!!!");

                Console.WriteLine("повторить - 1: ");
                Console.WriteLine("Выйти из программы - 2: ");
                vibor = Console.ReadLine();

            }
        }
    }
}
//динамический размер, поиск и удаление из списка дубликатов