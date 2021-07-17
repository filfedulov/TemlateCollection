using Eleven_collection_.CallMethodsOfPersons;
using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory.CreateDirectory;
using Eleven_collection_.TestCollectionDirectory.OperationsDirectory;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Eleven_collection_.TestCollectionDirectory
{
    public abstract class TestCollections<T>
    {
        protected PersonMethodsCallinger pMc;
        protected StudentMethodsCallinger sMc;
        public static List<Person> keys = new List<Person>();
        public static List<string> listStrings = new List<string>();
        public static Dictionary<Person, Student> keysValues = new Dictionary<Person, Student>();
        public static Dictionary<string, Student> stringValues = new Dictionary<string, Student>();

        protected ICreateCollections<T> createCollections;
        protected IOperationsCollections<T> operationsCollections;

        
        public static void PatternForCreateAndOperation
            (
            TestCollections<T> testCollections, 
            uint choice, uint amount = 0
            )
        {
            if (choice == 1)
                testCollections.CreateCollections((int)amount);
            if (TestCollections<List<Person>>.keys.Count != 0 && choice != 1)
            {
                if (choice == 2)
                    testCollections.AddElement();
                else if (choice == 3)
                    testCollections.DeleteElemet();
                else if (choice == 4)
                    testCollections.FindElement();
                else
                    testCollections.PrintCollection();
            }
        }

        private void CreateCollections(int amount)
        {
            createCollections.Create(amount);
        }

        private void AddElement()
        {
            operationsCollections.Add();
        }

        private void DeleteElemet()
        {

        }

        private void FindElement()
        {

        }

        private void PrintCollection()
        {
            operationsCollections.Print();
        }
    //    readonly Stopwatch stopwatch = new Stopwatch();

    //    public List<Person> keys = new List<Person>();
    //    public List<string> listStrings = new List<string>();
    //    public Dictionary<Person, Student> keysValues = new Dictionary<Person, Student>();
    //    public Dictionary<string, Student> stringValues = new Dictionary<string, Student>();

    //    public void AddInCollections()
    //    {
    //        string name = "";
    //        uint age = 0, amountObjects = 0, course = 0;
    //        Console.Write("Введите количество элементов в коллекции: ");
    //        amountObjects = ExceptionHandler.HandlingExceptionForUint(amountObjects);

    //        for (int i = 0; i < amountObjects; i++)
    //        {
    //            Console.Write("Имя персоны:");
    //            name = ExceptionHandler.HandlingExceptionForString(name);
    //            Console.Write("Возраст персоны:");
    //            age = ExceptionHandler.HandlingExceptionForUint(age);

    //            Person person = new Person(name, (int)age);
    //            keys.Add(person);
    //            string keyString = person.ToString();
    //            listStrings.Add(keyString);

    //            Console.Write("Имя студента:");
    //            name = ExceptionHandler.HandlingExceptionForString(name);
    //            Console.Write("Курс:");
    //            course = ExceptionHandler.HandlingExceptionForUint(course);
    //            keysValues.Add(person, new Student(name, (int)course));

    //            Console.Write("Имя студента:");
    //            name = ExceptionHandler.HandlingExceptionForString(name);
    //            Console.Write("Курс:");
    //            course = ExceptionHandler.HandlingExceptionForUint(course);
    //            stringValues.Add(keyString, new Student(name, (int)course));
    //        }
    //    }
        
    //    public void FindKey()
    //    {
    //        TestCollections testCollections = new TestCollections();
    //        testCollections.AddInCollections();

    //        string nameNoExists = "sfsfsf";
    //        Console.Write("Введите имя элемента: ");
    //        string name = Console.ReadLine();
    //        int i = testCollections.keys.Count;

    //        stopwatch.Start();
    //        testCollections.keys[i / i].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков на поиск в начеле {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i / 2].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск в середине {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск последнего элемента {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i].Name.Contains(nameNoExists);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск заранее не существующего элемента {stopwatch.ElapsedTicks}.");
    //    }

    //    public void FindString()
    //    {
    //        TestCollections testCollections = new TestCollections();
    //        testCollections.AddInCollections();

    //        string nameNoExists = "sfsfsf";
    //        Console.Write("Введите имя элемента: ");
    //        string name = Console.ReadLine();
    //        int i = testCollections.keys.Count;

    //        stopwatch.Start();
    //        testCollections.keys[i / i].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков на поиск в начеле {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i / 2].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск в середине {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i].Name.Contains(name);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск последнего элемента {stopwatch.ElapsedTicks}.");

    //        stopwatch.Start();
    //        testCollections.keys[i].Name.Contains(nameNoExists);
    //        stopwatch.Stop();
    //        Console.WriteLine($"Потрачено тиков поиск заранее не существующего элемента {stopwatch.ElapsedTicks}.");
    //    }
    }
}