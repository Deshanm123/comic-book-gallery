using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {

             
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>blah blah spidy</p>",
                Artists = new Artist[]
                        {
                            new Artist
                            {
                                Name = "Dan Slott",
                                Role ="Script"

                            },
                            new Artist
                            {
                                Name = "Humberto Ramos",
                                Role  ="Pencils"
                            },
                            new Artist
                            {
                                Name = "Victor Olszba",
                                Role  ="Inks"
                            },
                            new Artist
                            {
                                Name = "HChris Elipoulus",
                                Role  ="Letters"
                            }
                            
                       }

             };

            return View(comicBook); 

        }
    }
}
