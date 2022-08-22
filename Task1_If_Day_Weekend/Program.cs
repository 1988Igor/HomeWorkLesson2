Console.WriteLine("Enter the Day of the Week (1 to 7) ");
int a = int.Parse(Console.ReadLine());

switch(a)
{
        case 1: case 2: case 3: case 4: case 5: 

    Console.WriteLine("Weekday");
    break;

        case 6: case 7:

    Console.WriteLine("Weekend");
    break;

    default:
    Console.WriteLine("This number is wrong, please try again!!");
    break;

}