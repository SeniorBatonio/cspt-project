using CSPT.Data.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSPT.Mongo
{
    public class CsptContext
    {
        IMongoDatabase database;

        public IMongoCollection<Post> Posts { get; set; }
        public IMongoCollection<About> About { get; set; }

        public CsptContext(string connectionString)
        {
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase(connection.DatabaseName);

            Posts = database.GetCollection<Post>(nameof(Post));
            About = database.GetCollection<About>(nameof(About));
        }
    }
}
