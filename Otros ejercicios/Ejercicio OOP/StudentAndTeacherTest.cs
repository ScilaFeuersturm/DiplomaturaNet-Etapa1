using System;

namespace Tarea_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person(20);
            person.Saludar();
            person.ShowAge();


            Teacher teacher = new Teacher("Programming", 30);
            teacher.Saludar();
            teacher.ShowAge();
            teacher.Explain();

            Student student = new Student(17);
            student.Saludar();
            student.ShowAge();
            student.GoToClasses();

            Console.ReadKey();


        }
    }
}
