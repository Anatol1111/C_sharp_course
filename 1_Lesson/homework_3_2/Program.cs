int num1 = int.Parse(Console.ReadLine()); // 2
int num2 = int.Parse(Console.ReadLine()); // 3
int num3 = int.Parse(Console.ReadLine()); // 7
int MAX = 0;

if (num1 > num2)
{    
    MAX = num1;
}
if (num3 > MAX)
{    
    MAX = num3;
}
else 
{
    MAX = num1;
}    

Console.WriteLine(MAX);
