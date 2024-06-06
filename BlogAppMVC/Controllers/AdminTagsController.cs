using BlogAppMVC.Data;
using BlogAppMVC.Models.Domain;
using BlogAppMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppMVC.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogAppDbContext _blogAppDbContext;
        public AdminTagsController(BlogAppDbContext blogAppDbContext)
        {
            _blogAppDbContext = blogAppDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to Tag domain model
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;

            var tag = new Tag { Name = name, DisplayName = displayName };

            _blogAppDbContext.Tags.Add(tag);
            _blogAppDbContext.SaveChanges();
            
            return View("Add");
        }
    }
}
