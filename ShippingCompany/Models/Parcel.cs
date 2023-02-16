namespace ShippingCompany.Models
{
  public class Parcel
  {
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }
    public double PricePerSqInch = .01;

    // make list???

    // constructor
    public Parcel (double height, double width, double depth)
    {
      Height = height;
      Width = width;
      Depth = depth;
    }

    public double GetVolume()
    {
      Volume = Height * Width * Depth;
      return Volume;
    }

    public double CostToShip()
    {
      double costToShip = Volume * PricePerSqInch;
      return costToShip;
    }
  }
}