using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingConstraints
{
    //testiranje
    class Test
    {
        static void Main()
        {
            //pravi instancu pokrece metodu
            Test t = new Test();
            t.Run();
        }

        public void Run()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            Random rand = new Random();
            Console.Write("Adding: ");

            for(int i = 0; i < 10; i++)
            {
                int nextInt = rand.Next(10);
                Console.Write("{0} ", nextInt);
                myLinkedList.Add(nextInt);
            }

            LinkedList<Employee> employees = new LinkedList<Employee>();
            employees.Add(new Employee("John"));
            employees.Add(new Employee("Paul"));
            employees.Add(new Employee("George"));
            employees.Add(new Employee("Ringo"));

            Console.WriteLine("\nRetrieving collections...");
            Console.WriteLine("Integers: " + myLinkedList);
            Console.WriteLine("Employess: " + employees);
        }
    }
}
