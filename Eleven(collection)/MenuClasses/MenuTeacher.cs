using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.MenuClasses
{
    public class MenuTeacher : IMenu
    {
        public void Add(uint amount, bool defaultAdd)
        {
            if (defaultAdd)
                for (int i = 0; i < amount; i++)
                {
                    Person.queuePerson.Enqueue(new Teacher());
                    Person.AmountTeachers++;
                }
            else
            {
                string name;
                string position;
                string department;
                for (int i = 0; i < amount; i++)
                {
                    Console.Write("Имя: ");
                    name = Console.ReadLine();
                    Console.Write("Должность: ");
                    position = Console.ReadLine();
                    Console.Write("Кафедра: ");
                    department = Console.ReadLine();
                    if (name != "" && position != "" && department != "")
                    {
                        Person.queuePerson.Enqueue(new Teacher(name, position, department));
                        Console.WriteLine($"Учитель {name} успешно добавлен\n");
                        Person.AmountTeachers++;
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
                if (person is Teacher)
                {
                    person = Person.queuePerson.Dequeue();
                    Console.WriteLine($"Учитель {person.Name} успешно удален\n");
                }
            }
        }

        public void Find(string name)
        {
            bool yes = false;
            foreach (Person person in Person.queuePerson)
            {
                if (person.Name.Equals(name) && person is Teacher)
                {
                    yes = true;
                    Console.WriteLine("Поиск учителя прошел успешно, полная информация о нем:");
                    Console.WriteLine($"Имя: {person.Name}\nДолжность: {person.Position}\nКафедра: {person.Department}");
                }
            }
            if (!yes)
                Console.WriteLine("Данного учителя нет в коллекции.");
        }

        public void Display()
        {
            foreach (Person teacher in Person.queuePerson)
            {
                if (teacher is Teacher)
                {
                    Console.WriteLine
                    (
                    $"Имя: {teacher.Name}\n" +
                    $"Должность: {teacher.Position}\n" +
                    $"Кафедра: {teacher.Department}\n"
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
