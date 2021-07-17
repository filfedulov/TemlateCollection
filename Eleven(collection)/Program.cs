using Eleven_collection_.ExceptionDirectory;
using Eleven_collection_.MenuClasses.Menues;
using Eleven_collection_.PersonObjects;
using Eleven_collection_.TestCollectionDirectory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Eleven_collection_
{
    class Program
    {
        static void Main(string[] args)
        {
            int alreadyCreated = 1;
            do
            {
                Console.WriteLine(" \nМЕНЮ ДЛЯ РАБОТЫ С ОБОБЩЕННЫМИ КОЛЛЕКЦИЯМИ\n" +
                " Выберите индекс действия.\n" +
                " 1. Создание коллекций.    \n" +
                " 2. Добавление.             \n" +
                " 3. Удаление.                \n" +
                " 4. Поиск элемента.           \n" +
                " 5. Вывод.                     \n" +
                " 6. Выход.");

                uint choice = new uint();
                choice = ExceptionHandler.HandlingExceptionForUint(choice, "", 6);

                if (choice == 1)
                {
                    if (alreadyCreated == 1)
                    {
                        Console.Write("Введите желаемое количество объектов в коллекциях: ");
                        uint amount = 0;
                        amount = ExceptionHandler.HandlingExceptionForUint(amount);

                        TestCollections<List<Person>>.PatternForCreateAndOperation
                            (
                            new KeyCollection(),
                            1, amount
                            );
                        TestCollections<Dictionary<Person, Student>>.PatternForCreateAndOperation
                            (
                            new KeyValueCollection(),
                            1,
                            amount
                            );
                        //TestCollections<List<string>>.PatternForCreateAndOperation
                        //    (
                        //    new StringCollection(),
                        //    1,
                        //    amount
                        //    );
                        //TestCollections<Dictionary<string, Student>>.PatternForCreateAndOperation
                        //    (
                        //    new StringValueCollection(),
                        //    1,
                        //    amount
                        //    );
                    }
                    else
                        Console.WriteLine("\nКоллекции уже созданы.\n");

                    alreadyCreated++;
                }
                else if (choice == 2)
                {
                    TestCollections<List<Person>>.PatternForCreateAndOperation(new KeyCollection(), 2);
                    TestCollections<Dictionary<Person, Student>>.PatternForCreateAndOperation
                        (
                        new KeyValueCollection(), 2
                        );
                    //TestCollections<List<string>>.PatternForCreateAndOperation(new StringCollection(), 2);
                    //TestCollections<Dictionary<string, Student>>.PatternForCreateAndOperation
                    //    (
                    //    new StringValueCollection(), 2
                    //    );
                }
                else if (choice == 3)
                {
                    TestCollections<List<Person>>.PatternForCreateAndOperation(new KeyCollection(), 3);
                    TestCollections<Dictionary<Person, Student>>.PatternForCreateAndOperation
                        (
                        new KeyValueCollection(), 3
                        );
                    //TestCollections<List<string>>.PatternForCreateAndOperation(new StringCollection(), 3);
                    //TestCollections<Dictionary<string, Student>>.PatternForCreateAndOperation
                    //    (
                    //    new StringValueCollection(), 3
                    //    );
                }
                else if (choice == 4)
                {
                    TestCollections<List<Person>>.PatternForCreateAndOperation(new KeyCollection(), 4);
                    TestCollections<Dictionary<Person, Student>>.PatternForCreateAndOperation
                        (
                        new KeyValueCollection(), 4
                        );
                    //TestCollections<List<string>>.PatternForCreateAndOperation(new StringCollection(), 4);
                    //TestCollections<Dictionary<string, Student>>.PatternForCreateAndOperation
                    //    (
                    //    new StringValueCollection(), 4
                    //    );
                }
                else if (choice == 5)
                {
                    TestCollections<List<Person>>.PatternForCreateAndOperation(new KeyCollection(), 5);
                    TestCollections<Dictionary<Person, Student>>.PatternForCreateAndOperation
                        (
                        new KeyValueCollection(), 5
                        );
                    //TestCollections<List<string>>.PatternForCreateAndOperation(new StringCollection(), 5);
                    //TestCollections<Dictionary<string, Student>>.PatternForCreateAndOperation
                    //    (
                    //    new StringValueCollection(), 5
                    //    );
                }
                else
                    break;

            } while (true);

            //MenuRealizer.Menu();
        }
    }
}
