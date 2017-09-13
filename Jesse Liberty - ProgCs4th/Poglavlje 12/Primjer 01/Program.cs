using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public enum Comparison
    {
        theFirstComesFirst = 1,
        theSecondComesFirst = 2
    }

    class Program
    {
        static void Main()
        {
            //pravi dva studenta i dva psa i dodaje ih objektima Pair
            Student jesse = new Student("Jesse");
            Student stacey = new Student("Stacey");
            Dog milo = new Dog(65);
            Dog fred = new Dog(12);

            Pair<Student> studentPair = new Pair<Student>(jesse, stacey);
            Pair<Dog> dogPair = new Pair<Dog>(milo, fred);

            Console.WriteLine("studnetPair\t: {0}", studentPair.ToString());
            Console.WriteLine("dogPair\t\t: {0}", dogPair.ToString());
            Console.WriteLine();

            //instancira delegate
            Pair<Student>.WhichIsFirst theStudentDelegate = new Pair<Student>.WhichIsFirst(jesse.WhichStudentComesFirst);
            Pair<Dog>.WhichIsFirst theDogDelegate = new Pair<Dog>.WhichIsFirst(milo.WhichDogComesFirst);

            //sortira pomocu delegata
            studentPair.Sort(theStudentDelegate);
            Console.WriteLine("After Sort studentPair\t\t: {0}", studentPair.ToString());
            studentPair.ReverseSort(theStudentDelegate);
            Console.WriteLine("After ReverseSort studentPair\t: {0}", studentPair.ToString());
            Console.WriteLine();

            dogPair.Sort(theDogDelegate);
            Console.WriteLine("After Sort dogPair\t\t: {0}", dogPair.ToString());
            dogPair.ReverseSort(theDogDelegate);
            Console.WriteLine("After ReverseSort\t\t: {0}", dogPair.ToString());
        }
    }
}
