using System;

namespace Battlefield_NTI
{
    public class Subject
    {
        public string name = "";
        public string skill = "";

        //Constructor that sets the subjects name and relevant skill from the parameters
        public Subject (string n, string s)
        {
            name = n;
            skill = s;
        }
    }
}
