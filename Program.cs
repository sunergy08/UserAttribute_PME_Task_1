using System;

namespace UserAttribute_PME_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("Hello! What is you rname?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you " + name + "; you are " + age + " years old.");
        }
    }
}
