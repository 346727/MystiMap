using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MystiMapWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCController : ControllerBase
    {
        // GET: api/Place/Categories
        [HttpGet("Categories")]
        public ActionResult<IEnumerable<CategoryModel>> GetCategories()
        {
            var categories = new List<CategoryModel>
            {
                new CategoryModel { Id = 1, Name = "Jedzenie" },
                new CategoryModel { Id = 2, Name = "Rozrywka" },
                new CategoryModel { Id = 3, Name = "Relaks" },
                new CategoryModel { Id = 4, Name = "Kontakt Społeczny" },
                new CategoryModel { Id = 5, Name = "Zakupy" },
                new CategoryModel { Id = 6, Name = "Aktywność Fizyczna" },
                new CategoryModel { Id = 7, Name = "Kawa" },
                new CategoryModel { Id = 8, Name = "Muzyka" },
                new CategoryModel { Id = 9, Name = "Natura" },
                new CategoryModel { Id = 10, Name = "Czas dla Siebie" },
                new CategoryModel { Id = 11, Name = "Cisza/Spokój" },
                new CategoryModel { Id = 12, Name = "Zabawa" },
                new CategoryModel { Id = 13, Name = "Historia" },
                new CategoryModel { Id = 14, Name = "Sztuka" },
                new CategoryModel { Id = 15, Name = "Interaktywnie" },
                new CategoryModel { Id = 16, Name = "Technologia" },
                new CategoryModel { Id = 17, Name = "Zabytki" },
                new CategoryModel { Id = 18, Name = "Na Zewnątrz" }
                // Dodaj pozostałe kategorie
            };

            return Ok(categories);
        }

        // GET: api/Place/Places
        [HttpGet("Places")]
        public ActionResult<IEnumerable<PlaceModel>> GetPlaces()
        {
            var places = new List<PlaceModel>
            {
                new PlaceModel { Id = 1, Name = "Rynek", Description = "Opis Rynku", Image = "https://pik.wroclaw.pl/wp-content/uploads/2018/11/Rynek_Wroclaw_-neirfy_stock.jpg" },
                new PlaceModel { Id = 2, Name = "Ogród Botaniczny", Description = "Opis Ogrodu Botanicznego", Image = "https://www.ogrodbotaniczny.wroclaw.pl/images/bg/ogrod1.jpg" },
                new PlaceModel { Id = 3, Name = "Wyspa Słodowa", Description = "Opis Wyspy Słodowej", Image = "https://www.batogospot.pl/wp-content/uploads/2021/10/wyspa-slodowa.jpeg" },
                new PlaceModel { Id = 4, Name = "Panorama Racławicka", Description = "Opis Panoramy Racławickiej", Image = "https://dzieje.pl/sites/default/files/styles/open_article_750x0_/public/201812/panorama_raclawicka.jpg?itok=PqZ3UZTN" },
                new PlaceModel { Id = 5, Name = "Kino Nowe Horyzonty", Description = "Opis Kina Nowe Horyzonty", Image = "https://miejscawewroclawiu.pl/wp-content/uploads/2022/07/kino-nowe-horyzonty-1200x675.jpeg" }
                // Dodaj pozostałe miejsca
            };

            return Ok(places);
        }
    }
}
