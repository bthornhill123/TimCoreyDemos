using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // By only having objects 'newed' up within a Factory, it follows the dependency inversion principle.
    // Don't confuse dependency inversion with dependency injection
        // Dependency injection is one of the solutions to abide by the dependency inversion principle
        // The methods in this demo DONT use dependency injection, but rather interfaces for extraction and a factory
    // Dependency inversion principle says that things should depend on common abstractions rather than depending on each other
    // NOTE: It was easy to add functionality for texting rather than emailing because they both relied on the abstract IMessageSender interface
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
