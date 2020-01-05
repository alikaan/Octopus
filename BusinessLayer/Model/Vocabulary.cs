using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
   
    [DynamoDBTable("Vocabulary")]
    public class Vocabulary
    {
        [DynamoDBHashKey]
        public int VocabularyID { get; set; }
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string Link { get; set; }
    }    
}
