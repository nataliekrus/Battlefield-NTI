using System;

namespace Battlefield_NTI
{
    public class ItStudent : Student
    {
        //Constructor that sets the student's major to IT and gives the student an advantage in mathSkill and compskill
        public ItStudent()
        {
            major = "IT";
            mathSkill = generator.Next(5, 15);
            compSkill = generator.Next(10, 20);

            //Function inherited from the student class that sets the student's grades
            SetGrades();
        }
    }
}
