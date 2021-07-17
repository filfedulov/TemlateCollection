using Eleven_collection_.CallMethodsOfPersons;
using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using Eleven_collection_.TestCollectionDirectory.OperationsDirectory;
using System.Collections.Generic;


namespace Eleven_collection_.TestCollectionDirectory
{
    class KeyValueCollection : TestCollections<Dictionary<Person, Student>>
    {
        public KeyValueCollection()
        {
            sMc = new StudentMethodsCallinger();
            createCollections = new KeysValuesCreater();
            operationsCollections = new OperationsKeysValues();
        }
    }
}
