namespace Circle_Objects_Lab
{
  public class CircleObj //renamed from Circle as the system can't tell the differnce beteween the class circle and object circle
  {
    //properties
    public double radius { get; set; }

    //Constructor
    public CircleObj(double _radius)
    {
      radius = _radius;
    }
  
    //methods
    //public double CalculateCircumference()
    public double CalculateCircumference()
    {
      return 2 * (Math.PI * radius);
    }
    //public string CalculateFormattedCircumference()
    public string CalculateFormattedCircumference()
    {
      return FormatNumber(CalculateCircumference());
    }

    //public double CalculateArea()
    public double CalculateArea()
    {
      return Math.PI * (Math.Pow(radius, 2));
    }

    //public string CalculateFormattedArea()
    public string CalculateFormattedArea()
    {
      return FormatNumber(CalculateArea());
    }

    //private string FormatNumber()
    private string FormatNumber(double x)//this double comes from calc area or calc circumference
    {
      return Math.Round(x,2).ToString();
    }
  }
}
