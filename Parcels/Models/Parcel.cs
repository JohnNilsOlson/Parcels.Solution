using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set;}
    public int Weight { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

      _instances.Add(this);
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