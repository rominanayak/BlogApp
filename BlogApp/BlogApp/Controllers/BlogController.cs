using BlogApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        BlogDataContext _db = new BlogDataContext();

        public ActionResult Index() 
        {
            var blogs = _db.Blogs.ToList();
            return View(blogs);
        }
    }
}