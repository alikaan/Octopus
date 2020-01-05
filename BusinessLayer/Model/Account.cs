using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;

namespace BusinessLayer.Model
{
    [DynamoDBTable("Account")]
    public class Account
    {
        [DynamoDBHashKey]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }        
    }
}
