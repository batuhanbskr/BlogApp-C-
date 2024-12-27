using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName ==  username).Select(x => x.Email).FirstOrDefault();
            var userId = c.Writers.Where(x => x.WriterMail == usermail).Select(x => x.WriterID).FirstOrDefault();

            //ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = bm.GetBlogListByWriter(userId).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
