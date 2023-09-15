using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
     
        private static ComicBook[] _comicBooks = new ComicBook[]{
                 new ComicBook()
                  {
                    SeriesTitle = "The Amazing Spider-Man",
                    IssueNumber = 700,
                    DescriptionHtml = "<p>blah blah spidy</p>",
                    Artists = new Artist[]
                           {
                                new Artist{ Name = "Dan Slott",Role ="Script" },
                                new Artist{ Name = "Humberto Ramos",Role  ="Pencils"},
                                new Artist{ Name = "Victor Olszba", Role  ="Inks"},
                                new Artist{ Name = "HChris Elipoulus", Role  ="Letters"}
                           },
                    Favorite = false
                 },
                 new ComicBook()
                  {
                        SeriesTitle = "The Amazing Spider-Man",
                        IssueNumber = 657,
                        DescriptionHtml = "<p>blah blah spidy 657</p>",
                        Artists = new Artist[]
                                {
                                      new Artist{ Name = "Dan Slott",Role ="Script" },
                                      new Artist{ Name = "Humberto Ramos",Role  ="Pencils"},
                                      new Artist{ Name = "Victor Olszba", Role  ="Inks"},
                                      new Artist{ Name = "HChris Elipoulus", Role  ="Letters"}
                                 },
                        Favorite = false
                 },
        };
        

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
            
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach( var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}
