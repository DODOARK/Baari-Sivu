using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using baari_sivu.Drinks;
using baari_sivu.Services;

namespace baari_sivu.Pages;

public class JuomaListModel : PageModel
{

    [BindProperty]
    public Drink NewDrink { get; set; } = default!;

    private readonly DrinkList _service;
    public List<Drink> DrinkList { get;set; } = default!;

    private Cart _shoppingCart;

    public JuomaListModel(DrinkList service, Cart cart)
    {
        _shoppingCart = cart;
        _service = service;
    }

    public void OnGet()
    {
        DrinkList = _service.GetDrinks();
    }

    public IActionResult OnPostAddToCart(Drink drink)
    {
        _shoppingCart.AddDrink(drink);

        return RedirectToAction("Get");
    }

}

