Console.WriteLine("Welcome to the Guess My Favorite Number Game!\nTake a guess then press enter to see if you got it right!\n ");
var favNum = 2;
var guess = Convert.ToInt32(Console.ReadLine());


if (guess == favNum)
{
    Console.WriteLine("Congrats, you guessed it!");
}

while (guess != favNum)
{
    Console.WriteLine("Not quite, take another guess");
    var guessAgain = Convert.ToInt32(Console.ReadLine());

    if (guessAgain == favNum)
    {
        Console.WriteLine("Congrats, you guessed it!");
        break;
    }
}
