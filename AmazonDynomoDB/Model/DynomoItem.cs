using System;
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AmazonDynomoDB.Model
{
    public class DynomoItem
    {
        private AmazonDynamoDBClient DynomoClient = new AmazonDynamoDBClient();

        public bool PutItem(string mail, string tableName, string id, string pw)
        {

            var request = new PutItemRequest
            {
                TableName = tableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    {"Id", new AttributeValue{S = mail } },
                    {"Mail", new AttributeValue{S = id } },
                    {"Username", new AttributeValue{S = id } },
                    {"Password", new AttributeValue{S = pw } },
                }
            };
            DynomoClient.PutItemAsync(request);
            //var response = new PutItemResponse();            
            return true;
        }

        public bool ScanItem(string tableName, string id, string pw)
        {
            var request = new ScanRequest
            {
                TableName = tableName,
            };
            var response = DynomoClient.ScanAsync(request);
            var result = response.Result;

            foreach (Dictionary<string, AttributeValue> item in response.Result.Items)
            {

            }
            return true;
        }
    }
}
