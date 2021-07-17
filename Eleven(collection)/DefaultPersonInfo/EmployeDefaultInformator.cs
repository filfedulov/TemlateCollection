using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.DefaultPersonInfo
{
    public class EmployeDefaultInformator : Person, IDefaultInformatable
    {
        public EmployeDefaultInformator()
        {
            listName = new List<string>()
            {
                "Алевтина Кирилловна", "Антонина Борисовна", "Василий Аркадьевич",
                "Катерина Сергеевна", "Антон Борисович"
            };
                listManOrWoman = new List<string>()
                {
                    "женский", "женский", "мужской",
                    "женский", "мужской"
                };
        }
        
       
        public new void AddDefaultInfo(Person employe)
        {
            for (int i = 0; i < 1; i++)
            {
                if (listName.Count != 0)
                {
                    employe.Name = listName[i];
                    listName.RemoveAt(i);
                    employe.ManOrWoman = listManOrWoman[i];
                    listManOrWoman.RemoveAt(i);
                }
                else
                    Console.WriteLine("Все сотрудники были добавлены в коллекцию.\n");
            }
        }
    }
}
