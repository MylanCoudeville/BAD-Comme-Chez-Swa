using CommeChezSwaMylanCoudeville.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommeChezSwaMylanCoudeville.Controllers
{
    public class ReservatieController : Controller
    {
        //GET-REQUEST met URL in browser
        public IActionResult CreateReservation()
        {
            return View();
        }
        //POST-REQUEST formulier verstuurd
        [HttpPost]
        public IActionResult CreateReservation(RegistratieReservatieModel userModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(userModel);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
