using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.DefaultPersonInfo
{
    class PersonDefaultInformator : Person, IDefaultInformatable
    {
        public PersonDefaultInformator()
        {
            listName = new List<string>()
            {
                "Александр Македонский", "Федерико Фелинни", "Варвара Бэккер",
                "Катерина Мединская", "Анна Моднова"
            };
            listAge = new List<int>()
                {
                    18, 19, 20,
                    21, 22
                };
        }


        public new void AddDefaultInfo(Person person)
        {
            for (int i = 0; i < 1; i++)
            {
                if (listName.Count != 0)
                {
                    person.Name = listName[i];
                    listName.RemoveAt(i);
                    person.Age = listAge[i];
                    listAge.RemoveAt(i);
                }
                else
                    Console.WriteLine("Все персоны были добавлены в коллекцию.\n");
            }
        }
    }
}

