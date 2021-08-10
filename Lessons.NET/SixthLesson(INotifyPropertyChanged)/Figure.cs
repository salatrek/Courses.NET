using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLesson_INotifyPropertyChanged_
{
    public class Figure : INotifyPropertyChanged
    {
        private int _numberOfFaces;
        public int NumberOfFaces { 
            get => _numberOfFaces;  
            set {
                _numberOfFaces = value;
                NotifyPropertyChanged(nameof(NumberOfFaces)); 
            }
        }

        public float LenghtFace { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
