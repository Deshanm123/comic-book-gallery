using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public IActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            
           var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook); 

        }
        //public ActionResult Detail()
        //{
        //    var comicBook = new ComicBook()
        //    {   
        //        Id = 1,
        //        SeriesTitle = "The Amazing Spider-Man",
        //        IssueNumber = 700,
        //        DescriptionHtml = "<p>blah blah spidy</p>",
        //        Artists = new Artist[]
        //                {
        //                    new Artist
        //                    {
        //                        Name = "Dan Slott",
        //                        Role ="Script"

        //                    },
        //                    new Artist
        //                    {
        //                        Name = "Humberto Ramos",
        //                        Role  ="Pencils"
        //                    },
        //                    new Artist
        //                    {
        //                        Name = "Victor Olszba",
        //                        Role  ="Inks"
        //                    },
        //                    new Artist
        //                    {
        //                        Name = "HChris Elipoulus",
        //                        Role  ="Letters"
        //                    }
                            
        //               }

        //     };

        //    return View(comicBook); 

        //}
    }
}
