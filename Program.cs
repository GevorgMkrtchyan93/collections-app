using System;
using System.Collections.Generic;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 40 };
            numbers.Add(6);
            numbers.AddRange(new int[] { 7, 8, 9 });
            numbers.Insert(0, 120);
            numbers.RemoveAt(1);
            numbers.Sort();

            foreach (int item in numbers)
            {
                Console.WriteLine($"Item={item}");
            }

            Console.WriteLine(new string('_', 50));

            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Aram" });
            people.Add(new Person() { Name = "Vaxo" });
            people.Insert(2, new Person() { Name = "Vacho" });
            people.AddRange(new Person[] { new Person() { Name = "Hendo" }, new Person() { Name = "Maro" }, new Person() { Name = "Soxomon" } });
            people.RemoveAt(5);


            foreach (Person item in people)
            {
                Console.WriteLine($"Person Name: {item.Name}");
            }

            Console.WriteLine(new string('_', 50));

            Queue<int> numbers1 = new Queue<int>();
            numbers1.Enqueue(4);
            numbers1.Enqueue(2);
            numbers1.Enqueue(10);

            int queuElement = numbers1.Dequeue();
            Console.WriteLine($"QueuElement={queuElement}");
            int number = numbers1.Peek();
            Console.WriteLine($"Peek number={number}");

            Console.WriteLine(new string('_', 50));

            Queue<Person> people1 = new Queue<Person>();
            people1.Enqueue(new Person() { Name = "Ani" });
            people1.Enqueue(new Person() { Name = "Mko" });
            people1.Enqueue(new Person() { Name = "Hamo" });
            Person person1 = people1.Peek();
            Console.WriteLine($"Person:{person1}");

            Console.WriteLine($"There are {people1.Count} people in the queue now");

            foreach (Person item in people1)
            {
                Console.WriteLine($"Persons Name:{item.Name}");
            }
            Person person2 = people1.Dequeue();
            Console.WriteLine(person2.Name);

            Console.WriteLine(new string('_', 50));

            Stack<int> numbers2 = new Stack<int>();
            numbers2.Push(3);
            numbers2.Push(5);
            numbers2.Push(8);

            int stackElement = numbers2.Pop();
            Console.WriteLine(stackElement);

            Console.WriteLine(new string('_',50));

            Stack<Person> people2 = new Stack<Person>();
            people2.Push(new Person() { Name = "Mher" });
            people2.Push(new Person() { Name = "Azat" });
            people2.Push(new Person() { Name = "Saqo" });

            foreach (Person item in people2)
            {
                Console.WriteLine(item.Name);
            }

            Person person3 = people2.Pop();
            Console.WriteLine(person3.Name);


            Console.ReadLine();
        }
    }
}
