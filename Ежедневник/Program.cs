using System.Runtime.Intrinsics.X86;

namespace Diary
{
    internal class Program
    {
        static DateTime dota = DateTime.Now;
        static void Main(string[] args)
        {
            int position = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.Write("Выбрана дата: " + dota.ToShortDateString() + "\n");
                Menu();
                Arrow(position);
                position = Arrow(position);
                Dela(position);
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Q);
        }
        static void Data(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(0, 0);
                dota = dota.AddDays(-1);
                Console.Clear() ;   
                Console.Write("Выбрана дата: " + dota.ToShortDateString() + "\n");
                Menu();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(0, 0);
                dota = dota.AddDays(+1);
                Console.Clear();
                Console.Write("Выбрана дата: " + dota.ToShortDateString() + "\n");
                Menu();
            }
        }

        static int Arrow(int position)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine(">");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                        position = 3;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 4)
                        position = 1;
                }
                Data(key);
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
        static void Dela(int position1)
        {
            if (position1 == 1 && dota.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Console.WriteLine("Отчислится из мпт "); 
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: я устал.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 2 && dota.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Console.WriteLine("Сходить в дурку ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: После мпт меня туда примут.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 3 && dota.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Console.WriteLine("Перестать жить эту жизнь");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Денег на мыло не хватило. В россии всё делают для граждан");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 1 && dota.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine("Понять что жизнь тлен ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: я  опять устал.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 2 && dota.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine("Сходить к психотерапевту ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Может быть он мне поможет.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 3 && dota.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine("Восстановиться ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Вроде как он мне помог.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 1 && dota.Date == new DateTime(2023, 10, 20))
            {
                Console.Clear();
                Console.WriteLine(" Начать воздоровительную терапию ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Надо восстанавливать псих здоровье.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 2 && dota.Date == new DateTime(2023, 10, 20))
            {
                Console.Clear();
                Console.WriteLine("Вылечиться ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: мне стало легче.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 1 && dota.Date == new DateTime(2023, 10, 20))
            {
                Console.Clear();
                Console.WriteLine("Восстановить общение с близкими ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: близкие всегда поддержат.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 1 && dota.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine(" Понять что всё это бесполезно");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Всё это было зря.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 2 && dota.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine("Купить верёвку и мыло\" ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание:Наконец - то накопил деньги на действительно стоющую покупку.");
                Console.WriteLine($"\nДата: " + dota);
            }
            else if (position1 == 1 && dota.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine("Приготовить луковый угар ");
                Console.WriteLine("\n------------------");
                Console.WriteLine("\nОписание: Только он спасёт меня.");
                Console.WriteLine($"\nДата: " + dota);
            }




        }

        static void Menu()
        {
            if (dota.Date == new DateTime(2023, 10, 18))
            {
                Console.WriteLine("  1. Отчислится");
                Console.WriteLine("  2. Сходить в дурку");
                Console.WriteLine("  3. Перестать жить эту жизнь");
            }
            else if (dota.Date == new DateTime(2023, 10, 19))
            {
                Console.WriteLine("  1. Понять что жизнь тлен");
                Console.WriteLine("  2. Сходить к психотерапевту ");
                Console.WriteLine("  3. Восстановиться ");
            }
            else if (dota.Date == new DateTime(2023, 10, 20))
            {
                Console.WriteLine("  1. Начать воздоровительную терапию");
                Console.WriteLine("  2. Вылечиться ");
                Console.WriteLine("  3. Восстановить общение с близкими");
            }
            else if (dota.Date == new DateTime(2023, 10, 21))
            {
                Console.WriteLine("  1. Понять что всё это бесполезно");
                Console.WriteLine("  2. Купить верёвку и мыло");
                Console.WriteLine("  3. Приготовить луковый угар ");
            }
        }
    }
}