using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Context
{
    public class MongoContext : IDbContext
    {
        public string ConnectionString {get; set;}
        public string string DateBase {get; set; }
        public IMongoDateBase Context
        {
            get
            {
                MongoUrl url = new MongoUrl(ConnectionString);
                MongoClient client = new MongoClient(url);
                return client.DateBase(this.DateBase);
            }
        }
    }
}