using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Polygon.Repositories.Mongo.Context
{
    public class ConnectionFactory
    {
        public static IMongoClient Build()
        {
            var client = new MongoClient("mongodb://kay:admin@cluster0-shard-00-00-5t1xe.mongodb.net:27017/admin?ssl=true");
            return client;
        }
    }
}
