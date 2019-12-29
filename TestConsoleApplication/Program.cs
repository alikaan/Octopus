using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonDynomoDB.Model;


namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string awsKeyId = "AKIAR52JXGF3ZTI6VQ67";
            string awsKeySecret = "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";
            DynomoTable dynomoTable = new DynomoTable(awsKeyId, awsKeySecret);

            dynomoTable.CreateTable("test");
            // The tcode provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
