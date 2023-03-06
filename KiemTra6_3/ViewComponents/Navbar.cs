using Microsoft.AspNetCore.Mvc;
using KiemTra6_3.Repository;

namespace KiemTra6_3.ViewComponents
{
    public class Navbar:ViewComponent
    {
        private readonly ILoaiSpRepository _navbar;
        public Navbar(ILoaiSpRepository navSpRepository)
        {
            _navbar = navSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var navbar = _navbar.GetAllLoaiSp().OrderBy(x => x.HangSx);
            return View(navbar);
        }
    }
}
