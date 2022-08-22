Console.WriteLine("Select the dimensionality of the space.");
Console.WriteLine("For 2D -enter 1, for 3D - enter 2 ");
int a  = int.Parse(Console.ReadLine());
Double x1, x2, y1, y2, z1, z2, distance;
switch(a)
{
case 1:
Console.WriteLine("Enter the coordinate x1 :");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate x2 :");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate y1 :");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate y2 :");
y2 = Convert.ToDouble(Console.ReadLine());

distance  = Math.Sqrt(Math.Pow(x2-x1,2)) + (Math.Pow(y2-y1, 2));
Console.WriteLine($"The distance between two points in 2D space is {distance}");
break;

case 2: 
Console.WriteLine("Enter the coordinate x1 :");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate x2 :");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate y1 :");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate y2 :");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate z1 :");
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinate z2 :");
z2 = Convert.ToDouble(Console.ReadLine());


distance  = Math.Sqrt(Math.Pow(x2-x1,2)) + (Math.Pow(y2-y1, 2)) + (Math.Pow(z2-z1, 2));
Console.WriteLine($"The distance between two points in 3D space is {distance}");
break;
default:
Console.WriteLine("You entered a wrong character, please try again! ");
break;
}
