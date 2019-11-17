using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegates
            // -  An object that knows how to call a method (or a group of methods)
            // -  A reference to a function


            // Why  do we need delegates?

            // - For designing extensible and flexible applications (eg frameworks)



            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;

            //Multi CastDelegate
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;


            processor.Process("photo.jpg", filterHandler);

        }


        //Other exemple

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }



    }
}
