using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.MenuClasses;
using Eleven_collection_.PersonObjects;

namespace Eleven_collection_.CallMethodsOfPersons
{
    public class StudentMethodsCallinger : Person
    {
        public StudentMethodsCallinger()
        {
            objectName = "СТУДЕНТОВ";
            idefaultinformatable = new StudentDefaultInformator();
            imenu = new MenuStudenter();
        }
    }
}
