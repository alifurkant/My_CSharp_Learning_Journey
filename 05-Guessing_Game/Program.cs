Random rnd = new Random();
byte num = (byte)(rnd.Next(0, 100));

int counter = 1;
int guess = default;

start:

if (counter > 6)
{
    Console.WriteLine("Unfortunately, your guess has expired. The number I kept was {0}.", num);
    goto Bitis;
}
else
{
    Console.WriteLine("Guess the number i keep between 0-100");

    guess = Convert.ToInt32(Console.ReadLine());
}

if (guess == num)
{
    Console.WriteLine("Congratulations, the number I kept was {0}. You guessed in {}", num, counter);
}
else if (guess < num)
{
    Console.WriteLine("Not correct. Higher please.");
    counter++;
    goto start;
}
else if (guess > num)
{
    Console.WriteLine("Not correct. Lower please.");
    counter++;
    goto start;
}

Bitis: Console.ReadLine();
