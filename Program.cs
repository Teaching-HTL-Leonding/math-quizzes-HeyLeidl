int n1 = 0;
int n2 = 0;
int counter = 0;
string fizz = "Fizz";
string buzz = "Buzz";

Console.WriteLine("Please enter start value [1..int]:");
n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Please enter start value [{n1 + 1}..int]: ");
n2 = int.Parse(Console.ReadLine()!);

for (int i = 0; i < 100; i++)
{
    Console.Write("*");
}

Console.WriteLine("");

while (n1 <= n2)
{
    if (n1 % 3 == 0 && n1 % 5 != 0)
    {
        Console.Write($"   {fizz}");
    }
    else if (n1 % 5 == 0)
    {
        Console.Write($"   {buzz}");
    }
    else if (n1 % 3 == 0 && n1 % 5 == 0)
    {
        Console.Write($"   {fizz}{buzz}");
    }
    else
    {
        Console.Write($"  {n1}");

    }

    if (counter % 10 == 0 && counter != 0)
    {
        Console.WriteLine();
    }
    n1++;
    counter++;
}