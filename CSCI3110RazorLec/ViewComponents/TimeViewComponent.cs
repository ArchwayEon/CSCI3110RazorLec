using Microsoft.AspNetCore.Mvc;

namespace CSCI3110RazorLec.ViewComponents;

// Note: Name must end with ViewComponent
public class TimeViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var time = DateTime.Now;
        return View(time);
    }
}
