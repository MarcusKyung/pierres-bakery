namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public Bread(int quantity)
    {
      Loaves = quantity;
    }

    public int CalculateBreadTotalPrice()
    {
    int price = ((Loaves-(Loaves%3))/3)*10+(Loaves%3)*5;
    return price;
    }
  }
}