using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using itProger;
using itProger.Learn;
using Newtonsoft.Json;

namespace itProject;

public class itProger
{
    public static async Task Main()
    {
        // //Работа с датами, строками, директориями, файлами и исключениями
        //BasicTypesFilesExceptions.Main();
        
        // //Работа с коллекциями
        //Collections.Main();
       
        // //Работа с анонимными типами
        //AnonymusTypes.Main();
       
        // //Работа с делегатами
        //Delegates.Main();
       
        // //Работа с лямбдами
        //Lambdas.learnLambdas();
       
        // //Работа с LINQ
        //LINQ.learnLINQ();

        ////Домашка 2
        //Homework2.Main();

        ////Домашка 3
        //Homework3.Main();

        ////Домашка Рустама Rotate Matrix
        //HomeworkRotateMatrix.Main();

        ////Домашка Рустама Accounts
        //HomeworkAccounts.Main();

        ////Домашка Рустама Password Checker
        //HomeworkPasswordChecker.Main();

        ////Работа с событиями
        //LINQ.Main();

        ////Работа с сериализацией
        //Serialazable.Main();

        ////Домашка 4
        //Homework4.Main();

        ////Работа с потоками
        //Threads.Main();

        //Работа с async, parallel
        await AsyncParallel.Main();
 
    }

}
