using Eleven_collection_.CallMethodsOfPersons;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using Eleven_collection_.TestCollectionDirectory.OperationsDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory
{
    class StringValueCollection : TestCollections<Dictionary<string, Student>>
    {
        public StringValueCollection()
        {
            sMc = new StudentMethodsCallinger();
            createCollections = new StringsValuesCreater();
            operationsCollections = new OperationsStringsValues();
        }
    }
}
