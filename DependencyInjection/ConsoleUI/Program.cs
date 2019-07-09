using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This demo app demostrates a simulation of some services such as processesing, loading, and saving data.
// The app (at the start) does not conform to the dependency inversion principle
// The BusinessLogic class is directly tied to the Logger and DataAccess classes, for example

// Benefits of Dependency Injection
    // 1. It allows for unit testing without having to actually touch REAL resources. For example, in the ProcessData() method,
    // you can create a class that implements IDataAccess at test time that doesn't actually modify any data. Then, at run time,
    // the real object that implements IDataAccess can be used. If done right, testing can be done without actually touching real 
    // data or log files.
    // 2. Switching out systems (For example: a logging system). As long as the same interface is implemented, the code doesn't have to change at all.

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                // From the top down, these few lines of code instantiate/inject all of the needed objects through the constructors of the dependent objects.
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
