using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory.OperationsDirectory
{
    class OperationsStrings : IOperationsCollections<List<string>>
    {
        public List<string> Add()
        {
            throw new NotImplementedException();
        }

        public List<string> Delete()
        {
            throw new NotImplementedException();
        }

        public List<string> Find()
        {
            throw new NotImplementedException();
        }

        public List<string> Print()
        {
            Console.WriteLine("\nКОЛЛЕКЦИЯ КЛЮЧЕЙ(СТРОК)");
            foreach (string str in TestCollections<List<string>>.listStrings)
                Console.WriteLine($"Строка: {str}\n");

            return TestCollections<List<string>>.listStrings;
        }
    }
}
