namespace ConsoleApp2
{
    internal class Program
    {
        public class PhotoBook
        {
            private int numPages;
            public int GetNumberPages()
            {
                return numPages;
            }
            public PhotoBook()
            {
                numPages = 16;
            }
            public PhotoBook(int photoBookPages)
            {
                numPages = photoBookPages;
            }
        }

        public class BigPhotoBook
        {
            private int numPages;
            public int GetNumberPages()
            {
                return numPages;
            }
            public BigPhotoBook()
            {
                numPages = 64;
            }
        }
        static void Main(string[] args)
        {
            PhotoBook defaultPhotoBook = new PhotoBook();
            Console.WriteLine("Default Photo Book Pages: " + defaultPhotoBook.GetNumberPages());

            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine("Changed Photo Book Pages: " + photoBook1.GetNumberPages());

            BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
            Console.WriteLine("Large Photo Book Pages: " + bigPhotoBook1.GetNumberPages());
        }
    }
}