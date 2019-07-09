// A delegate is an object that knows how to call a method or a group of methods
// It is a reference to a function

// Why do we need delegates?
// They are useful when creating applications that are extensible and flexible

namespace Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }
}
