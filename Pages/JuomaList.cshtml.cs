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

    public JuomaListModel(DrinkList service)
    {
        _service = service;
    }

    public void OnGet()
    {
        DrinkList = _service.GetDrinks();
    }

    /*public IActionResult OnPost()
    {
        if (!ModelState.IsValid || NewDrink == null)
        {
            return Page();
        }

        _service.Add(Newdrink);

        return RedirectToAction("Get");
    }*/
}

