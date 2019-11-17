using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class List
    {
        public void Add(int number)
        {
            Console.WriteLine("Add");
        }


        public int this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }
}
