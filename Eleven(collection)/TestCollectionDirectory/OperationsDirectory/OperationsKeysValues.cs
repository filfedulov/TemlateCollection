using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory.OperationsDirectory
{
    class OperationsKeysValues : IOperationsCollections<Dictionary<Person, Student>>
    {
        public Dictionary<Person, Student> Add()
        {
            if (TestCollections<List<Person>>.keys.Count == 0)
            {
                Console.WriteLine("\nДля начала создайте коллекцию..");
                return null;
            }

            _Add();

            Person.idefaultinformatable = null;

            return TestCollections<Dictionary<Person, Student>>.keysValues;
        }
        private void _Add()
        {
            for 
                (
                int i = TestCollections<Dictionary<Person, Student>>.keysValues.Keys.Count; 
                i < TestCollections<List<Person>>.keys.Count; 
                i++
                )
            {
                Console.WriteLine("\nЗаполните атрибуты значений соответствующих ключам");
                Console.Write("Имя студента: ");
                string nameStudent = "";
                nameStudent = ExceptionHandler.HandlingExceptionForString(nameStudent);
                Console.Write("Курс: ");
                uint course = 0;
                course = ExceptionHandler.HandlingExceptionForUint(course);

                TestCollections<Dictionary<Person, Student>>.keysValues.Add
                    (
                    TestCollections<List<Person>>.keys[i],
                    new Student(nameStudent, (int)course)
                    );
            }
        }

        public Dictionary<Person, Student> Delete()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Person, Student> Find()
        {
            //Console.Write("Напишите имя объекта: ");
            //string name = "";
            //name = ExceptionHandler.HandlingExceptionForString(name);
            //TestCollections<Dictionary<Person, Student>>.keysValues.ContainsKey(new Person().Name);
            //foreach 
            //    (
            //    KeyValuePair<Person, Student> kVp
            //    in TestCollections<Dictionary<Person, Student>>.keysValues
            //    )
            //{
            //    if (kVp.Key.Name.Equals(name))
            //    {
            //        bool t = TestCollections<Dictionary<Person, Student>>
            //            .keysValues.ContainsKey(kVp.Key.Name);
            //    }

            //}
            throw new NotImplementedException();
        }

        public Dictionary<Person, Student> Print()
        {
            Console.WriteLine("\nКОЛЛЕКЦИЯ КЛЮЧЕЙ И ЗНАЧЕНИЙ");
            foreach 
                (
                KeyValuePair<Person, Student> kVp
                in TestCollections<Dictionary<Person, Student>>.keysValues
                )
            {
                Console.WriteLine
                    (
                    $"Ключ: имя: {kVp.Key.Name}, возраст: {kVp.Key.Age} " +
                    $"- Значение: имя: {kVp.Value.Name}, курс: {kVp.Value.Course}\n"
                    );
            }

            return TestCollections<Dictionary<Person, Student>>.keysValues;
        }
    }
}
