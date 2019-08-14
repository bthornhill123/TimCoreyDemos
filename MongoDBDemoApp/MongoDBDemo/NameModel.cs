using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBDemo
{
    public class NameModel
    {
        [BsonId] // Maps to "_id"
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
