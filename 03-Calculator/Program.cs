char oper;
Console.WriteLine("Please enter 2 numbers for calculator...");
Console.Write("Number 1 : ");
double num1 = Convert.ToDouble(Console.ReadLine());
double Answer = default;
start:
Console.Write("Number 2 : ");
double num2 = Convert.ToDouble(Console.ReadLine());
start2:
Console.Write("Please enter the arithmetic operation \nAddition: a\nSubstraction: s\nMultiplication x\nDivision: d\nOperation :");

oper = Convert.ToChar(Console.ReadLine());

if (oper != 'a' && oper != 's' && oper != 'x' && oper != 'd' && oper != 'A' && oper != 'S' && oper != 'X' && oper != 'D')
{
    Console.WriteLine("Wrong Operator Error!");
    goto start2;
}

if ((oper != 'D' || oper != 'd') && num2 == 0)
{
    Console.WriteLine("Division by 0 Error..!");
    goto start;
}

if (oper == 'd' || oper == 'D')
{
    Answer = num1 / num2;
}
if (oper == 'x' || oper == 'X')
{
    Answer = num1 * num2;
}
if (oper == 's' || oper == 'S')
{
    Answer = num1 - num2;
}
if (oper == 'a' || oper == 'A')
{
    Answer = num1 + num2;
}

Console.WriteLine("Answer : {0}", Answer);