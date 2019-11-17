using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book) 
        {
            Console.WriteLine("Add");
        }


        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


    public class GenericList<T>
    {
        public void Add(T Value)
        {
            Console.WriteLine("Add Generic");
        }

        public T this[int index]
        {
            get { throw new NotImplementedException();}
        }

    }
}
