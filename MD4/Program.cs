
//1

int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age2 <= 65);
Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
bool e = (age1 >= 18) || (age2 <= 65);
Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);

//2

Console.WriteLine("Enter the age of the new candidate: ");
int age3 = int.Parse(Console.ReadLine());
if (age3 < 18)
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send email to candidate.");
}
else if (age3> 65)
{
    Console.WriteLine("Sorry, the selected age is too old");
    Console.WriteLine("Send email to candidate.");
}
else
{
    Console.WriteLine("Great, you can continue!");
}


// DateTime today = DateTime.Now;
// bool endOfMonthPaymentStarted = false;
//
// if (today.Date.Day == 20)
// {
//     Console.WriteLine("Please start end-of-month employee payments");
// }
// else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
// {
//     Console.WriteLine("Payments will be late!");
// }
// //else isn't required!


//3

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

switch (age)
{
    case < 18:
        Console.WriteLine("Too young to apply");
        break;
    case > 65:
        Console.WriteLine("Sorry, the selected age is too old");
        break;
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great, you can continue!");
        break;
}


   



