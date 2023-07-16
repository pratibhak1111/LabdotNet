namespace Book

{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            Console.WriteLine("Information of book 1:");
            Console.Write("Input name of the book: ");
            book1.Name = Console.ReadLine();
            Console.Write("Input the author: ");
            book1.Author = Console.ReadLine();

            Console.WriteLine("\nInformation of book 2:");
            Console.Write("Input name of the book: ");
            book2.Name = Console.ReadLine();
            Console.Write("Input the author: ");
            book2.Author = Console.ReadLine();

            Console.WriteLine("\nInserted information of the books:");
            Console.WriteLine("Book 1: Name = {0}, Author = {1}", book1.Name, book1.Author);
            Console.WriteLine("Book 2: Name = {0}, Author = {1}", book2.Name, book2.Author);

            Console.ReadLine();
        }
    }
}
 