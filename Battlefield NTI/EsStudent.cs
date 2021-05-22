using System;

namespace Battlefield_NTI
{
    public class EsStudent : Student
    {
        //Constructor that sets the student's major to art and gives the student an advantage in artSkill and langSkill
        public EsStudent()
        {
            major = "Art";
            artSkill = generator.Next(10, 20);
            langSkill = generator.Next(5, 15);

            //Function inherited from the student class that sets the student's grades
            SetGrades();
        }
    }
}
