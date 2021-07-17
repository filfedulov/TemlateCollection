using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.MenuClasses
{
    public interface IMenu
    {
        void Add(uint amount, bool defaultAdd);
        void Delete(uint amount);
        void Find(string name);
        void Query(uint choiceFromMenu);
        void Display();
    }
}
