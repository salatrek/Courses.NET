using System;

namespace SecondLesson_ValueType_
{
    public class Figure
    {
        public float NumbersOfFaces { get; set; }
        public float FaceLength { get; set; }
        public float FigureArea { get; set; }

        public Figure(float _numbersOfFaces, float _faceLength)
        {
            if (_numbersOfFaces > 0 && _faceLength > 0)
            {
                NumbersOfFaces = _numbersOfFaces;
                FaceLength = _faceLength;
            }
            else 
            {
                throw new ArgumentException("Фигуры с такими параметрами не существует");
            }
        }
    }
}
