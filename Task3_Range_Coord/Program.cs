Console.WriteLine("Enter a number of quarter (1 to 4) ");
int a  = int.Parse(Console.ReadLine());
switch(a)
{
    case 1:
        Console.WriteLine("x>0, y>0");
    break;

    case 2 :
         Console.WriteLine("x<0, y>0");
    break;

    case 3:
        Console.WriteLine("x<0, y<0");
    break;

    case 4:
        Console.WriteLine("x>0, y<0");
    break;

    default:
        Console.WriteLine("This number is wrong, please enter a number of quarter (1 to 4) !!!");
    break;
}