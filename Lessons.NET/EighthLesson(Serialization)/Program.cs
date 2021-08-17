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

            var account = new Account() { AccountBalance = 700, TypeOfCurrency = new Currency() { Rate = 78.6f } };

            var serAccount = JsonConvert.SerializeObject(account);

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

        public static void XMLDeserialeze(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Figure>));

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Deserialize(fileStream);
            }
        }

        public static void BinarySerialize(List<Figure> figlist)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, figlist);
            }
        }

        public static void BinaryDeserialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("figures.xml", FileMode.OpenOrCreate))
            {
                binaryFormatter.Deserialize(fileStream);
            }
        }
    }
}
