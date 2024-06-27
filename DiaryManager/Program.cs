using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiaryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            int option = 0;

            while (option != 6)
            {
                Console.WriteLine("Which Option Do You Want ?\n1.Reading The Entiar Diary.\n2.Add Enties to Your Diary" +
                "\n3.Delete An Entries.\n4.Counting Numbers Of The Entries.\n5.Read Data For Specific date." +
               "\n6.Exit");
                option = int.Parse(Console.ReadLine());

                // Reading the content of the diary file
                if (option == 1)
                {
                    Console.WriteLine("File content:\n");
                    DailyDiary.ReadAllTextMethod(filepath);
                }
                else
            // Add An Entries
            if (option == 2)
                {
                    Console.WriteLine("Write The date of your content.");
                    string date = Console.ReadLine();
                    Console.WriteLine("Write The your content.");
                    string content = Console.ReadLine();
                    DailyDiary.AddEntries(filepath, new Entry { Date = date }, new Entry {Content= content });
                    DailyDiary.ReadAllTextMethod(filepath);
                }
                else
            // Delete An Entries
            if (option == 3)
                {
                    Console.WriteLine("Write the content you want to Delete");
                    string content = Console.ReadLine();
                    DailyDiary.DeleteEntries(filepath, new Entry { Content = content });
                    DailyDiary.ReadAllTextMethod(filepath);
                }
                else
            //Counting the total number of entries and Display it to the user
            if (option == 4)
                {
                    Console.WriteLine("your Entries Are Numbers Are:");
                    DailyDiary.CountEntries(filepath);
                }
                else
            // Read entries for a specific date 
            if (option == 5)
                {
                    Console.WriteLine("Enter Your Date to get its Entry");
                    string date = Console.ReadLine();
                    DailyDiary.ReadEntriesDate(filepath, new Entry { Date = date });
                }
                else
                if (option > 6)
                {
                    {
                        Console.WriteLine("Choose only from 1-6");
                    }
                }
            }
        }
    }
}
