int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 < num2)
{
    Console.Write("Max =");
    Console.WriteLine(num2);
    Console.Write("Min =");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Max =");
    Console.WriteLine(num1);
    Console.Write("Min =");
    Console.WriteLine(num2);
}
