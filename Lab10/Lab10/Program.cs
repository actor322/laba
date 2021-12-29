using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    interface IMyInterface
    {
        string MyFunc();
    }

    interface IAnotherInterface
    {
        string ToString();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Student student = new Student("name", "2");//создали
            Dictionary<double, double> dictionary = new Dictionary<double, double>();
            Dictionary<double, Flower> TabletDictionary = new Dictionary<double, Flower>();
            Queue<double> queue = new Queue<double>();//создали 2д
            Queue<Flower> TabletQueue = new Queue<Flower>();
            Flower[] arr = new Flower[5];
            ObservableCollection<Flower> tablets = new ObservableCollection<Flower>();//4
            tablets.CollectionChanged += StaticClass.method;//подписание метода на событие

            ArrayList list = new ArrayList(10)//a
            {
                10, 20, 30, 40, 50
            };
            list.Add("string");//b
            list.Add(student);//c
            list.RemoveAt(2);//d
            Console.WriteLine($"Nubmer of elements: {list.Count}");
            foreach (object x in list)//коллекция на консоль
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"List contains 30 = {list.Contains(30)}");//проверка на кол-во объектов
            Console.WriteLine();

            dictionary.Add(random.NextDouble(), random.NextDouble());//коллекция содержит пары,в которыхьхранится ключ-значение
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());
            dictionary.Add(random.NextDouble(), random.NextDouble());

            foreach (KeyValuePair<double, double> x in dictionary)//2а
            {
                Console.WriteLine(x);
                queue.Enqueue(x.Value);//заполнение 2д
            }
            Console.WriteLine();

            foreach (double x in queue)//2е
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Flower();
                TabletDictionary.Add(arr[i].GetHashCode(), arr[i]);//3
            }
            Console.WriteLine();
            

            foreach (KeyValuePair<double, Flower> x in TabletDictionary)//выводим словарь на консоль и значение заноситм в таблет
            {
                Console.WriteLine(x);
                TabletQueue.Enqueue(x.Value);//2с в очередь
            }
            Console.WriteLine();
            
            foreach (Flower x in TabletQueue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
           
            foreach (Flower x in arr)//2с  в словарь
            {
                tablets.Add(x);
            }
            tablets.RemoveAt(3);//2б
            Console.WriteLine();
            foreach (Flower x in tablets)
            {
                Console.WriteLine(x);
                
            }
            Console.ReadLine();
        }
        
    }
}
