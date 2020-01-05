using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Model
{
    public class DynomoDBUtility
    {
        private AmazonDynamoDBClient DynomoClient;
        public string TableName { get; set; }
        private string KeyId { get; set; }
        private string KeyAccess { get; set; }
        public Amazon.RegionEndpoint Region { get; set; }

        public DynomoDBUtility(string awsKeyId, string awsKeyAccess, Amazon.RegionEndpoint awsRegion)
        {
            this.KeyId = awsKeyId;
            this.KeyAccess = awsKeyAccess;
            this.Region = awsRegion;
            var awsCredentials = new BasicAWSCredentials(this.KeyId, this.KeyAccess);
            DynomoClient = new AmazonDynamoDBClient(awsCredentials, this.Region);
        }
        public DynomoDBUtility()
        {
            this.KeyId = "AKIAR52JXGF333RW2HGL";
            this.KeyAccess = "E5Q17jtWAT1LbRYbBHohxk9WkGV4aOZFFcZF0oBw";
            this.Region = Amazon.RegionEndpoint.USEast1;

            var awsCredentials = new BasicAWSCredentials(this.KeyId, this.KeyAccess);
            DynomoClient = new AmazonDynamoDBClient(awsCredentials, Region);
        }
        private void SetCredentials(string awsKeyId, string awsKeyAccess)
        {
            this.KeyId = awsKeyId;
            this.KeyAccess = awsKeyAccess;
            var awsCredentials = new BasicAWSCredentials(this.KeyId, this.KeyAccess);
            DynomoClient = new AmazonDynamoDBClient(awsCredentials);
        }
        public List<string> GetTables()
        {
            var response = DynomoClient.ListTablesAsync();
            return response.Result.TableNames;
        }

        public void CreateTable(string tableName, string partionKeyName, ScalarAttributeType partitionKeyType)
        {
            var tableResponse = GetTables();
            if (!tableResponse.Contains(tableName))
            {
                var response = DynomoClient.CreateTableAsync(new CreateTableRequest
                {
                    TableName = tableName,
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement
                        {
                            AttributeName = partionKeyName,
                            KeyType = KeyType.HASH
                        }
                    },
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition {
                            AttributeName = partionKeyName,
                            AttributeType = partitionKeyType
                        }
                    },
                    ProvisionedThroughput = new ProvisionedThroughput
                    {
                        ReadCapacityUnits = 3,
                        WriteCapacityUnits = 3
                    },
                });
                Console.WriteLine($"HTTP Response : {response.Result.HttpStatusCode}");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine($"Table Status : {response.Result.TableDescription.TableStatus}");                                
            }
            else
            {
                Console.WriteLine($"{tableName} isimli tablo zaten var.");
            }
        }
        public async void InsertAccount(Account account)
        {
            var context = new DynamoDBContext(DynomoClient);            
            context.SaveAsync<Account>(account).Wait();
            await context.SaveAsync(account);
        }

        public Account FindAccountByID(int id)
        {
            var context = new DynamoDBContext(DynomoClient);
            List<ScanCondition> queryConditions = new List<ScanCondition>();
            queryConditions.Add(new ScanCondition("ID", ScanOperator.Equal, id));
            var queryResult = context.ScanAsync<Account>(queryConditions).GetRemainingAsync();
            return queryResult.Result.FirstOrDefault();
        }       
    }
}
