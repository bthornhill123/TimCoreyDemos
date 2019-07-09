// A delegate is an object that knows how to call a method or a group of methods
// It is a reference to a function

// Why do we need delegates?
// They are useful when creating applications that are extensible and flexible

// 2 types of generic delegates:
    // Action delegates - these don't return a value
    // Func delegates - these do return a value

using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo); - OLD WAY WITHOUT GENERIC DELEGATES

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }


    }
}
