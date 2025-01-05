namespace ASP_Net_MVC_Library_Online.Models
{
    public static class Repository
    {
        private static List<Book> _booksDB = new List<Book>();
        private static int _id;

        public static IEnumerable<Book> BooksDB
        {
            get { return _booksDB; }
        }

        public static void Insert(Book record)
        {
            id++;
            record.ID = _id;
            _booksDB.Add(record);
        }

        public static void Delete(Book record)
        {
            _booksDB.Remove(record);
        }
    }
}
