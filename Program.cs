Console.Clear();

Console.WriteLine("Type a number to start the hailstone Sequence");
int i = int.Parse(Console.ReadLine()!);

while (i != 1)
{
    if (i % 2 == 0)
    {
        i = i / 2;
        Console.Write("" + i + " ");
    }
    else
    {
        i = (3 * i) + 1;
        Console.Write("" + i + " ");
    }
}