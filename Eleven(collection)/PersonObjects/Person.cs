using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.MenuClasses;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Eleven_collection_.PersonObjects
{
    public class Person : IEnumerable, IComparer<Person>, ICloneable
    {
        public static IDefaultInformatable idefaultinformatable;
        protected IMenu imenu;
        public static List<String> listName;
        public static List<String> listManOrWoman;
        public static List<String> listPosition;
        public static List<String> listDepartment;
        public static List<int> listCourse;
        public static List<int> listAge;
        public static Queue queuePerson_ = new Queue();
        public static Queue<Person> queuePerson = new Queue<Person>();
        public Queue<Person> queueForClone = new Queue<Person>();
        public string objectName { get; protected set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ManOrWoman { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public int Course { get; set; }
        public int AmountPersonInDB { get; protected set; }
        public static int AmountTeachers { get; set; }
        public static int AmountStudents { get; set; }
        public static int AmountEmployes { get; set; }
        public static int EqualName { get; set; }

        public Person() 
        {
            if (idefaultinformatable != null)
                idefaultinformatable.AddDefaultInfo(this);
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void AddDefaultInfo(Person person)
        {
            idefaultinformatable.AddDefaultInfo(person);
        }

        public void Add(uint amount, bool defaultAdd)
        {
            imenu.Add(amount, defaultAdd);
        }

        public void Delete(uint amount)
        {
            imenu.Delete(amount);
        }
        
        public void Find(string name)
        {
            imenu.Find(name);
        }
        
        public void Display()
        {
            imenu.Display();
        }

        public IEnumerator GetEnumerator()
        {
            return queuePerson.GetEnumerator();
        }

        public int Compare(Person x, Person y)
        {
            if (x.Name.Length > y.Name.Length)
                return 1;
            else if (x.Name.Length < y.Name.Length)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            Queue<Person> queueForClone_ = new Queue<Person>();
            foreach (Person person in queueForClone)
            {
                if (person is Teacher)
                    queueForClone_.Enqueue(new Teacher(person.Name, person.Position, person.Department));
                else if (person is Student)
                    queueForClone_.Enqueue(new Student(person.Name, person.Course));
                else
                    queueForClone_.Enqueue(new Employe(person.Name, person.ManOrWoman));
            }
            return new Person()
            {
                queueForClone = queueForClone_
            };
        }
    }
}
