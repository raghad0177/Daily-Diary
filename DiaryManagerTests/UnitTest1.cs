using DiaryManager;

namespace DiaryManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReadDiaryFileTest() 
        {
            // Arrange 
            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            
            // Act
            string ExpectedContent= DiaryManager.DailyDiary.ReadAllTextMethod(filepath);

            // Assert
            string actualContent = File.ReadAllText(filepath);
            Assert.Equal(ExpectedContent, actualContent);
        }
           
        [Fact]
        public void AddToDiaryFileTest()
        {
           
            // Arrange 
            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            int actualContent = File.ReadAllLines(filepath).Length;
            Entry add = new Entry { Date = "2023-06-11", Content = "New Line" };

            // Act
            string[] ExpectedContent = DiaryManager.DailyDiary.AddEntries(filepath, add, add);

            // Assert
            int ExpectedContentResult = ExpectedContent.Length;
            int finalLineCount = File.ReadAllLines(filepath).Length;

            Assert.True(finalLineCount > actualContent);
        }
    }
}