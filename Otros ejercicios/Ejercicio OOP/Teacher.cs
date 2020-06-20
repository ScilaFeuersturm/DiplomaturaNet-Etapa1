using System;
namespace Tarea_OOP
{
    public class Teacher : Person
    {
        public string Subject{get;private set;} //Mayuscula porque es property
        public Teacher(string subject, int age):base(age){
            this.Subject = subject;
        }
        public void Explain()
        {
            Console.WriteLine($"Explanation of {Subject} begins");
        }
    }
}