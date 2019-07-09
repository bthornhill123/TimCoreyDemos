using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            // Configure the container for Autofac dependency injection
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>(); **** these lines can be swapped out at will ****
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            // This code matches up all classes in the utilities folder to interfaces with the same name (besides the preceding 'I', of course)
            // ****Very powerful****
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities")) // Targets the "Utilities" folder
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
