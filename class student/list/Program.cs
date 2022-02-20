using System;
namespace app
{
    public class Student
    {
        public string name;
        public int age;
        public int id;

    }
    class program
    {
        static void Main(string[]arg)
        {
            Student std1 = new Student();
            Student std2 = new Student();
            Console.WriteLine("        Students proerty     ");
            std1.name = "ankur ";
            std1.age = 23;
            std1.id = 17118041;
            std2.name = "Satyam ";
            std2.age = 21;
            std2.id = 17118023;
            Console.WriteLine("name :   " + std1.name);
            Console.WriteLine("age  :   " + std1.age);
            Console.WriteLine("id   :   " +std1.id);
            Console.WriteLine("name :   " + std2.name);
            Console.WriteLine("age  :   " + std2.age);
            Console.WriteLine("id   :   " + std2.id);


        }
    }
}