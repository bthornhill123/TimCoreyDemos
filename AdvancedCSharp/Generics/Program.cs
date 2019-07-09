using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var dictionary = new GenericDictionary<string, int>();
            dictionary.Add("hello", 123);

            var number = new Nullable<int>(5);
            Console.WriteLine($"Has Value ?{ number.HasValue }");
            Console.WriteLine($"Value: { number.GetValueOrDefault() }");
        }
    }

    public class GenericDictionary<Tkey, TValue>
    {
        public void Add(Tkey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}
