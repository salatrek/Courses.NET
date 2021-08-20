using System;
using System.IO;
using System.Reflection;

namespace NinethLesson_Reflection_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Курсы.NET\Courses.NET\SupportingProject\SupportingProject\bin\Debug\net5.0\SupportingProject.dll";

            Type myType = typeof(Figure);
            var myProperties = myType.GetProperties();
            var myMethods = myType.GetMethods(BindingFlags.Public);

            var triangle = new Figure() { Name = "Triangle", SideCount = 3, SideLenght = 2};
            var myType2 = triangle.GetType();

            var myType3 = Type.GetType("NinethLesson_Reflection_.Figure", false, true);
            Figure figure = (Figure)Activator.CreateInstance(myType3);
            figure.Display("треугольник");

            DisplayInfo(triangle);

            Assembly assembly = Assembly.LoadFrom(path);
            Type type = assembly.GetType("SupportingProject.DisplayClass", true, true);
            var obj = Activator.CreateInstance(type);

            var method = type.GetMethod("Display");
            object result = method.Invoke(obj, new object[] { "Name-reflection"});
            Console.WriteLine(result);

            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("\nFields   ***");
            foreach (var item in fields)
            {
                Console.WriteLine($"{item.Name}\t{item.GetValue(obj)}");
            }

            PropertyInfo[] properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("\nProperties   ***");
            foreach (var item in properties)
            {
                Console.WriteLine($"{item.Name}\t{item.GetValue(obj)}");
            }

            Console.WriteLine("\nConstructor  ***");
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            foreach (var item in constructorInfo)
            {
                var example = item.Invoke(null);
                Type constructorType = example.GetType();
                var constructorMethod = constructorType.GetMethod("Display");
                object constructorResult = constructorMethod.Invoke(example, new object[] { "example method" });
                Console.WriteLine(constructorResult);
            }
        }

        private static void DisplayInfo<T>(T obj)
        {
            var myType = obj.GetType();
            var properties = myType.GetProperties();
            foreach (var property in properties)
            {
                var t = property.GetValue(obj);
            }
        }
    }
}
