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

        public async void InsertWord(Vocabulary word)
        {
            var context = new DynamoDBContext(DynomoClient);
            context.SaveAsync<Vocabulary>(word).Wait();
            await context.SaveAsync(word);            
        }

        public Account FindAccountByID(int id)
        {
            var context = new DynamoDBContext(DynomoClient);
            List<ScanCondition> queryConditions = new List<ScanCondition>();
            queryConditions.Add(new ScanCondition("ID", ScanOperator.Equal, id));
            var queryResult = context.ScanAsync<Account>(queryConditions).GetRemainingAsync();
            return queryResult.Result.FirstOrDefault();
        }       
        
        public void GetAllItmes(string tableName)
        {
            var request = new ScanRequest
            {
                TableName = tableName,                
            };
            //var context = new DynamoDBContext(DynomoClient);
            var response = DynomoClient.ScanAsync(request);
            foreach (var item in response.Result.Items)
            {
                PrintItem(item);
                Console.WriteLine("=====");
            }
        }
        
        public static void PrintItem(Dictionary<string, AttributeValue> attrs)
        {
            foreach (KeyValuePair<string, AttributeValue> kvp in attrs)
            {
                Console.Write(kvp.Key + " = ");
                PrintValue(kvp.Value);
            }
        }        

        public static void PrintValue(AttributeValue value)
        {
            // Binary attribute value.
            if (value.B != null)
            {
                Console.Write("Binary data");
            }
            // Binary set attribute value.
            else if (value.BS.Count > 0)
            {
                foreach (var bValue in value.BS)
                {
                    Console.Write("\n  Binary data");
                }
            }
            // List attribute value.
            else if (value.L.Count > 0)
            {
                foreach (AttributeValue attr in value.L)
                {
                    PrintValue(attr);
                }
            }
            // Map attribute value.
            else if (value.M.Count > 0)
            {
                Console.Write("\n");
                PrintItem(value.M);
            }
            // Number attribute value.
            else if (value.N != null)
            {
                Console.Write(value.N);
            }
            // Number set attribute value.
            else if (value.NS.Count > 0)
            {
                Console.Write("{0}", string.Join("\n", value.NS.ToArray()));
            }
            // Null attribute value.
            else if (value.NULL)
            {
                Console.Write("Null");
            }
            // String attribute value.
            else if (value.S != null)
            {
                Console.Write(value.S);
            }
            // String set attribute value.
            else if (value.SS.Count > 0)
            {
                Console.Write("{0}", string.Join("\n", value.SS.ToArray()));
            }
            // Otherwise, boolean value.
            else
            {
                Console.Write(value.BOOL);
            }

            Console.Write("\n");
        }
        public static Vocabulary GetWord(Dictionary<string, AttributeValue> attrs)
        {
            Vocabulary word = new Vocabulary();
            foreach (KeyValuePair<string, AttributeValue> kvp in attrs)
            {
                switch (kvp.Key)
                {
                    case "Word":
                        {
                            word.Word = kvp.Value.S;
                        }
                        break;
                    case "Meaning":
                        {
                            word.Meaning = kvp.Value.S;
                        }
                        break;
                    case "Link":
                        {
                            word.Link = kvp.Value.S;
                        }
                        break;
                    case "ID":
                        {
                            word.ID = Convert.ToInt32(kvp.Value.N);
                        }
                        break;
                    default:
                        break;
                }
            }
            return word;
        }
        public List<Vocabulary> GetVocabularies(string tableName)
        {
            List<Vocabulary> vocabularies = new List<Vocabulary>();
            var request = new ScanRequest
            {
                TableName = tableName,
            };
            //var context = new DynamoDBContext(DynomoClient);
            var response = DynomoClient.ScanAsync(request);
            foreach (var item in response.Result.Items)
            {
                vocabularies.Add(GetWord(item));
            }
            return vocabularies;
        }

    }
}