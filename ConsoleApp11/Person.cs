using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Person
    {
        //Attributes
        public int id;
        public string name;
        public char grade;
        public string add;
        //Methods
        public Person(int a, string b, char c, string d)
        {
            id = a;
            name = b;
            grade = c;
            add = d;
        }
        public Person(int a, string b, char c)
        {
            id = a;
            name = b;
            grade = c;
        }
        public void Display_Pearson()
        {
            Console.WriteLine("Pearson's Candidate");
        }
        public void Display_Arden()
        {
            Console.WriteLine("Arden's Candidate");
        }
    }
}
