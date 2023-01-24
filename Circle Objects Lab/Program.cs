using Circle_Objects_Lab;


// Task: Calculate a circle’s circumference and area.
//
///
// What will the application do?

//*   The application prompts the user to enter a radius; the user may enter a decimal number.

//*   The application displays an error if the user enters invalid data and asks the user again for a radius.

//*   When the user enters valid data, the application calculates the area and circumference of the circle and
//rounds to the nearest 2 decimal places and prints out both.

//*   The application asks the user whether they want to do another.

//*   The application displays a “goodbye” message that also indicates the number of circles the user built when
//the user chooses not to continue.
///
// Build Specifications:
//
///
// 1) Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
//    a) public Circle(double radius)

//    b) public double CalculateCircumference()

//    c) public string CalculateFormattedCircumference()

//    d) public double CalculateArea()

//    e) public string CalculateFormattedArea()

//    f) private string FormatNumber(double x)
///g) h)     These two are optional
///    g) Define a member called radius. This member should be private. 
///    h) Define a property to get access to the class member: Radius 
// 2) For the value of pi, use the PI constant of the System.Math class.
//
///
// 3) Get the user input, create a Circle object, and display the circumference and area.
//

///Hints
///   Don’t mess up the formulas for circumference or area of a circle!
//
/// Extra Challenges:
///    a) Create a class named Validator and use its static methods to validate the data in this application.

List<CircleObj> allCircles = new List<CircleObj>();
Console.WriteLine("Welcome to the Circle Tester\n");
//loop program
bool runProgram = true;
//int Count = 0; //one way to make the counter
while (runProgram)
{
  Console.Write("Enter radius: ");
  double input = -1;
  //The application displays an error if the user enters invalid data and asks the user again for a radius.
  //use while looop with tryparse or try catch
  while (input < 0)
  {
    input = Validator.GetUserNumber();
    if (input <= 0)
    {
      Console.WriteLine("That was invalid try again with a number greater than 0.");
    }
  }
  //create circle object
  CircleObj myCircle = new CircleObj(input);
  //Count++;
  allCircles.Add(myCircle);
  Console.WriteLine($"Circumfrence: {myCircle.CalculateFormattedCircumference()}");
  Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");//if you do not put the '()' after the call method it will just show the name of the object
  while (runProgram = true)
  {
    Console.WriteLine("Continue? (y/n)");
    string answer = Console.ReadLine();

    if (answer == "y")
    {
      Console.WriteLine("Cool.");
      runProgram = true;
      Console.Clear();
      break;
    }
    else if (answer == "n")
    {
      runProgram = false;
      if (allCircles.Count < 2) // if (Count < 2)
      {
        Console.WriteLine($"You made {allCircles.Count} circle object.");  //  Console.WriteLine($"You made {Count} circle object.");
        Console.WriteLine("Goodbye!");
        break;
      }
      else
      {
        Console.WriteLine($"You made {allCircles.Count} circle objects."); //  Console.WriteLine($"You made {Count} circle objects.");
        Console.WriteLine("Goodbye!");
        break;
      }
    }
    else
    {
      Console.WriteLine($"{answer} is not a valid selection, please try again.");
    }
  }
}

