// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("input the first number; ");
int firstvalue = int.Parse(Console.ReadLine());
Console.WriteLine("input the second number; ");
int secondvalue = int.Parse(Console.ReadLine());
Console.WriteLine("press 1. for addition   2. for subtraction    3. for multiplication    4. for divvision");
int operation = int.Parse(Console.ReadLine());
if(operation == 1)
{
    int result = firstvalue + secondvalue;
    Console.WriteLine("the result is;" + result);
}
else if (operation == 2)
{
    int result = firstvalue - secondvalue;
    Console.WriteLine("the result is; " + result);
}
else if (operation == 3)
{
    int result = firstvalue * secondvalue;
    Console.WriteLine("the result is; " + result);
}
else if (operation == 4)
{
    int result = firstvalue / secondvalue;
    Console.WriteLine("the result is; " + result);
}
else
{
    Console.WriteLine("inappropriate input");   
}