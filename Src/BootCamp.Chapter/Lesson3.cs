using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string PrintString(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            return name;
        }
        public static int PrintInt(string message)
        {
            Console.Write(message);
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public static float PrintFloat(string message)
        {
            Console.Write(message);
            float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return x;
        }
        public static float CalculateBMI(float w, float h)
        {
            var bmi = w / h / h;
            return bmi;
        }
        public static string PorsonInfo(string name, string surename, int age,
            float weight, float height)
        {
            string info = name + " " + surename + " is " + age + " years old, his weight is "
                + weight + "kg and his height is " + height + "m.";
            return info;
        }
        public static void Demo()
        {
            string name = PrintString("Enrer your name: ");
            string surename = PrintString("Enter your surename: ");
            int age = PrintInt("Enter your age: ");
            float weight = PrintFloat("Enter your weight: ");
            float height = PrintFloat("Enter your height: ");
            Console.WriteLine(PorsonInfo(name, surename, age, weight, height));
            Console.WriteLine("BMI is: " + CalculateBMI(weight, height));
        }
    }
}
