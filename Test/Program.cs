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
            DynomoDBUtility dbUtiliy = new DynomoDBUtility();

            dbUtiliy.CreateTable("Account", "ID", Amazon.DynamoDBv2.ScalarAttributeType.N);

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

            var tableNames = dbUtiliy.GetTables();
            foreach (var tableName in tableNames)
            {
                Console.WriteLine($"{tableName}");
            }
            dbUtiliy.InsertAccount(alikaan);            
            dbUtiliy.InsertAccount(ersen);            
            dbUtiliy.InsertAccount(taylan);

            var account = dbUtiliy.FindAccountByID(1);
            Console.WriteLine($"{account.Email},{account.Username},{account.Password}");            
            Console.ReadLine();
        }
    }
}
