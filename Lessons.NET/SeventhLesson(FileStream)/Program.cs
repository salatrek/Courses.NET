using System;
using System.IO;

namespace SeventhLesson_FileStream_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("D:", "Курсы.NET", "Courses.NET", "Lessons.NET", "SeventhLesson(FileStream)", "TestFiles");
            
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            Console.WriteLine("Введите текст:");
            var text = Console.ReadLine();

            using (FileStream fileStream = new FileStream($"{path}\\test.txt", FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fileStream.Write(array, 0, array.Length);
            }

            using (FileStream fileStream = new FileStream($"{path}\\test.txt", FileMode.Open))
            {
                byte[] array = new byte[fileStream.Length];
                fileStream.Read(array);

                string readText = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Прочитанный текст: {readText}");
            }
        }
    }
}
