using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Amjad", 34, 25);
            teacher.Display();

            Student student = new Student("Hamza",1044,20);
            student.Display();

            Cartwo car= new Cartwo();
            car.Data();

            try
            {
                int x = 24;
                if (x == 34)
                    Console.WriteLine($"The value is {x}");
                else
                    throw new Exception("The value is not matching");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
    class Teacher
    {
        protected string name;
        protected int id;
        protected int age;

        public Teacher() { }
        public Teacher(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Age : {age}");
        }

    }

    class Student : Teacher
    {
        public Student() { }
        public Student(string name, int id, int age) : base(name, id, age){}
       public override void Display()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Age : {age}");
        }
    }
    interface ICar
    {

        void Data();
    }
    class Cartwo : ICar
    {
        public void Data () {
            Console.WriteLine("Hello world");
        }
    }
}
