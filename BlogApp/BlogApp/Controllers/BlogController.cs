using BlogApp.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        BlogDataContext _db = new BlogDataContext();

        [AllowAnonymous]
        public ActionResult Index() 
        {
            var blogs = _db.Blogs.ToList();
            return View(blogs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _db.Blogs.Add(blog);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        [AllowAnonymous]
        public ActionResult Blog(int id)
        {
            var blog = _db.Blogs.Find(id);
            return View(blog);
        }

        
        [HttpPost]
        public ActionResult Blog(int id, Comment newComment)
        {
            if (ModelState.IsValid)
            {
                newComment.blog = _db.Blogs.Find(id);
                _db.Comments.Add(newComment);
                _db.SaveChanges();
                return RedirectToAction("Blog", new { Id = id });
            }
            var blog = _db.Blogs.Find(id);
            return View(blog);
        }


        public ActionResult Edit(int id)
        {
            var blog = _db.Blogs.Find(id);
            return View(blog);
        }

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(blog).State = EntityState.Modified;
                _db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(blog);
        }
    }
}