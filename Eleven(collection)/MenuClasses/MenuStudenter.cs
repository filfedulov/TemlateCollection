using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.MenuClasses
{
    public class MenuStudenter : IMenu
    {
        public void Add(uint amount, bool defaultAdd)
        {
            if (defaultAdd)
                for (int i = 0; i < amount; i++)
                {
                    Person.queuePerson.Enqueue(new Student());
                    Person.AmountStudents++;
                }
            else
            {
                string name;
                int course;
                for (int i = 0; i < amount; i++)
                {
                    Console.Write("Имя: ");
                    name = Console.ReadLine();
                    Console.Write("Курс: ");
                    course = int.Parse(Console.ReadLine());
                    if (name != "" && course != 0)
                    {
                        Person.queuePerson.Enqueue(new Student(name, course));
                        Console.WriteLine($"Студент {name} успешно добавлен\n");
                        Person.AmountStudents++;
                    }
                    else
                    {
                        Console.WriteLine("Не оставляйте поля пустыми, повторите ввод..");
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
                if (person is Student)
                {
                    person = Person.queuePerson.Dequeue();
                    Console.WriteLine($"Студент {person.Name} успешно удален\n");
                }
            }
        }

        public void Find(string name)
        {
            bool yes = false;
            foreach (Person person in Person.queuePerson)
            {
                if (person.Name.Equals(name) && person is Student)
                {
                    yes = true;
                    Console.WriteLine("Поиск студента прошел успешно, полная информация о нем:");
                    Console.WriteLine($"Имя: {person.Name}\nКурс: {person.Course}");
                }
            }
            if (!yes)
                Console.WriteLine("Данного студента нет в коллекции.");
        }

        public void Display()
        {
            foreach (Person student in Person.queuePerson)
            {
                if (student is Student)
                {
                    Console.WriteLine
                    (
                    $"Имя: {student.Name}\n" +
                    $"Курс: {student.Course}\n"
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
