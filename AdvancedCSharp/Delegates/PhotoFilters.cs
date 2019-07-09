using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("ApplyBrightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("ApplyContrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}
