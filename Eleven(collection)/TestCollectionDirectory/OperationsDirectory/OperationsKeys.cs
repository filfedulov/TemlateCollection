using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using System;
using System.Collections.Generic;

namespace Eleven_collection_.TestCollectionDirectory.OperationsDirectory
{
    class OperationsKeys : IOperationsCollections<List<Person>>
    {
        private int HowMuchCanAddFromDB { get; set; }
        
        public List<Person> Add()
        {
            if (TestCollections<List<Person>>.keys.Count == 0)
            {
                Console.WriteLine("\nДля начала создайте коллекцию..");
                return null;
            }    
            
            Console.Write("\nВведите желаемое для добавления количество ключей с консоли: ");
            uint _amount = 0;
            _amount = ExceptionHandler.HandlingExceptionForUint(_amount);
            _AddFromConsole(_amount);

            KeysCreater.CheckEuqalKeys();

            Person.idefaultinformatable = null;

            return TestCollections<List<Person>>.keys;
        }
        private void _AddFromConsole(uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Имя персоны: ");
                string name = "";
                name = ExceptionHandler.HandlingExceptionForString(name);
                Console.Write("Возраст персоны: ");
                uint age = 0;
                age = ExceptionHandler.HandlingExceptionForUint(age);
                TestCollections<List<Person>>.keys.Add(new Person(name, (int)age));
            }
        }

        public List<Person> Delete()
        {
            throw new NotImplementedException();
        }

        public List<Person> Find()
        {
            throw new NotImplementedException();
        }

        public List<Person> Print()
        {
            Console.WriteLine("\nКОЛЛЕКЦИЯ КЛЮЧЕЙ");
            foreach (Person person in TestCollections<List<Person>>.keys)
                Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}\n");

            return TestCollections<List<Person>>.keys;
        }
    }
}
