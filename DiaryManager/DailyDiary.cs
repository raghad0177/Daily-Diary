using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    public class DailyDiary
    {
       
        // Reading All file context 
        public static string ReadAllTextMethod(string filepathParam)
        {
            string txtContent = File.ReadAllText(filepathParam);
            return txtContent;
        }



        // Add Entries to file With Its Date and Content
        public static string[] AddEntries(string filepath, Entry date, Entry mynewLine)
        {
            if (DateTime.TryParseExact(date.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate))
            {
                string formattedDate = parsedDate.ToString("yyyy-MM-dd");
                string contentToAdd = $"\n{formattedDate}\n{mynewLine.Content}";
                File.AppendAllText(filepath, contentToAdd);
                string[] txtContent = File.ReadAllLines(filepath);
                return txtContent;
            }
            else
            {
               return new string[0];
            }
        }



        // Deleting specific entries Accourding to user Input
        public static void DeleteEntries(string filepath, Entry entries) {

            string text = File.ReadAllText(filepath);
            text = text.Replace(entries.Content, "");
            File.WriteAllText(filepath, text);
        }



        // Counting the total number of Lines and Display it to the user 
        public static void CountEntries(string filepath)
        {
            string[] fileContent = File.ReadAllLines(filepath);
            int counter = 0;
            foreach (string entries in fileContent)
            {
                counter++;
            }
            Console.WriteLine($"Numbers Of Entries Are : {counter}");

        }
    



    // Read entries for a specific date 
    public static void ReadEntriesDate(string filepath, Entry date)
    {
        if (DateTime.TryParseExact(date.Date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
                string formattedDate = parsedDate.ToString("yyyy-MM-dd");
                string[] fileContent = File.ReadAllLines(filepath);

            for (int i = 0; i < fileContent.Length; i++)
            {
                if (fileContent[i] == formattedDate)
                {
                    Console.WriteLine(fileContent[i + 1]);
                }
            }
        }
        }
    }
}


