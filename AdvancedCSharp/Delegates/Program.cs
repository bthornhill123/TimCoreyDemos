using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A delegate is an object that knows how to call a method or a group of methods
// It is a reference to a function

// Why do we need delegates?
// They are useful when creating applications that are extensible and flexible

// Interfaces or Delegates to acheive desired flexibility in an application?
    // Use delegates when an eventing desingn pattern is used
    // Or when the caller doesn't need to access other properties or methods on the object implementing the method

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            Console.ReadLine();
        }

        // This signature matches the signature of the PhotoFilterHandler delagate
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");

        }
    }
}
