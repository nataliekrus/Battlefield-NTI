using System;

namespace Battlefield_NTI
{
    public class TeStudent : Student
    {
        //Constructor that sets the student's major to tech and gives the student an advantage in mathSkill and compSkill
        public TeStudent()
        {
            major = "Tech";
            mathSkill = generator.Next(10, 20);
            compSkill = generator.Next(5, 15);

            //Function inherited from the student class that sets the student's grades
            SetGrades();

        }
    }
}
