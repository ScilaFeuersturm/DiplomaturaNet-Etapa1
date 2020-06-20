using System;
namespace Tarea_OOP
{
    public class Student : Person
    {
        public Student(int age) : base (age)
        {

        }


        public void GoToClasses(){
            Console.WriteLine("I'm going to class");
        }
    }
}