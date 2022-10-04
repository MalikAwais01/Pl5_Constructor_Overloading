using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Person myobj = new Person(123456, "Shah WAli Ullah", 'A', "DHA Rahbar");
            Console.WriteLine(myobj.id + " " + myobj.name + " " + myobj.grade + " " + myobj.add);

            Person obj = new Person(45678, "Farris", 'A');
            Console.WriteLine(obj.id + " " + obj.name + " " + obj.grade );


        }
    }
}
