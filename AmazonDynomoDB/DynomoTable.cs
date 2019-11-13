using System;
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AmazonDynomoDB
{
    public class DynomoTable
    {
        private AmazonDynamoDBClient DynomoClient = new AmazonDynamoDBClient();

        public void CreateTable(string tableName)
        {
            var request = new CreateTableRequest
            {
                TableName = tableName,
                AttributeDefinitions = new List<AttributeDefinition>()
                {
                    new AttributeDefinition
                    {
                        AttributeName = "Id",
                        AttributeType = "N"
                    }
                },
                KeySchema = new List<KeySchemaElement>()
                {
                    new KeySchemaElement
                    {
                        AttributeName = "Id",
                        KeyType = "HASH"  //Partition key
                    }
                },
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 10,
                    WriteCapacityUnits = 5
                }
            };
            var response = DynomoClient.CreateTableAsync(request);
        }

        public void DeleteTable(string tableName)
        {
            var request = new DeleteTableRequest
            {
                TableName = tableName
            };
            var response = DynomoClient.DeleteTableAsync(request);
        }

        public void UpdateTable(string tableName)
        {
            var request = new UpdateTableRequest()
            {
                TableName = tableName,
                ProvisionedThroughput = new ProvisionedThroughput()
                {
                    ReadCapacityUnits = 6,
                    WriteCapacityUnits = 7
                }
            };
            var response = DynomoClient.UpdateTableAsync(request);
            WaitUntilTableIsReady(tableName);
        }

        public void ListTable(string tableName)
        {

        }
        public void WaitUntilTableIsReady(string tableName)
        {
            string status = null;
            // Let us wait until table is created. Call DescribeTable.
            do
            {
                System.Threading.Thread.Sleep(5000); // Wait 5 seconds.
                try
                {
                    var res = DynomoClient.DescribeTableAsync(new DescribeTableRequest
                    {
                        TableName = tableName
                    });
                }
                catch (ResourceNotFoundException)
                {
                    // DescribeTable is eventually consistent. So you might
                    // get resource not found. So we handle the potential exception.
                }
            } while (status != "ACTIVE");
        }
    }
}
