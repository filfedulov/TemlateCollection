using Eleven_collection_.DefaultPersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven_collection_.PersonObjects
{
    public class Student : Person
    {
        public Person BasePerson
        {
            get
            {
                string name;
                int age;
                do
                {
                    try
                    {
                        Console.Write("Имя: ");
                        name = Console.ReadLine();
                        Console.Write("Возраст:");
                        age = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (OverflowException aEx) { Console.WriteLine(aEx.Message + ", повторите ввод..\n"); }
                    catch (FormatException iEx) { Console.WriteLine(iEx.Message + ", повторите ввод..\n"); }

                } while (true);

                return new Person(name, age);
            }
        }

        public Student(){}

        public Student(string name, int course)
        {
            Name = name;
            Course = course;
        }
    }
}
