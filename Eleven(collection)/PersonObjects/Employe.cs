using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.PersonObjects
{
    public class Employe : Person
    {
        public Employe(){}

        public Employe(string name, string manOrWoman)
        {
            Name = name;
            ManOrWoman = manOrWoman;
        }
    }
}
