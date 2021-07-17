using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.DefaultPersonInfo
{
    public class TeacherDefaultInformator : Person, IDefaultInformatable
    {
        public TeacherDefaultInformator()
        {
            listName = new List<string>()
            {
                "Викентьева Ольга Леонидовна", "Полякова Ольга Андреевна", "Кротова Елена Львовна",
                "Фвйзрахманов Рустам Абубакирович", "Шабуров Андрей Сергеевич"
            };
                listPosition = new List<string>()
                {
                    "Доцент, кандидат технических наук",
                    "Доцент, кандидат технических наук",
                    "Доцент, кандидат физико-математических наук",
                    "Заведующий кафедрой, профессор, Доктор экономических наук",
                    "Доцент, кандидат технических наук"
                };
                    listDepartment = new List<string>()
                    {
                        "Кафедра ИТАС",
                        "Кафедра ИТАС",
                        "Кафедра ВМ",
                        "Кафедра ИТАС",
                        "Кафедра АТ"
                    };
        }
        
                

        public new void AddDefaultInfo(Person teacher)
        {
            for (int i = 0; i < 1; i++)
            {
                if (listName.Count != 0)
                {
                    teacher.Name = listName[i];
                    listName.RemoveAt(i);
                    teacher.Position = listPosition[i];
                    listPosition.RemoveAt(i);
                    teacher.Department = listDepartment[i];
                    listDepartment.RemoveAt(i);
                }
                else
                    Console.WriteLine("Все учителя были добавлены в коллекцию.\n");
            }
        }
    }
}
