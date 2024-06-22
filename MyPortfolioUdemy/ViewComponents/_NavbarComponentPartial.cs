using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
//metodların ismi genellike invoke olarak adlandırılır.
//_HeadComponent.cs class'ının  view'lerini aynı isimdeki klasörde tutucam 
//COMPONENTS klasörünün içinde klasör

