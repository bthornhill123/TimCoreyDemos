using System;

namespace Generics
{
    public partial class Utilities
    {
        // Types of Constraints
        // where T : ISomeInterface
        // where T : ClassName
        // where T : struct (T is a value type)
        // where T : class (T is a reference type)
        // where T : new() (T has a default constructor)
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable // Implements IComparable 
        { 
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething<T>(T value) where T : new() // Has a default constructot
        {
            var obj = new T();
        }
    }
}
