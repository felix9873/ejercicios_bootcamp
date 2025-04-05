
using System.Globalization;
using System.Threading.Channels;

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


Console.WriteLine("calcular el area ");



string inputUser = Console.ReadLine();

switch(inputUser)
{
    case "cuadrado":
        Console.WriteLine("ingresa los lados del cuadrado");

        Console.Write("ingresa el primer lado");
        float input = Convert.ToSingle( Console.ReadLine());
        Console.WriteLine();

        Console.Write("ingresa el segundo lado");
        float input2 = Convert.ToSingle(Console.ReadLine());

        float areaSquare = input * input2;

        Console.WriteLine($"el area del cuadrado es {areaSquare}");

        break;

    case "circulo":
        Console.WriteLine("ingresa el radio del circulo");

        float radius = Convert.ToSingle(Console.ReadLine());
        
        double area = Math.PI * (radius * radius);

        Console.WriteLine($"el area del circulo es {area}");

        break;

    case "rectangulo":

        Console.WriteLine("ingresa la base y la altura del rectangulo");

        Console.Write("ingresa la base del rectangulo");

        float baseRectangle = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("ingresa la altura del rectangulo");

        float height = Convert.ToSingle(Console.ReadLine());

        float areaRectagle = baseRectangle * height;

        Console.WriteLine($"el area del rectangulo {areaRectagle}");



        break;
        
}