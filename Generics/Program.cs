namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            var book = new Book { Isbn = "12133", Title = "CSharp" };

            var number = new List();
            number.Add(10);

            var books = new BookList();
            books.Add(book);

            var letters = new GenericList<string>();
            letters.Add("teste");



        }
    }
}
