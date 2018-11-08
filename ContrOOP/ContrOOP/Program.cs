using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrOOP //Вариант 2 
{
    //Задание 2 
    class Time
    {
        public const int Hours = 17;
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time() { }
        public Time(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Minutes < t2.Minutes) return true;
            if (t1.Minutes == t2.Minutes)
            {
                if (t1.Seconds < t2.Seconds) return true;
            }
            else { return false; }
            return false;
        }

        public static bool operator >(Time t1, Time t2)
        {
            if (t1.Minutes > t2.Minutes) return true;
            if (t1.Minutes == t2.Minutes)
            {
                if (t1.Seconds > t2.Seconds) return true;
            }
            else { return false; }
            return false;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (t1.Minutes == t2.Minutes && t1.Seconds == t2.Seconds) return true;
            return false;
        }
        public static bool operator !=(Time t1, Time t2)
        {
            if (t1.Minutes != t2.Minutes && t1.Seconds != t2.Seconds) return true;
            return false;
        }
    }

    //Задание 3 
    interface IStudy
    {
        void Study();
    }

    class Student : IStudy
    {
        public void Study()
        {
            Console.WriteLine("Учусь");
        }
    }

    class Prepod : Student, IStudy
    {
        void IStudy.Study()
        {
            Console.WriteLine("Учу");
        }
    }

    class Program
    {
        static void Main()
        {
            //Задание 1А 
            Console.WriteLine(Double.MinValue);
            //Задание 1Б 
            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine(s1 + s2);
            //Задание 1В 
            int[][] jaggedArray = { new int[3], new int[5] };
            for (int i = 0; i < 3; i++)
            {
                jaggedArray[0][i] = 1;
            }
            for (int i = 0; i < 5; i++)
            {
                jaggedArray[1][i] = 2;
            }
            Console.WriteLine("Ступенчатый массив выглядит так:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t" + jaggedArray[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t" + jaggedArray[1][i] + " ");
            }
            Console.WriteLine();


            //Задание 2 
            Time today = new Time(20, 30);
            Time yesterday = new Time(20, 40);
            Console.WriteLine(today < yesterday); //вернет true, т.к. секунды у первого объекта меньше, чем у второго 
                                                  //хоть время и одинаковое 
            Time alsoToday = new Time(20, 30);
            Console.WriteLine();
            Console.WriteLine(today == alsoToday); //true, т.к. значения полей 2ух обхектов равны 
            Console.WriteLine(today == yesterday); //false, т.к. значения полей 2ух обхектов не равны 
            Console.WriteLine();

            //Задание 3 
            IStudy Sasha = new Student();
            IStudy Nikita = new Prepod();
            Sasha.Study(); //вызываем метод студента 
            ((Prepod)Nikita).Study(); //метод, наследованный от Student 
            Nikita.Study(); //реализованный через интерфейс 
        }
    }
}