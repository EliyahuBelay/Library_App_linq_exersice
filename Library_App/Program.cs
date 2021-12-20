// See https://aka.ms/new-console-template for more information

namespace Library_App
{

    class Program
    {
        static void Main(string[] args)
        {
            //mission 11
            Random rnd = new Random();
            Book[] books = new Book[]
            {
                new Book("shipudan","eliyahu",rnd.Next(1,501)),
                new Book("game of thrones","belay",rnd.Next(1,501)),
                new Book("vikings","eliyahu",rnd.Next(1,501)),
                new Book("friends","beli",rnd.Next(1,501)),
                new Book("dragon ball","eliyahu",rnd.Next(1,501)),
                new Book("artur","klat",rnd.Next(1,501)),
            };
            var filteredBookGroupWriter = (from book in books
                                     group book by book.Writer);
            foreach (var book in filteredBookGroupWriter)
            {
                Console.WriteLine($"Group name : {book.Key}");
                foreach (Book obj in book)
                {
                    //Console.WriteLine($"name : {obj.Name}");
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            //mission 10
            //Random rnd = new Random();
            //Book[] books = new Book[]
            //{
            //    new Book("shipudan","eliyahu",rnd.Next(1,501)),
            //    new Book("game of thrones","belay",rnd.Next(1,501)),
            //    new Book("vikings","eliyahu",rnd.Next(1,501)),
            //    new Book("friends","beli",rnd.Next(1,501)),
            //    new Book("dragon ball","eliyahu",rnd.Next(1,501)),
            //    new Book("artur","klat",rnd.Next(1,501)),
            //};
            //var filteredBookGroup = (from book in books
            //                         group book by book.Writer);
            //foreach (var book in filteredBookGroup)
            //{
            //    Console.WriteLine($"Group name : {book.Key}");
            //    foreach (Book obj in book)
            //    {
            //        //Console.WriteLine($"name : {obj.Name}, writer : {obj.Writer},Num Of Pages : {obj.NumOfPages}");
            //    }
            //}
            ///////////////////////////////////////////////////////////////////////////////////////
            //mission 8
            //Random rnd = new Random();
            //Book[] books = new Book[]
            //{
            //    new Book("shipudan","eliyahu",rnd.Next(1,501)),
            //    new Book("game of thrones","belay",rnd.Next(1,501)),
            //    new Book("vikings","eli",rnd.Next(1,501)),
            //    new Book("friends","beli",rnd.Next(1,501)),
            //    new Book("dragon ball","bon",rnd.Next(1,501)),
            //    new Book("artur","klat",rnd.Next(1,501)),
            //};
            var filteredNameEndWithY = from book in books
                                       where book.Name.ToLower()[book.Name.Length - 1] == 'y'
                                       select book;
            foreach (var book in filteredNameEndWithY)
            {
                //Console.WriteLine(book.Name);
            }
            /////////////////////////////////////////////////////////////////////////////////////
            //mission 7
            //Random rnd = new Random();
            //Book[] books = new Book[]
            //{
            //    new Book("shipudan","eliyahu",rnd.Next(1,501)),
            //    new Book("game of thrones","belay",rnd.Next(1,501)),
            //    new Book("vikings","eli",rnd.Next(1,501)),
            //    new Book("friends","beli",rnd.Next(1,501)),
            //    new Book("dragon ball","bon",rnd.Next(1,501)),
            //    new Book("artur","klat",rnd.Next(1,501)),
            //};

            Book shortPageBook = books.ToList().Find(book => book.NumOfPages < 150);
            //Console.WriteLine(shortPageBook.Name);
            /////////////////////////////////////////////////////////////////////////////////////
            //mission 6
            //Random rnd = new Random();
            //Book[] books = new Book[]
            //{
            //    new Book("shipudan","eliyahu",rnd.Next(1,501)),
            //    new Book("game of thrones","belay",rnd.Next(1,501)),
            //    new Book("vikings","eli",rnd.Next(1,501)),
            //    new Book("friends","beli",rnd.Next(1,501)),
            //    new Book("dragon ball","bon",rnd.Next(1,501)),
            //    new Book("artur","klat",rnd.Next(1,501)),
            //};
            List<Book> list = books.Where(book => book.Writer.Length > 4 ).ToList();
            foreach (Book book in list)
            {
                //Console.WriteLine(book.Writer);
            }
            //////////////////////////////////////////////////////////////////////////////////
            //mission 5
            //Random rnd = new Random();
            //Book[] books = new Book[]
            //{
            //    new Book("shipudan","eliyahu",rnd.Next(1,501)),
            //    new Book("game of thrones","belay",rnd.Next(1,501)),
            //    new Book("vikings","eli",rnd.Next(1,501)),
            //    new Book("friends","beli",rnd.Next(1,501)),
            //    new Book("dragon ball","bon",rnd.Next(1,501)),
            //    new Book("artur","klat",rnd.Next(1,501)),
            //};
            
            var filteredBooks = from book in books
                                where book.NumOfPages > 200
                                select book;
            foreach (Book book in filteredBooks)
            {
                //Console.WriteLine(book.Name);
            }



            /////////////////////////////////////////////////////////////////////
            //mission 2
            Random random = new Random();
            int[] arrayAges = new int[10];
            for (int i = 0; i < arrayAges.Length; i++)
            {
                arrayAges[i] = random.Next(1,51);
            }
            var filteredAges = from age in arrayAges
                               where age > 20
                               select age;
            foreach (int age in filteredAges)
            {
                //Console.WriteLine(age);
            }


            //////////////////////////////////////////////////////////////////////
            //mission 1
            string[] arrayNames = new string[] { "nagato", "naruto", "kakashi", "sasuke", "eliyahu", "hitachi", "obito" };
            List<string> listNames = arrayNames.Where(x => x.ToLower()[0] == 'e').ToList();
            foreach (string name in listNames)
            {
                //Console.WriteLine(name);
            }

        }
    }
}
