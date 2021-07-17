using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.MenuClasses;
using Eleven_collection_.PersonObjects;

namespace Eleven_collection_.CallMethodsOfPersons
{
    public class TeacherMethodsCallinger : Person
    {
        public TeacherMethodsCallinger()
        {
            objectName = "УЧИТЕЛЕЙ";
            idefaultinformatable = new TeacherDefaultInformator();
            imenu = new MenuTeacher();
        }
    }
}
