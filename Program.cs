using System.Runtime.InteropServices;

Console.WriteLine("Welcome to the Pig Latin Converter!");
Console.WriteLine();

string goOn = "";
do
{
    Console.WriteLine("Please enter a sentence in english:");
    string sent = Console.ReadLine().ToLower();

    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    int firstVowel = -1;

    foreach (char vowel in vowels)
    {
        int currentIndex = sent.IndexOf(vowel);
        if (currentIndex != -1) // vowel exists
        {
            if (firstVowel == -1) // this is the first vowel FOUND
            {
                firstVowel = currentIndex;
            }
            else if (firstVowel > currentIndex) // check if current vowel came before first
            {
                firstVowel = currentIndex;
            }
        }
    }

    string sub1 = sent.Substring(firstVowel, sent.Length - firstVowel);

    if (firstVowel == -1)
    {
        Console.WriteLine(sent);
    }
    else if (firstVowel == 0)
    {
        Console.WriteLine(sent + "way");
    }
    else
    {
        string sub2 = sent.Substring(0, firstVowel);
        Console.WriteLine(sub1 + sub2 + "ay");
    }





    Console.WriteLine("would you like to translate another word? y/n");
    goOn = Console.ReadLine();
    if(goOn != "y")
    {
        Console.WriteLine("Goodbye!"); 
    }

} while (goOn == "y");