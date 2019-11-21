using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = "The next film about strangers are make by person with horses, bla bla bla bla";

            var shorterPost = post.Shorten(3);


            Console.WriteLine(shorterPost);
        }
    }
}
