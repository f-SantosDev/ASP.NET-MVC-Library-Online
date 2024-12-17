namespace ASP_Net_MVC_Library_Online.Models
{
    public static class Repository
    {
        public static List<Book> _booksDB = new List<Book>();
        public static int id;

        public static IEnumerable<Book> BooksDB
        {
            get { return _booksDB; }
        }

        public static void Insert(Book record)
        {
            id++;
            record.ID = id;
            _booksDB.Add(record);
        }

        public static void Delete(Book record)
        {
            _booksDB.Remove(record);
        }
    }
}
