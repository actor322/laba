using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace _1zadanie
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool alive = true;
//            int a = 10;
//            double b = 10.5;
//            char c = 'C';
//            string d = "Alya";
//            Console.WriteLine(alive);
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(d);
//            Console.ReadKey();
//        }

//    }
//}
//namespace _2zadanie
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 150;
//            byte x = 15;
//            short y = x;
//            short z = 11;
//            int q = z;
//            long b = i;
//            float c = 1.8f;
//            double d = c;
//            ushort r = 37;
//            uint o = r;
//            Console.WriteLine("Неявные приведения:");//не теряется информация
//            Console.WriteLine("Ushort = {0} Uint = {1}", r, o);
//            Console.WriteLine("Short = {0} Int = {1}", z, q);
//            Console.WriteLine("Byte = {0} Short = {1}", x, y);
//            Console.WriteLine("Int = {0} Long = {1}", i, b);
//            Console.WriteLine("Float = {0} Double = {1}", c, d);
//            short s = 45;
//            byte w = (byte)s;
//            double doubleData = 245.45567;
//            int intData = (int)doubleData;
//            float floatData = (float)doubleData;
//            short p = (short)i;
//            int l = (int)b;
//            Console.WriteLine("Явные приведения:");
//            Console.WriteLine("Long = {0} Int = {1}", b, l);
//            Console.WriteLine("Int = {0} Short = {1}", i, p);
//            Console.WriteLine("Short = {0} Byte = {1}", s, w);
//            Console.WriteLine("Double = {0} Int = {1}", doubleData, intData);
//            Console.WriteLine("Double = {0} Float = {1}", doubleData, floatData);
//            Console.ReadKey();
//        }
//    }
//}
//namespace _3zadanie
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int y = 123;
//            object o = y;//ссылка в куче
//            Console.WriteLine(y);
//            // Упаковка i.
//            o = 125;
//            y = (int)o;
//            Console.WriteLine(o);
//            //Распаковка.

//            //Работа с неявно типизированной переменной.
//            int x = 1;
//            var i = 0.5;
//            var result = x + i;
//            Console.WriteLine(result);


//            //nullable переменная.
//            int? z = 7;
//            if (z.HasValue)
//            {
//                Console.WriteLine(z.Value);
//            }
//            else
//            {
//                Console.WriteLine("z is equal to null");
//            }
//            int? w = null;

//            if (w.HasValue)
//            {
//                Console.WriteLine(w.Value);
//            }
//            else
//            {
//                Console.WriteLine("w is equal to null");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _4zadanie
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string str1 = " Hello";
//            string str2 = "Hello, world!";
//            bool result = str1.Equals(str2);
//            Console.WriteLine(result);

//            string str3 = "Hello,";
//            string str4 = " world";
//            string str5 = "!";
//            string str6 = str3 + " " + str4;
//            string str7 = String.Concat(str6, str5);
//            Console.WriteLine(str7);


//            string text = "так произошло";

//            string[] words = text.Split(new char[] { ' ' });

//            foreach (string s in words)
//            {
//                Console.WriteLine(s);
//            }


//            str2 = str2.Insert(6, str1);
//            Console.WriteLine(str2);

//            str2 = str2.Remove(6, 6);
//            Console.WriteLine(str2);


//            string empty = "";
//            string nullString = null;
//            if (String.IsNullOrEmpty(empty))
//            {
//                Console.WriteLine("is null or empty");
//            }
//            bool result2 = empty.Equals(nullString);
//            Console.WriteLine(result2);


//            StringBuilder sb = new StringBuilder("ривеет мир");
//            Console.WriteLine(sb);
//            sb.Insert(0, "П");
//            sb.Insert(11, "!");
//            sb.Remove(4, 1);
//            Console.WriteLine(sb);
//            Console.ReadKey();
//        }
//    }
//}
//namespace massiv1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//            int rows = mas.GetUpperBound(0) + 1;
//            int columns = mas.Length / rows;
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < columns; j++)
//                {
//                    Console.Write($"{mas[i, j]} \t");
//                }
//                Console.WriteLine();

//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace massiv2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] mas = { "first", "second", "third" };
//            int length = mas.Length;
//            for (int i = 0; i < length; ++i)
//            {
//                if (i == 2)
//                {
//                    mas[i] = "not second";
//                }
//            }
//            Console.WriteLine();
//            for (int i = 0; i < length; ++i)
//            {
//                Console.WriteLine(mas[i]);
//            }
//            Console.WriteLine();
//            Console.WriteLine("Длинна массива : {0}", length);
//            Console.ReadKey();
//        }
//    }
//}
//namespace massiv3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[][] mas = new int[3][];
//            mas[0] = new int[2] { 1, 2 };
//            mas[1] = new int[3] { 1, 2, 3 };
//            mas[2] = new int[4] { 1, 2, 3, 4 };
//            for (int i = 0; i < mas.Length; i++)
//            {
//                for (int j = 0; j < mas[i].Length; j++)
//                {
//                    Console.Write($"{mas[i][j]} \t");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            var varMas = new[] { 1, 2, 3, 4, 5 };
//            for (int k = 1; k <= varMas.Length; k++)
//            {
//                Console.WriteLine(k);
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace kortej1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            (int age, string name, char sex, string surname, ulong dateOfBirth) tuple = (20, "Rosti", 'w', "Slave", 26_08_2001);
//            Console.WriteLine(tuple);
//            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст:{2};", tuple.name, tuple.surname, tuple.age);


//            (int a, int b) t1 = (1, 42);
//            (int c, double d) t2 = (1, 42);
//            (int c, double d) t4 = (1, 42);
//            (int a, int b) t3 = (2, 41);
//            Console.WriteLine(t1.CompareTo(t3));
//            Console.WriteLine(t4.CompareTo(t2));


//            (string first, string middle, string last) = ("one", "two", "three");
//            Console.WriteLine($"{first}, {middle}, {last}");
//            Console.ReadKey();
//        }

//    }
//}
namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 4, 1, 2, 5 };
            string s = "Hello";
            var tuple = GetValues(a, s);
            Console.WriteLine($"Максимальный элемент: {tuple.Max}");
            Console.WriteLine($"Минимальный элемент: {tuple.Min}");
            Console.WriteLine($"Сумма элементов: {tuple.Sum}");
            Console.WriteLine($"Первый символ строки: {tuple.First}");
            Console.ReadKey();
        }
        private static (int Max, int Min, int Sum, string First) GetValues(int[] a, string s)
        {

            var result = (Max: a[0], Min: a[0], Sum: 0, First: "");
            result.First = s.Remove(1);
            for (int i = 0; i < a.Length; i++)
            {
                result.Sum += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Max < a[i])
                {
                    result.Max = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Min > a[i])
                {
                    result.Min = a[i];
                }
            }
            return result;

        }

    }


}