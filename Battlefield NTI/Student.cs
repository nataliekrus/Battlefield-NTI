using System;
using System.Collections.Generic;

namespace Battlefield_NTI
{
    public class Student
    {
        public static Random generator = new Random();
        public string name;
        protected string major = "";
        protected int mathSkill;
        protected int artSkill;
        protected int langSkill;
        protected int compSkill;
        string[] names = {"Carl", "Beatrice", "Oscar", "Astrid", "Dexter", "Nicole", "Klaus", "Olivia", "Liam", "Noah", "Emma", "Oliver", "Ava", "Elijah", "Charlotte", "William", "Sophia", "James", "Amelia", "Benjamin", "Isabella", "Lucas", "Mia", "Henry", "Evelyn", "Alexander", "Hannah"};
        
        //List of all the subjects
        List<Subject> subjects = CreateSubjects();

        //Dictionary with all the student's grades, first string is the subject, second is the grade
        protected Dictionary<string, string> grades = new Dictionary<string, string>();
      
        //Constructor. Randommizes a name from the names array and the student
        public Student()
        {
            //generates the student's name from the names array
            name = names[generator.Next(names.Length-1)];

            //generates the student's skills
            mathSkill = generator.Next(10);
            artSkill = generator.Next(10);
            langSkill = generator.Next(10);
            compSkill = generator.Next(10);

            
            
        }

        //Function that adds the subjects and their relevant skill into the subjects list and returns the list
        static List<Subject> CreateSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject("English", "lang"));
            subjects.Add(new Subject("Swedish", "lang"));
            subjects.Add(new Subject("Programming", "comp"));
            subjects.Add(new Subject("Computer Science", "comp"));
            subjects.Add(new Subject("Art", "art"));
            subjects.Add(new Subject("Photography", "art"));
            subjects.Add(new Subject("Math", "math"));
            subjects.Add(new Subject("Physics", "math"));

            return subjects;
        }

        

        //Function that generates the student's grade based on random chance and their relevant skill in the subject
        protected void SetGrades()
        {
            int skill = 0;
            string grade = "";
            //for-loop that goes through all the subjects and first determines the relevant skill, and then sets the grade and adds that to the grades dictionary
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].skill == "math")
                {
                    skill = mathSkill;
                }

                else if (subjects[i].skill == "lang")
                {
                    skill = langSkill;
                }

                else if (subjects[i].skill == "art")
                {
                    skill = artSkill;
                }

                else if (subjects[i].skill == "comp")
                {
                    skill = compSkill;
                }

                int knowledge = skill + generator.Next(60);
                if (knowledge < 10)
                {
                    grade = "F";
                }
                else if (knowledge < 20)
                {
                    grade = "E";
                }
                else if (knowledge < 30)
                {
                    grade = "D";
                }
                else if (knowledge < 40)
                {
                    grade = "C";
                }
                else if (knowledge < 50)
                {
                    grade = "B";
                }
                else
                {
                    grade = "A";
                }
                grades.Add(subjects[i].name, grade);
                
            }
            
        }

        //Function that prints out the student's name, major and grades
        public void PrintStats()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Major: " + major);
            Console.WriteLine("Grades:");
            foreach (KeyValuePair<string, string> grade in grades)
            {
                Console.WriteLine("{0} - {1}", grade.Key, grade.Value);
            }
        }
    }
}
