namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set;}
    public int Weight { get; set; }

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