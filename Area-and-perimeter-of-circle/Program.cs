
Console.WriteLine("Let's find out the area and perimeter of a circle!");
Console.WriteLine("Enter the radius of the circle in centimeters: ");

string radiusString = Console.ReadLine();
double radiusInteger = Convert.ToDouble(radiusString);

double area = Math.PI * Math.Pow(radiusInteger, 2);
Console.WriteLine("The area of the circle is: " + Math.Round(area, 2) + "cm^2");

double perimeter = 2 * Math.PI * radiusInteger;
Console.WriteLine("\nThe perimeter of the circle is: " + Math.Round(perimeter, 2) + "cm^2");


