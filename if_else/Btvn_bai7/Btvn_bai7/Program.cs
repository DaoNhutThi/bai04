Console.WriteLine("Check Vowel or Consonant: ");
string character = Console.ReadLine();

if (character == "a" || character == "A"
    && character == "e" || character == "E"
    && character == "i" || character == "I"
    && character == "o" || character == "O"
    && character == "u" || character == "U")
{
    Console.WriteLine("Vowel!");
}
else
{
    Console.WriteLine("Consonant!");
}