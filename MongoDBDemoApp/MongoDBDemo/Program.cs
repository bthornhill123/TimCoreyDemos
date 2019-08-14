using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // The following line will create a database called "AddressBook" if it does not already exist
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Joe",
            //    LastName = "Smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "400 East 100 Oak Street",
            //        City = "Orem",
            //        State = "UT",
            //        ZipCode = "84058"
            //    }
            //};

            //db.InsertRecord("Users", person);

            //var records = db.LoadRecords<PersonModel>("Users");

            //foreach (var rec in records)
            //{
            //    Console.WriteLine($"{ rec.Id }: { rec.FirstName } { rec.LastName }");

            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine($"{ rec.PrimaryAddress.City }");
            //    }
            //    Console.WriteLine();
            //}

            var records = db.LoadRecords<NameModel>("Users");

            foreach (var rec in records)
            {
                Console.WriteLine($"{ rec.FirstName } { rec.LastName }");
                Console.WriteLine();
            }

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("076996c7-30a4-407b-8d73-22ed61f792ff"));
            //oneRec.DateOfBirth = new DateTime(1997, 3, 3, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }
}
