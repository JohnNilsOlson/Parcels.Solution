using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parcels.Models
{
  public class Parcel
  {
    [Required] public int Length { get; set; }
    [Required] public int Width { get; set; }
    [Required] public int Height { get; set; }
    [Required] public int Weight { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
    public int Volume()
    {
      return (Length * Width * Height);
    }

    public int CostToShip()
    {
      int baseCost = 5;
      baseCost += Volume()/2;
      baseCost += Weight;
      return baseCost;
    }
  }
}