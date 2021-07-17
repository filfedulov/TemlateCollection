using Eleven_collection_.PersonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.ExceptionDirectory
{
    public class ExceptionHandler
    {
        public static string HandlingExceptionForString(string name)
        {
            name = Console.ReadLine();
            return name;
        }

        public static uint HandlingExceptionForUint(uint forInput, string action = "", int limit = -1)
        {
            do
            {
                try
                {
                    forInput = uint.Parse(Console.ReadLine());
                    if (limit != -1)
                        NumberNullAndLimit(forInput, limit);
                    else if (action.Equals("AddFromDB"))
                        NumberNullOrMoreThanInDB(forInput);
                    else if (action.Equals("Add"))
                        NumberNull(forInput);
                    else if (action.Equals("Delete"))
                    {
                        QueueCountNull(forInput);
                        NumberNull(forInput);
                    }

                    break;
                }
                catch (OverflowException aEx) { Console.WriteLine(aEx.Message + ", повторите ввод..\n"); }
                catch (FormatException iEx) { Console.WriteLine(iEx.Message + ", повторите ввод..\n"); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            } while (true);
            
            return forInput;
        }

        private static void NumberNullAndLimit(uint forInput, int limit)
        {
            if (forInput == 0 || forInput > limit)
                throw new Exception("Нет действия под данным индексом, повторите ввод..\n");
        }

        private static void NumberNullOrMoreThanInDB(uint forInput)
        {
            if (forInput == 0 || forInput > Person.listName.Count)
                throw new Exception("Введенное количество превышает фактическое," +
                                    " либо равно нулю, повторите ввод..\n");
        }
        
        private static void NumberNull(uint forInput)
        {   
            if (forInput == 0)
                throw new Exception("Ноль не имеет смысла в данном контексте, повторите ввод..\n");
        }

        private static void QueueCountNull(uint forInput)
        {
            if (forInput > Person.queuePerson.Count)
                throw new Exception("Запрашиваемое количество на удаление превышает фактическое число объектов в коллекции, " +
                                    "повторите ввод..");
        }
    }
}
