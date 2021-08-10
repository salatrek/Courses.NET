using System;
using System.ComponentModel;

namespace SixthLesson_INotifyPropertyChanged_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            figure.NumberOfFaces = 5;
            figure.PropertyChanged += ShowProperty;
            figure.NumberOfFaces = 4;


        }

        public static void ShowProperty(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"Свойство: {e.PropertyName} изменилось");
        }
    }
}
