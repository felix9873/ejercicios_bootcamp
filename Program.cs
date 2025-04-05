

int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
int nroGreather ;

if(num1 < num2)
{
    nroGreather = num2;

    if(num2 < num3)
    {
        nroGreather = num3;
        Console.WriteLine(nroGreather);
    }
    else
    {

        Console.WriteLine(nroGreather);
    }
    
}
else
{
    if(num1 > num3)
    {
        nroGreather = num1;
        Console.WriteLine(nroGreather);
    }
    else
    {
        nroGreather = num3;
        Console.WriteLine(nroGreather);
    }
}
