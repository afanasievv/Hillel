using Lesson26.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson26.Controllers
{
    public class AboutMeController
    {       
        public ActionResult Index()
        {
            // Отримання даних про "Про себе" з бази даних або з іншого джерела
            //AboutMe aboutMe = GetAboutMeData();

            return View(aboutMe);
        }
    }
}
