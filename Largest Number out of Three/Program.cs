int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

if (first > second && first > third)
{
    Console.WriteLine("First");
}
else if (second > first && second > third)
{
    Console.WriteLine("Second");
}
else if (third > first && third > second)
{
    Console.WriteLine("Third");
}
