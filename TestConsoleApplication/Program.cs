using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;
using DataAccessLayer.Model;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string awsKeyId = "AKIAR52JXGF333RW2HGL";
            string awsKeySecret = "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";
            string awsRegion = "us-east-1";           
            DynomoDBUtility dbUtiliy = new DynomoDBUtility();
            

            var tableNames = dbUtiliy.GetTables();
            foreach (var tableName in tableNames)
            {
                Console.WriteLine($"{tableName}");
            }
            
            dbUtiliy.CreateTable("Vocabulary", "VocabularyID", Amazon.DynamoDBv2.ScalarAttributeType.N);

            Vocabulary vocabulary = new Vocabulary
            {
                VocabularyID = 1001,
                VocabularyInfo = new VocabularyInfo
                {
                    Word = "Hello",
                    Meaning = "Merhaba",
                    Link = "blabla",
                }
            };

            dbUtiliy.InsertVocabulary(vocabulary);

            // The tcode provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
