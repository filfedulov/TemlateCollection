using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory.OperationsDirectory
{
    class OperationsStringsValues : IOperationsCollections<Dictionary<string, Student>>
    {
        public Dictionary<string, Student> Add()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Student> Delete()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Student> Find()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Student> Print()
        {
            Console.WriteLine("\nКОЛЛЕКЦИЯ КЛЮЧЕЙ(СТРОК) И ЗНАЧЕНИЙ");
            foreach
                (
                KeyValuePair<string, Student> sVp
                in TestCollections<Dictionary<List<string>, Student>>.stringValues
                )
            {
                Console.WriteLine
                    (
                    $"Ключ(строка): имя: {sVp.Key}, " +
                    $"Значение: имя: {sVp.Value.Name}, возраст: {sVp.Value.Age}\n"
                    );
            }

            return TestCollections<Dictionary<List<string>, Student>>.stringValues;
        }
    }
}
