using baari_sivu.Drinks;
using baari_sivu.Pages;

namespace baari_sivu.Services;

public class Cart
{
    List<Drink> shopping = new List<Drink>();

    public void AddDrink(Drink drink)
    {
        shopping.Add(drink);
    }

    public void DeleteDrink(int id)
    {
        shopping.RemoveAt(id - 1);
    }
}