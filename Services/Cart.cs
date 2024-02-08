using baari_sivu.Models;
using baari_sivu.Pages;

namespace baari_sivu.Services;

public class Cart
{
    List<Kakku> shopping = new List<Kakku>();

    public void AddCake(Kakku kakku)
    {
        shopping.Add(kakku);
    }

    public void DeleteCake(int id)
    {
        shopping.RemoveAt(id - 1);
    }

    public List<Kakku> GetShoppingList()
    {
        return shopping;
    }
}