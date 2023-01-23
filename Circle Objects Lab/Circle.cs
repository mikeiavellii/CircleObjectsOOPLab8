namespace Circle_Objects_Lab
{
  public class Circle
  {
    //properties
    public double radius { get; set; }
    public double Circumference { get; set; }
    public double Area { get; set; }

    //Constructor
    public Circle(double _radius)
    {
      radius = _radius;
      Circumference = CalculateCircumference(_radius);
      Area = CalculateArea(_radius);
    }


    public Circle()    //Overloaded = default
    {
      radius = 5;
      Circumference = CalculateCircumference(5);
      Area = CalculateArea(5);

    }

    //methods
    //public double CalculateCircumference()
    public double CalculateCircumference(double radius)
    {
      Circumference = 2 * (Math.PI * radius);
      return Circumference;
    }
    //public string CalculateFormattedCircumference()
    public string CalculateFormattedCircumference(double x)
    {
      Circumference = 2 * (Math.PI * radius);
      return Math.Round(Circumference, 2).ToString();
    }


    //public double CalculateArea()
    public double CalculateArea(double radius)
    {
      Area = Math.PI * (Math.Pow(radius, 2));
      return Area;
    }
    //public string CalculateFormattedArea()
    public string CalculateFormattedArea(double x)
    {
      Area = Math.PI * (Math.Pow(radius, 2));
      return Math.Round(Area, 2).ToString();
    }
  //private string FormatNumber(double x)


}
}
