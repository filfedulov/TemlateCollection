using Eleven_collection_.CallMethodsOfPersons;
using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.MenuClasses.Menues
{
    public class MenuRealizer
    {
        private static Person personForClone,
                             personForClone_;
        private static uint choice,
                          forInput = 0;

        
        public static void Menu()
        {
            do
            {
                Console.WriteLine
                (
                "                         \n" +
                "1. ДЕЙСТВИЯ С УЧИТЕЛЯМИ;  \n" +
                "2. ДЕЙСТВИЯ СО СТУДЕНТАМИ; \n" +
                "3. ДЕЙСТВИЯ С СОТРУДНИКАМИ; \n" +
                "4. ЗАПРОС;                   \n" +
                "5. ВЫВОД ВСЕЙ КОЛЛЕКЦИИ;      \n" +
                "6. СОТРИРОВКА ВСЕЙ КОЛЛЕКЦИИ;  \n" + 
                "7. СОЗДАТЬ КОЛЛЕКЦИЮ НА ОСНОВЕ"     +
                " СУЩЕСТВУЮЩЕЙ ДЛЯ КЛОНИРОВАНИЯ;  \n" +
                "8. ВЫПОЛНИТЬ КЛОНИРОВАНИЕ"            +     
                " КОЛЛЕКЦИИ;                        \n" +
                "9. ВЫХОД."
                );
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 9);
                if (choice == 1) 
                { 
                    ChoiceAction(new TeacherMethodsCallinger());
                    Person.idefaultinformatable = null;
                }
                else if (choice == 2) { ChoiceAction(new StudentMethodsCallinger()); }
                else if (choice == 3) { ChoiceAction(new EmployeMethodsCallinger()); }
                else if (choice == 4) { Query(); }
                else if (choice == 5)
                {
                    if (Person.queuePerson.Count != 0)
                    {
                        foreach (Person person in Person.queuePerson)
                        {
                            if (person is Teacher)
                            {
                                Console.WriteLine
                                (
                                $"Имя: {person.Name}\n" +
                                $"Должность: {person.Position}\n" +
                                $"Кафедра: {person.Department}\n"
                                );
                            }
                            else if (person is Student)
                            {
                                Console.WriteLine
                                (
                                $"Имя: {person.Name}\n" +
                                $"Курс: {person.Course}\n"
                                );
                            }
                            else
                            {
                                Console.WriteLine
                                (
                                $"Имя: {person.Name}\n" +
                                $"Пол: {person.ManOrWoman}\n"
                                );
                            }
                        }
                    }
                    else
                        Console.WriteLine("Коллекция пуста.");
                }
                else if (choice == 6)
                {
                    Person[] persons = Person.queuePerson.ToArray();
                    Array.Sort(persons, new Person());
                    int lengthCollection = Person.queuePerson.Count;

                    for (int i = 0; i < lengthCollection; i++)
                        Person.queuePerson.Dequeue();
                    for (int i = 0; i < persons.Length; i++)
                        Person.queuePerson.Enqueue(persons[i]);
                    Console.WriteLine("Сортировка выполнена успешно.");
                }
                else if (choice == 7)
                {
                    if (Person.queuePerson.Count != 0)
                    {
                        personForClone = new Person();
                        personForClone.queueForClone = Person.queuePerson;
                    }
                    else
                        Console.WriteLine("Для начала создайте коллекцию..");
                }
                else if (choice == 8)
                    personForClone_ = (Person)personForClone.Clone();
                else { break; }
            
            } while (true);
        }

        private static void ChoiceAction(Person person)
        {
            do
            {
                Console.WriteLine
                (
                "\n" +
                "1. ДОБАВЛЕНИЕ;\n" +
                "2. УДАЛЕНИЕ;\n" +
                "3. ПОИСК;\n" +
                "4. ВЫВОД;\n" +
                "5. СОРТИРОВКА КОЛЛЕКЦИИ;\n" +
                "6. НАЗАД.."
                );
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 6);
                
                if (choice == 1)
                    ChoiceOne(person);
                else if (choice == 2)
                    ChoiceTwo(person);
                else if (choice == 3)
                    ChoiceThree(person);
                else if (choice == 4)
                    ChoiceFour(person);
                else if (choice == 5)
                    ChoiceFive(person);
                else { break; }
            
            } while (true);
        }

        private static void ChoiceOne(Person person)
        {
            do
            {
                Console.WriteLine
                (
                 "\n" +
                $"1.) ДОБАВЛЕНИЕ ДЕЙСТВУЮЩИХ {person.objectName};\n" +
                $"2.) ДОБАВЛЕНИЕ НОВЫХ {person.objectName};\n" +
                 "3.) НАЗАД.."
                );
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 3);
                if (choice == 1)
                {
                    do
                    {
                        if (Person.listName.Count != 0)
                        {
                            Console.Write($"В базе данных {Person.listName.Count} {person.objectName}, " +
                            $"сколько хотите добавить? ");
                            choice = ExceptionHandler.HandlingExceptionForUint(forInput, "AddFromDB");
                            person.Add(choice, true);
                            Console.WriteLine("Добавление успешно выполнено..");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\nВсе дейстующие добавлены в коллекцию.");
                            break;
                        }
                    } while (true);
                }
                else if (choice == 2)
                {
                    Console.Write("Сколько хотите добавить? ");
                    choice = ExceptionHandler.HandlingExceptionForUint(forInput, "Add");
                    person.Add(choice, false);
                }
                else
                    break;
            
            } while (true);
        }

        private static void ChoiceTwo(Person person)
        {
            if (Person.queuePerson.Count != 0)
            {
                Console.Write("Сколько хотите удалить? ");
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "Delete");
                person.Delete(choice);
            }
            else
                Console.WriteLine("\nКоллекция пуста.");
        }

        private static void ChoiceThree(Person person)
        {
            if (Person.queuePerson.Count != 0)
            {
                Console.Write("Напишите имя для поиска: ");
                string name = "";
                name = ExceptionHandler.HandlingExceptionForString(name);
                person.Find(name);
            }
            else
                Console.WriteLine("\nКоллекция пуста.");
        }

        private static void ChoiceFour(Person person)
        {
            if (Person.queuePerson.Count != 0)
                person.Display();
            else
                Console.WriteLine("\nКоллекция пуста.");
        }

        private static void ChoiceFive(Person person)
        {
            Person[] persons = Person.queuePerson.ToArray();
            Array.Sort(persons, new Person());
            int lengthCollection = Person.queuePerson.Count;

            for (int i = 0; i < lengthCollection; i++)
                Person.queuePerson.Dequeue();
            for (int i = 0; i < persons.Length; i++)
                Person.queuePerson.Enqueue(persons[i]);
            Console.WriteLine("Сортировка выполнена успешно.");
        }


        private static void Query()
        {
            
            if (Person.queuePerson.Count != 0)
            {
                do
                {
                    Console.WriteLine
                    (
                    "1.) КОЛИЧЕСТВО ЭЛЕМЕНТОВ ОПРЕДЕЛЕННОГО ТИПА;\n" +
                    "2.) ПЕЧАТЬ ЭЛЕМЕНТОВ ОПРЕДЕЛЕННОГО ТИПА;\n" +
                    "3.) КОЛИЧЕСТВО ЭЛЕМЕНТОВ С ОДИНАКОВЫМИ ИМЕНАМИ;\n" +
                    "4.) НАЗАД.."
                    );
                    choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 4);
                    if (choice == 1)
                        QueryChoiceOne();
                    else if (choice == 2)
                        QueryChoiceTwo();
                    else if (choice == 3)
                        QueryChoiceThree();
                    else
                        break;

                } while (true);
            }
            else
                Console.WriteLine("Коллекция пуста.");
        }

        private static void QueryChoiceOne()
        {
            do
            {
                Console.WriteLine
                (
                "\n" +
                "1.) КОЛИЧЕСТВО УЧИТЕЛЕЙ;\n" +
                "2.) КОЛИЧЕСТВО СТУДЕНТОВ;\n" +
                "3.) КОЛИЧЕСТВО СОТРУДНИКОВ;\n" +
                "4.) НАЗАД."
                );
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 4);
                if (choice == 1)
                    Console.WriteLine($"\nКоличество учителей в коллекции {Person.AmountTeachers}.");
                else if (choice == 2)
                    Console.WriteLine($"\nКоличество студентов в коллекции {Person.AmountStudents}.");
                else if (choice == 3)
                    Console.WriteLine($"\nКоличество сотрудников в коллекции {Person.AmountEmployes}.");
                else
                    break;

            } while (true);
        }

        private static void QueryChoiceTwo()
        {
            do
            {
                Console.WriteLine
                (
                "\n" +
                "1.) ПЕЧАТЬ УЧИТЕЛЕЙ;\n" +
                "2.) ПЕЧАТЬ СТУДЕНТОВ;\n" +
                "3.) ПЕЧАТЬ СОТРУДНИКОВ;\n" +
                "4.) НАЗАД."
                );
                choice = ExceptionHandler.HandlingExceptionForUint(forInput, "", 4);
                if (choice == 1)
                {
                    foreach (Person teacher in Person.queuePerson)
                        if (teacher is Teacher)
                            teacher.Display();
                }
                else if (choice == 2)
                {
                    foreach (Person student in Person.queuePerson)
                        if (student is Student)
                            student.Display();
                }
                else if (choice == 3)
                {
                    foreach (Person employe in Person.queuePerson)
                        if (employe is Employe)
                            employe.Display();
                }
                else
                    break;

            } while (true);
        }

        private static void QueryChoiceThree()
        {
            if (Person.queuePerson.Count == 1)
            {
                Console.WriteLine("В коллекции один человек, сравнивать не с кем.");
                return;
            }
            else
            {
                Person[] arrayPerson = Person.queuePerson.ToArray();
                bool[] repeatName = new bool[arrayPerson.Length];

                for (int i = 0; i < arrayPerson.Length - 1; i++)
                {
                    for (int j = i + 1; j < arrayPerson.Length; j++)
                    {
                        if (!repeatName[i])
                        {
                            if (arrayPerson[j].Name.Equals(arrayPerson[i].Name))
                            {
                                Person.EqualName++;
                                repeatName[j] = true;
                            }
                        }
                    }
                }
                Console.WriteLine($"\nПовторений имен {Person.EqualName}.\n");
            }
        }
    }
}