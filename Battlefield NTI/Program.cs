using System;
using System.Collections.Generic;

namespace Battlefield_NTI
{
    class Program
    {
        static void Main(string[] args)
        {
            int classSize;
            
            Console.Title = "Battlefield NTI";
            
            //Introduction
            Console.WriteLine("Hello! And welcome, to Battlefield NTI");
            Console.WriteLine("Here classes of students viciously fight each other, by debate of course, for the right to the honor of being the best class of all... (and also milkshakes)");
            Console.WriteLine("You're a class rep and your job is to get your class to victory!");
            Console.WriteLine("How many students are in your class? Somewhere between 20 and 30 is standard protocol.");
            
            //Letting the player choose how many students they want in their class
            classSize = StringToInt(Console.ReadLine());
            classSize = CheckAmount(classSize, 20, 30);
            
            Console.WriteLine("Great! " + classSize + ".");
            Console.WriteLine("So, my instructions tell me that you're supposed to be able to hand pick which students you want in your class but we don't have time for that so here you go!");
            
            //A list of your class
            List<Student> yourClass = CreateClass(classSize);
            
            //Printing your class
            PrintClass(yourClass);

            

            Console.ReadLine();
        }

        //Function that creates a class and puts all the students into a list that is then returned
        static List<Student> CreateClass(int size)
        {   
            //A list to put all the students into
            List<Student> students = new List<Student>();
            //For-loop that randomizes a major and then creates a student in that major
            for (int i = 0; i < size; i++)
            {
                int major = Student.generator.Next(3);

                if (major == 0)
                {
                    students.Add(new EsStudent());
                }

                else if (major == 1)
                {
                    students.Add(new ItStudent());
                }

                else
                {
                    students.Add(new TeStudent());
                }
                
            }
            return students;
        }

        //Function that converts the player's input to an int and lets the player retype their answer if it's not a number
        static int StringToInt(string a)
        {
            int i = 0;
            bool success = int.TryParse(a, out i);
            while (success == false)
            {
                Console.WriteLine("Oops! Seems like that's not a number pal. Try again.");
                a = Console.ReadLine();
                success = int.TryParse(a, out i);
            }

            return i;
        }

        //Function that checks whether the input number is too small or too big and lets the player retype their answer
        static int CheckAmount(int i, int min, int max)
        {
            while (i < min)
            {
                Console.WriteLine("Nah man, that number's too small! Try again.");
                i = StringToInt(Console.ReadLine());
            }

            while (i > max)
            {
                Console.WriteLine("Nah man, that number's too big! Try again.");
                i = StringToInt(Console.ReadLine());
            }

            return i;
        }

        //Function that prints out the stats of all the students in a given class
        static void PrintClass(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].PrintStats();
            }
        }
    }
}
