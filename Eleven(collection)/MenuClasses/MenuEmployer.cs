using System;
using Eleven_collection_.PersonObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.MenuClasses
{
    public class MenuEmployer : IMenu
    {
        public void Add(uint amount, bool defaultAdd)
        {
            if (defaultAdd)
            for (int i = 0; i < amount; i++)
            {
                Person.queuePerson.Enqueue(new Employe());
                    Person.AmountEmployes++;
            }
            else
            {
                string name;
                string manOrWoman;
                for (int i = 0; i < amount; i++)
                {
                    Console.Write("Имя: ");
                    name = Console.ReadLine();
                    Console.Write("Пол: ");
                    manOrWoman = Console.ReadLine();
                    if (name != "" && manOrWoman != "")
                    {
                        Person.queuePerson.Enqueue(new Employe(name, manOrWoman));
                        Console.WriteLine($"Сотрудник {name} успешно добавлен\n");
                        Person.AmountEmployes++;
                    }
                    else
                    {
                        Console.WriteLine("Не оставляйте поля пустыми , повторите ввод..");
                        i--;
                        continue;
                    }
                }
            }
        }

        public void Delete(uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Person person = Person.queuePerson.Peek();
                if (person is Employe)
                {
                    person = Person.queuePerson.Dequeue();
                    Console.WriteLine($"Сотрудник {person.Name} успешно удален\n");
                }
            }
        }

        public void Find(string name)
        {
            bool yes = false;
            foreach (Person person in Person.queuePerson)
            {
                if (person.Name.Equals(name) && person is Employe)
                {
                    yes = true;
                    Console.WriteLine("Поиск сотрудника прошел успешно, полная информация о нем:");
                    Console.WriteLine($"Имя: {person.Name}\nПол: {person.ManOrWoman}");
                }
            }
            if (!yes)
                Console.WriteLine("Данного сотрудника нет в коллекции.");
        }

        public void Display()
        {
            foreach (Person employe in Person.queuePerson)
            {
                if (employe is Employe)
                {
                    Console.WriteLine
                    (
                    $"Имя: {employe.Name}\n" +
                    $"Пол: {employe.ManOrWoman}\n"
                    );
                }
            }
        }

        public void Query(uint choiceFromMenu)
        {
            throw new NotImplementedException();
        }
    }
}
