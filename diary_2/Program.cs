namespace diary_2
{
    internal class Program
    {
        static List<Note> all_note = Notes();

        static void Main(string[] args)
        {
            int position = 1;
            Console.WriteLine("Для записи в дневник нажмите F5");
            DateTime day = DateTime.Now;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (position <= 1)
                        {
                            position = 2;
                        }
                        position--;
                    }

                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (position >= 2)
                        {
                            position = 1;
                        }
                        position++;
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        position = 1;
                        day = day.AddDays(-1);
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        position = 1;
                        day = day.AddDays(+1);
                    }

                    if (key.Key == ConsoleKey.F5)
                    {
                        Console.Clear();
                        Console.WriteLine("Добавление новой записи:");
                        Console.WriteLine("---------------------------------");
                        Add_note();
                    }

                    Console.Clear();
                    Console.WriteLine("Вы выбрали дату: " + day.ToShortDateString());

                    for (int i = 0; i < all_note.Count; i++)
                    {
                        if (all_note[i].Date.Date == day.Date)
                        {
                            Console.WriteLine("  " + all_note[i].Name);
                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                Console.WriteLine(all_note[i].Text);
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine(all_note[i].Info);
                                Console.WriteLine("Дата: " + all_note[i].Date);
                            }
                        }
                    }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
        }

        static List<Note> Notes()
        {
            List<Note> all_note = new List<Note>();

            Note note_two = new Note();
            note_two.Name = "1. День Рождения Лямы";
            note_two.Text = "День Рождения Лямы";
            note_two.Info = "Описание: купить подарок и красиво его упаковать" +
                "\nПоставить себе напоминание";
            note_two.Date = new DateTime(2022, 11, 13);
            all_note.Add(note_two);

            Note note_three = new Note();
            note_three.Name = "1. Геншин";
            note_three.Text = "Поиграть в геншин";
            note_three.Info = "Описание: посмотреть гайды на Розарию и прокачать Тарталью";
            note_three.Date = new DateTime(2022, 11, 09);
            all_note.Add(note_three);

            Note note_four = new Note();
            note_four.Name = "1. Пати";
            note_four.Text = "Пати";
            note_four.Info = "Описание: придумать в чем идити на вечеринку, купить алкоголь, встретить Любу";
            note_four.Date = new DateTime(2022, 11, 12);
            all_note.Add(note_four);

            Note note_five = new Note();
            note_five.Name = "1. Гимнастика";
            note_five.Text = "Гимнастика";
            note_five.Info = "Описание: записать на тренировку, собрать спортивную форму";
            note_five.Date = new DateTime(2022, 11, 10);
            all_note.Add(note_five);

            Note note_six = new Note();
            note_six.Name = "1. С#";
            note_six.Text = "С#";
            note_six.Info = "Описание: выполнить практическую по С# на следующую неделю";
            note_six.Date = new DateTime(2022, 11, 08);
            all_note.Add(note_six);

            return all_note;
        }

        static void Add_note()
        {
            for (int i= 0; i < 1; i++)
            {
                Note my_note = new Note();
                Console.WriteLine("Введите название заметки: ");
                my_note.Name = Console.ReadLine();
                Console.WriteLine("Введите текст заметки: ");
                my_note.Text = Console.ReadLine();
                Console.WriteLine("Введите информацию о заметке: ");
                my_note.Info = Console.ReadLine();
                Console.WriteLine("Введите дату (в формате yyyy, mm, dd): ");
                my_note.Date = Convert.ToDateTime(Console.ReadLine());
                all_note.Add(my_note);

                Console.WriteLine("\n");
            }
        }
    }
}