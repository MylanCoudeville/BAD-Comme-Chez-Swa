using CommeChezSwaMylanCoudeville.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommeChezSwaMylanCoudeville.Controllers
{
    public class MenuController : Controller
    {
        private MenuRepository _menuRepository = new MenuRepository();

        public IActionResult ShowMenu(string? type)
        {
            if (type != null)
            {
                MenuTypeViewModel menuTypeViewModel = new MenuTypeViewModel()
                {
                    GeselecteerdMenu = _menuRepository.GetByType(type),
                    Menus = _menuRepository.GetAll()
                };
                return View(menuTypeViewModel);
            }
            return View(new MenuTypeViewModel() { Menus = _menuRepository.GetAll()});
        }
    }
}
