using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace EighthLesson_Serialization_
{
    class Program
    {
        static void Main(string[] args)
        {
            var Triangle = new Figure() { Name = "Triangle", SideCount = 3, SideLenght = 1 };
            List<Figure> figlist = new List<Figure>() { Triangle, Triangle, Triangle };
            List<Figure> xmlFigure = new List<Figure>();
            List<Figure> binFigure = new List<Figure>();

            Person person = new Person() { Name = "Alex", Age = 18 };
            person.NextPerson = person;


            try
            {
                var serPerson = JsonConvert.SerializeObject(person);
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Triangle triangle = new Triangle() { Name = "Triangle", SideCount = 3, SideLenght = 2, Area = 5 };

            XMLSerialize(figlist);
            BinarySerialize(figlist);

            XMLSerializeTest(triangle);

            xmlFigure = XMLDeserialeze("figures.xml");
            binFigure = BinaryDeserialize("figures.dat");

        }
        public static string JSonSerialize(List<Figure> figlist)
        {
            return JsonConvert.SerializeObject(figlist);
        }

        public static List<Figure> JSonDeserialeze(string serializedList)
        {
            return JsonConvert.DeserializeObject<List<Figure>>(serializedList);
        }

        public static void XMLSerialize(List<Figure> figlist)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(figlist.GetType());

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, figlist);
            }
        }

        public static List<Figure> XMLDeserialeze(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Figure>));

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                return (List<Figure>)xmlSerializer.Deserialize(fileStream);

            }
        }

        public static void BinarySerialize(List<Figure> figlist)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("figures.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, figlist);
            }
        }

        public static List<Figure> BinaryDeserialize(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (List<Figure>)binaryFormatter.Deserialize(fileStream);
            }
        }

        public static void XMLSerializeTest(Figure figure)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(figure.GetType());

            using (FileStream fileStream = new FileStream("figure.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, figure);
            }
        }

        public static Figure XMLDeserialezeTest(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Figure));

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                return (Figure)xmlSerializer.Deserialize(fileStream);

            }
        }
    }
}
