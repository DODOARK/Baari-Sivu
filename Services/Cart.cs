using Models;
using baari_sivu.Pages;

namespace baari_sivu.Services;

public class Cart
{
    List<Cake> shopping = new List<Cake>();

    public void AddCake(Cake kakku)
    {
        shopping.Add(kakku);
    }

    public void DeleteCake(int id)
    {
        shopping.RemoveAt(id - 1);
    }

    public List<Cake> GetShoppingList()
    {
        return shopping;
    }
}