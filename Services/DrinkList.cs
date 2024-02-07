using baari_sivu.Drinks;

namespace baari_sivu.Services;

public class DrinkList
{
    List<Drink> drinks = new List<Drink>();

    drinks.Add(Drink kalja = new Drink(Id = 1, Name = "Kalja", Price = "2.50", Size = "Small", Alcohol = "5.5%"));
    drinks.Add(Drink lonkero = new Drink(Id = 2, Name = "Lonkero", Price = "2.00", Size = "Small", Alcohol = "5.5%"));
    drinks.Add(Drink viski = new Drink(Id = 3, Name = "Viski", Price = "7.00", Size = "Medium", Alcohol = "45.0%"));
    drinks.Add(Drink vodka = new Drink(Id = 4, Name = "Vodka", Price = "8.00", Size = "Large", Alcohol = "38.0%"));
    drinks.Add(Drink jallu = new Drink(Id = 5, Name = "Jallu", Price = "8.50", Size = "Large", Alcohol = "38.0%"));
        
    public List<Drink> GetDrinks()
    {
        return this.drinks;
    }

    public void AddDrink(Drink drink)
    {
        drinks.Add(drink);
    }

    public void DeleteDrink(int id)
    {
        if (drinks[id] != null)
        {
            drinks.RemoveAt(id - 1);
       }           
    } 
}


