using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using BusinessLayer.Model;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string awsKeyId = "AKIAR52JXGF333RW2HGL";
            string awsKeySecret = "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";
            string awsRegion = "us-east-1";
            */
            Account alikaan = new Account
            {
                ID = 0,
                Email = "alikaan@email.com",
                Username = "alikaan",
                Password = "123456",
            };

            Account ersen = new Account
            {
                ID = 1,
                Email = "ersen@email.com",
                Username = "ersen",
                Password = "123456",
            };

            Account taylan = new Account
            {
                ID = 2,
                Email = "taylan@email.com",
                Username = "taylan",
                Password = "123456",
            };

            Vocabulary word = new Vocabulary
            {
                ID = 0,
                Word = "hello",
                Meaning = "merhaba",
                Link = "https://translate.google.com/#view=home&op=translate&sl=en&tl=tr&text=hello"
            };

            Vocabulary word1 = new Vocabulary
            {
                ID = 1,
                Word = "octopus",
                Meaning = "ahtapot",
                Link = "https://translate.google.com/#view=home&op=translate&sl=en&tl=tr&text=octopus"
            };

            DynomoDBUtility dbUtiliy = new DynomoDBUtility();
            /*
            dbUtiliy.CreateTable("Account", "ID", Amazon.DynamoDBv2.ScalarAttributeType.N);
            System.Threading.Thread.Sleep(5000);
            dbUtiliy.CreateTable("Vocabulary", "ID", Amazon.DynamoDBv2.ScalarAttributeType.N);
            System.Threading.Thread.Sleep(5000);            

            dbUtiliy.InsertAccount(alikaan);            
            dbUtiliy.InsertAccount(ersen);            
            dbUtiliy.InsertAccount(taylan);

            dbUtiliy.InsertWord(word);
            dbUtiliy.InsertWord(word1);
            */

            //var account = dbUtiliy.FindAccountByID(1);

            //Console.WriteLine($"{account.Email},{account.Username},{account.Password}");

            /*
            var tableNames = dbUtiliy.GetTables();
            foreach (var tableName in tableNames)
            {
                Console.WriteLine($"{tableName}");
            }
            */
            List<Vocabulary> vocabularies = new List<Vocabulary>();
            vocabularies = dbUtiliy.GetVocabularies("Vocabulary");
            foreach (var item in vocabularies)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Word);
                Console.WriteLine(item.Meaning);
                Console.WriteLine(item.Link);
                Console.WriteLine();
            }           
            //dbUtiliy.GetAllItmes("Vocabulary");

            //dbUtiliy.GetAllItmes("Account");


            Console.ReadLine();
        }
    }
}
