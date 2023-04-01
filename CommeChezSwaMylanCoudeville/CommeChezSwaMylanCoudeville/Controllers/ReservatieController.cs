using CommeChezSwaMylanCoudeville.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommeChezSwaMylanCoudeville.Controllers
{
    public class ReservatieController : Controller
    {
        //GET-REQUESTS met URL in browser
        public IActionResult OverviewReservations()
        {
            IEnumerable<Reservatie> reservaties = ReservatieRepository.GetAll();
            return View(reservaties);
        }
        public IActionResult CreateReservation()
        {
            return View();
        }
        public IActionResult DetailReservation(int id)
        {
            return View(ReservatieRepository.Get(id));
        }
        //POST-REQUEST formulier verstuurd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReservation(Reservatie userModel)
        {
            if (ModelState.IsValid)
            {
                ReservatieRepository.Add(userModel);
                return RedirectToAction("Success");
            }
            else
            {
                userModel.Akkoord = false;
                return View(userModel);
            }
        }
        [HttpPost]
        public IActionResult OverviewReservations(int id)
        {
            ReservatieRepository.Delete(ReservatieRepository.Get(id));
            IEnumerable<Reservatie> reservaties = ReservatieRepository.GetAll();
            return View(reservaties);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
