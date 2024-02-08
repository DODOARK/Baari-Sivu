using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models;

public class Cake
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public CakeType Type { get; set; }

    [Range(1, 1000)]
    public int Price { get; set; }
}

public enum CakeType { suklaa, mansikka, juusto, herne }