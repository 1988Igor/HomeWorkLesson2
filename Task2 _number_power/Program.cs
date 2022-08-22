Console.Write("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(a =  Math.Pow(a, 2));
Console.WriteLine(b =  Math.Pow(b, 2));


if (a==b)
{
    Console.WriteLine("The number is the square of the other ");

}

else
{
    Console.WriteLine("Neither number is the square of the other");

}