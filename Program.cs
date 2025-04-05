
using System.Globalization;

Console.WriteLine("encontrar el mayor numero");

Console.WriteLine("ingresa 3 numeros");

Console.Write("ingresa el primer numero: ");

int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

Console.Write("ingresa el segundo numero: ");
int num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

Console.Write("ingresa el tercer numero: ");
int num3 = Convert.ToInt16(Console.ReadLine());
int largestNumer ;

if(num1 < num2)
{
    largestNumer = num2;

    if(num2 < num3)
    {
        largestNumer = num3;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    else
    {

        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    
}
else
{
    if(num1 > num3)
    {
        largestNumer = num1;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    else
    {
        largestNumer = num3;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
}