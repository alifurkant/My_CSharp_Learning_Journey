// classifying_characters_with_asciiTable
Console.Write("Please enter a character : ");
char ch = Convert.ToChar(Console.ReadLine());

//Conversion from char type variable to byte type variable.
byte ch_byte = Convert.ToByte(ch);


//Printing the class of user's input according to ASCII Table. 

if ((ch_byte > 32 && ch_byte < 48) || (ch_byte > 57 && ch_byte < 65) || (ch_byte > 90 && ch_byte < 97))
{
    Console.WriteLine("you entered a special character.");
}
else if (ch_byte > 47 && ch_byte < 58)
{
    Console.WriteLine("you entered a number.");
}
else if ((ch_byte > 64 && ch_byte < 91) || (ch_byte > 96 && ch_byte < 123))
{
    Console.WriteLine("you entered a letter.");
}