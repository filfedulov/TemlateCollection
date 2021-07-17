using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using Eleven_collection_.TestCollectionDirectory.OperationsDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.TestCollectionDirectory
{
    class StringCollection : TestCollections<List<string>>
    {
        public StringCollection()
        {
            createCollections = new StringsCreater();
            operationsCollections = new OperationsStrings();
        }
    }
}
