Write a public method that accepts a number
when the number is divisible by 3 return the word fizz

when the number is divisible by 5 return the word buzz

when the number is divisible by both, return the word fizzbuzz


static string Fizzbuzz(int num)
{

    if (num % 5 == 0 && num % 3 == 0)
    {
        return "fizzbuzz";
    }

    else if (num % 3 == 0)
    {
        return "fizz";
    }
    else if (num % 5 == 0)
    {
        return "buzz";
    }
    else
    {
        return "errrrRor!";
    }

}
Console.WriteLine("Enter a number, preferrable divisible by 3 or 5..or both: ");
var userInput = Console.ReadLine();
var userInputParsed = int.Parse(userInput);
Console.WriteLine();
Console.WriteLine(Fizzbuzz(userInputParsed));