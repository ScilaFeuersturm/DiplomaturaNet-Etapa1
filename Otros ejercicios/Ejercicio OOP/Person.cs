using System;

namespace Tarea_OOP
{
    public class Person
    {


        protected int Age{set;get;}

        public Person(int age)
        {
            this.Age = age;
        }
        public virtual void Saludar(){
            Console.WriteLine("Hello!");
        }
        public virtual void ShowAge(){
            Console.WriteLine($"I am {Age} years old");

        }
    }
}