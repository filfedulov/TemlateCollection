using Eleven_collection_.DefaultPersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.PersonObjects
{
    public class Teacher : Person
    {
        public Teacher(){}

        public Teacher(string name, string position, string department)
        {
            Name = name;
            Position = position;
            Department = department;
        }
    }
}
