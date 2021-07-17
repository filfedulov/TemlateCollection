using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.DefaultPersonInfo
{
    public class StudentDefaultInformator : Person, IDefaultInformatable
    {
        public StudentDefaultInformator()
        {
            listName = new List<string>()
            {
                "Носова Ирина", "Мизева Лиза","Тома Макарова",
                "Пачина Наталья", "Ямова Катя"
            };
                listCourse = new List<int>()
                {
                    3, 1, 4,
                    4, 2
                };
        }

        public new void AddDefaultInfo(Person student)
        {
            for (int i = 0; i < 1; i++)
            {
                if (listName.Count != 0)
                {
                    student.Name = listName[i];
                    listName.RemoveAt(i);
                    student.Course = listCourse[i];
                    listCourse.RemoveAt(i);
                }
                else
                    Console.WriteLine("Все студенты были добавлены в коллекцию.\n");
            }
        }
    }
}
