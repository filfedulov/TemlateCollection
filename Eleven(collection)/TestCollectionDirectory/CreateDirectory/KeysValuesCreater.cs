using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;


namespace Eleven_collection_.TestCollectionDirectory.CreateDirectory
{
    class KeysValuesCreater : ICreateCollections<Dictionary<Person, Student>>
    {
        private int Amount { get; set; }
        private int CountForNoAuto { get; set; }


        public Dictionary<Person, Student> Create(int amount)
        {
            Amount = amount;
            if (Amount > 5)
            {
                AutoAdd(moreFive: true);
                Person.idefaultinformatable = null;
                NoAutoAdd();
            }
            else
                AutoAdd();

            Person.idefaultinformatable = null;

            return TestCollections<Dictionary<Person, Student>>.keysValues;
        }

        private void AutoAdd(bool moreFive = false)
        {
            int amount;
            if (!moreFive)
                amount = Amount;
            else
                amount = 5;
            
            Console.WriteLine("\nНачалось автоматическое заполнение коллекции ключей и значений...");
            for (int i = 0; i < amount; i++)
            {
                TestCollections<Dictionary<Person, Student>>.keysValues.Add
                    (
                        TestCollections<List<Person>>.keys[i],
                        new Student()
                    );
                CountForNoAuto++;
            }
            Console.WriteLine("Автоматическое заполнение коллекции ключей и значений закончено.\n");
        }

        private void NoAutoAdd()
        {
            Console.WriteLine("Далее заполняйте вручную...");
            for (int i = CountForNoAuto; i < Amount; i++)
            {
                string name = "";
                Console.Write("Имя студента: ");
                name = ExceptionHandler.HandlingExceptionForString(name);
                uint course = 0;
                Console.Write("Курс: ");
                course = ExceptionHandler.HandlingExceptionForUint(course);

                TestCollections<Dictionary<Person, Student>>.keysValues.Add
                    (
                        TestCollections<List<Person>>.keys[i],
                        new Student(name, (int)course)
                    );
            }
            Console.WriteLine("Заполнение коллекции ключей и значений закончено.");
        }
    }
}