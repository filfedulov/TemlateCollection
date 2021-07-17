using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.CallMethodsOfPersons
{
    public class PersonMethodsCallinger : Person
    {
        public PersonMethodsCallinger()
        {
            idefaultinformatable = new PersonDefaultInformator();
        }
    }
}
