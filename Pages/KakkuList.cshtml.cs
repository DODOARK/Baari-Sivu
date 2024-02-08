using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using baari_sivu.Models;
using baari_sivu.Services;

namespace baari_sivu.Pages;

public class KakkuListModel : PageModel
{

    private readonly KakkuList _service;
    public List<Kakku> KakkuList { get;set; } = default!;

    private Cart _shoppingCart;

    public KakkuListModel(KakkuList service, Cart cart)
    {
        _shoppingCart = cart;
        _service = service;
    }

    public void OnGet()
    {
        KakkuList = _service.GetCakes();
    }

    public IActionResult OnPostAddToCart(Kakku kakku)
    {
        _shoppingCart.AddCake(kakku);

        return RedirectToAction("Get");
    }

}

