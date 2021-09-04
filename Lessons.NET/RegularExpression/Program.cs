using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1, 1234, 6000000, 135.25 , 55, 54, 156, 456789, 4";
            string pattern = @"\d{1}";
            string pattern2 = @"\d{4}";
            string pattern3 = @"\d{7}";
            string pattern4 = @"(\d*\.\d{2}?){1}";

            Console.WriteLine($"{Regex.Match(numbers, pattern2)}");

            string url = "https://ya.ru/api?r=1&x=23";
            string urlPattern = @".*\?(((?<param>\w*)=(?<value>\w*))&?)*";
            Console.WriteLine(Regex.IsMatch(url, urlPattern));

            var urlParams = Regex.Matches(url, urlPattern);
            foreach(Match match in urlParams)
            {
                var paramGroup = match.Groups["param"];
                var valueGroup = match.Groups["value"];

                for (int i =0; i < paramGroup.Captures.Count; i++)
                {
                    Console.WriteLine($"param name - {paramGroup.Captures[i]} param value - {valueGroup.Captures[i]}");
                }
            }

            var numberPattern = @"^((\+373|0)\s?)?((77[4-9]\s?)|(\(77[4-9]\)\s?))\d{5}$";

            Console.WriteLine(Regex.IsMatch("77882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("077882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+37377882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0 77882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("778 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0778 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0 778 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0(778)82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0 (778)82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0(778) 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("0 (778) 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373(778)82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373 (778)82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373 (778) 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373 77882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373 778 82344", numberPattern));

            Console.WriteLine(Regex.IsMatch("+373 778 882344", numberPattern));
            Console.WriteLine(Regex.IsMatch("+373 (778 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("373 778 82344", numberPattern));
            Console.WriteLine(Regex.IsMatch("778  82344", numberPattern));

            string text = "Учебный текст  с дублирующимися пробелами  для выполнения  задания.";
            string replacement = " ";
            string textPattern = @"\s{2,}";
            Console.WriteLine(Regex.Replace(text, textPattern, replacement));


        }
    }
}
