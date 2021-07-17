using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;

namespace Eleven_collection_.TestCollectionDirectory.CreateDirectory
{
    class StringsCreater : ICreateCollections<List<string>>
    {
        public List<string> Create(int amount)
        {
            foreach (Person person in TestCollections<List<Person>>.keys)
            {
                string strForListStrings = person.Name.ToString() + person.Age.ToString();
                TestCollections<List<string>>.listStrings.Add(strForListStrings);
            }

            return TestCollections<List<string>>.listStrings;
        }
    }
}
