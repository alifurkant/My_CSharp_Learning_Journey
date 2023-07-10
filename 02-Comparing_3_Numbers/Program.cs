Console.WriteLine("Please enter 3 numbers for comparing \n\n");

Console.Write("Please enter the first number : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the third number : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num1;
int median = default;

if (num2 >= max) //if statements for finding max
{
    max = num2;
}
if (num3 >= max)
{
    max = num3;
}
if (num2 <= min)//if statements for finding min
{
    min = num2;
}
if (num3 <= min)
{
    min = num3;
}
median = num1 + num2 + num3 - min - max; //an equation for findind median
Console.WriteLine($"max : {max}");
Console.WriteLine($"median : {median}");
Console.WriteLine($"min : {min}");
Console.ReadLine();
