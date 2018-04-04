using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friendly_conversation_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");

            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you {0}" , name + " , My name is C# , How old are you?");

            int age = int.Parse(Console.ReadLine());

            if (age == 0)
            {
                Console.WriteLine("This is not an age , bro");
            }
            else if (age < 0)
            {
                Console.WriteLine("This is not an age , either");
            }
            else
            {
                Console.WriteLine(age + " Good! , As for me I was born on 2002 which makes me {0} years old", DateTime.Now.Year - 2002);
            }

            
        }
    }
}
