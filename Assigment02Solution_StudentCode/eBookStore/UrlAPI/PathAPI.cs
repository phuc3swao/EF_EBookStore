namespace eBookStore.UrlAPI
{
    public static class PathAPI
    {
        public const string FILTERBOOKODATA = "https://localhost:7231/api/Books?$filter=";

        public const string BOOK_FILTER_TITLE = "(contains(Title,'TITLE'))";

        public const string BOOK_FILTER_PRICE = "(Price gt Min and Price lt Max)";

        public const string GETALLBOOKS = "https://localhost:7231/api/Books";

        //https://localhost:7231/api/Books send with Books
        public const string CREATEBOOOK = "https://localhost:7231/api/Books";

        //https://localhost:7231/api/Books/3 them /+ id
        public const string GETBOOKBYID = "https://localhost:7231/api/Books";

        //https://localhost:7231/api/Books/18 send with id and Books
        public const string UPDATEBOOK = "https://localhost:7231/api/Books";

        //https://localhost:7231/api/Books/3 them /+ id
        public const string DELETEBOOK = "https://localhost:7231/api/Books";

        public const string GETALLPULISHER = "https://localhost:7231/api/Publishers";

        //GUI KEM Pulisher
        public const string CREATEPULISHER = "https://localhost:7231/api/Publishers";

        // GUI KEM /+ id
        public const string GETPULISHERBYID = "https://localhost:7231/api/Publishers";

        // send with id + pulisher
        public const string UPDATEPULISHER = "https://localhost:7231/api/Publishers";

        // /+ id
        public const string DELETEPULISHER = "https://localhost:7231/api/Publishers";

        //?email=phuc%40gmail.com&pass=123456
        public const string LOGIN = "https://localhost:7231/api/Auth";

        public const string AUTHOR = "https://localhost:7231/api/Authors";
    }
}
