using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory.CreateDirectory
{
    class KeysCreater : ICreateCollections<List<Person>>
    {
        private int Amount { get; set; }
        private static int CountForNoAuto { get; set; }

        public List<Person> Create(int amount)
        {
            if (TestCollections<List<Person>>.keys.Count == 0)
            {
                Amount = amount;
                if (Amount > 5)
                {
                    AutoAdd(moreFive: true);
                    NoAutoAdd();
                }
                else
                    AutoAdd();

                Person.idefaultinformatable = null;

                return TestCollections<List<Person>>.keys;
            }

            return null;
        }

        private void AutoAdd(bool moreFive = false)
        {
            int amount;
            if (!moreFive)
                amount = Amount;
            else
                amount = 5;
            Console.WriteLine("\nНачалось автоматическое заполнение коллекции ключей...");
            for (int i = 0; i < amount; i++)
            {
                TestCollections<List<Person>>.keys.Add(new Person());
                CountForNoAuto++;
            }
            Console.WriteLine("Автоматическое заполнение коллекции ключей закончено.\n");
            CheckEuqalKeys();
        }

        private void NoAutoAdd()
        {
            Console.WriteLine("Далее заполняйте вручную...");
            for (int i = CountForNoAuto; i < Amount; i++)
            {
                Console.Write("Имя персоны: ");
                string name = "";
                name = ExceptionHandler.HandlingExceptionForString(name);
                Console.Write("Возраст: ");
                uint age = 0;
                age = ExceptionHandler.HandlingExceptionForUint(age);
                TestCollections<List<Person>>.keys.Add(new Person(name, (int)age));

                CheckEuqalKeys();
            }
            Console.WriteLine("Заполнение коллекции ключей закончено.");
        }

        public static void CheckEuqalKeys()
        {
            for (int i = 0; i < TestCollections<List<Person>>.keys.Count - 1; i++)
            {
                for (int j = i + 1; j < TestCollections<List<Person>>.keys.Count; j++)
                {
                    if 
                        (
                        TestCollections<List<Person>>.keys[i].Name
                        .Equals(TestCollections<List<Person>>.keys[j].Name)
                        )
                    {
                        TestCollections<List<Person>>.keys.RemoveAt(j);
                        CountForNoAuto--;
                    }
                }
            }
        }
    }
}
