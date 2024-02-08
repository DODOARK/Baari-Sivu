using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Models;
using Services;
using baari_sivu.Services;

namespace baari_sivu.Pages;

public class KakkuListModel : PageModel
{
    private readonly CakeService _service;
    public IList<Cake> KakkuList { get; set; } = default!;

    private Cart _shoppingCart;

    public KakkuListModel(CakeService service, Cart cart)
    {
        _shoppingCart = cart;
        _service = service; aa
    }

    public void OnGet()
    {
        KakkuList = _service.GetCakes();
    }

    public IActionResult OnPostAddToCart(Cake kakku)
    {
        _shoppingCart.AddCake(kakku);

        return RedirectToAction("Get");
    }

}

