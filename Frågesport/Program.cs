int score = 0; //This is the players score. Every correct answer gives 1 point.
string name;

Console.WriteLine("What is your name?");
name = Console.ReadLine();


// The Introduction of the quiz is done by this line underneath.
Console.WriteLine("Welcome to my quiz about random things I find interesting! Have a go and see if you can get it right!");

Console.WriteLine("Just so that you are aware, you can only pick one answer per question. [a], [b], [c] or [d].");
// The quiz begins here

// Here is question 1-5 and the alternatives that can be chosen.
Console.WriteLine("1: When a supersonic fighter jet travels close to or beyond the sound barrier, what measurement is used?");

Console.WriteLine("a. Mach (M)   b. Knots (kn)   c. Kilometers per hour (km/h)   d. Miles per hour (mph)");

// The code that is written below this comment makes it so that if the right answer is chosen, the player increases score, but if they choose the wrong answer, they won't get anything.
//The code that increases the score is "score++;". ++; är en aritmetisk operatör!
string choice1 = Console.ReadLine().ToLower(); 
if (choice1 == "a")
{
    Console.WriteLine("The answer you have chosen is correct! Well done!");
    score++;
}
else
{
    Console.WriteLine("The answer you have chosen is wrong!");
}

Console.WriteLine("2: The White Bellbird has one of the loudest birdcalls ever documented. How loud is it though?");

Console.WriteLine("a. 82 dB   b. 125 dB   c. 140 dB   d. 115 dB");

string choice2 = Console.ReadLine().ToLower();
if (choice2 == "b")
{
    Console.WriteLine("The answer you have chosen is correct!");
    score++;
}
else
{
    Console.WriteLine("The answer you have chosen is wrong!");
}

Console.WriteLine("3: In Roman Numerals, how many hours are in a day?");

Console.WriteLine("a. XXVI   b. XXIV   c. XXIL   d. XIXV");

string choice3 = Console.ReadLine().ToLower();
if (choice3 == "b")
{
    Console.WriteLine("The answer you have chosen is correct!");
    score++;
}
else
{
    Console.WriteLine("The answer you have chosen is wrong!");
}

Console.WriteLine("4: You have a 7 letter word. It becomes longer when the third letter is removed. Which one is it?");

Console.WriteLine("a. Longing   b. Longine   c. Lengthy   d. Lounger");

string choice4 = Console.ReadLine().ToLower();
if (choice4 == "d")
{
    Console.WriteLine("The answer you have chosen is correct!");
    score++;
}
else
{
    Console.WriteLine("The answer you have chosen is wrong!");
}

Console.WriteLine("5: A painting and a sculpture cost $1500 in total. the painting costs $1000 more than the sculpture. How much does the sculpture cost?");

Console.WriteLine("a. $400   b. $450   c. $250   d. $200");

string choice5 = Console.ReadLine().ToLower();
if (choice5 == "c")
{
    Console.WriteLine("The answer you have chosen is correct!");
    score++;
}
else
{
    Console.WriteLine("The answer you have chosen is wrong!");
}

//This line tells you how many points you have received. 
Console.WriteLine($"You have gained {score} points.");

//Below are the lines that make it so that depending on how many points you have, you get a different message.
if (score == 5)
{
    Console.WriteLine($"Congratulations {name}! You have answered all of the questions correctly. Pat yourself on the back for a job well done! :)");
}
else if (score > 0)
{
    Console.WriteLine($"well done {name}! You have managed to answer some of the questions correctly.");
}
else
{
    Console.WriteLine($"Aww! You didn't get any of them right. Better luck next time {name}!");
}

Console.ReadLine();

