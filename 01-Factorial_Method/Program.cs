Console.Write("Please enter a number : ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("factorial = {0}", factorial(num));


int factorial(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * factorial(num - 1);
    }
}