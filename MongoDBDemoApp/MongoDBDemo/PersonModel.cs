using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBDemo
{
    public class PersonModel
    {
        [BsonId] // Maps to "_id"
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")] // This demonstrates how to map different names between the database and the model (simply decorate the property)
        public DateTime DateOfBirth { get; set; }

    }
}
