// Declare first variables
int length = 0;
int height = 0;
int targetFrequency = 0;
bool isDebugMode = true;

// 1. Greet the Saboteur (Print title and mission)
Console.WriteLine("Hello Agent. Your mission, should you choose to accept it, is to collapse the bridge by finding its harmonic frequency. Provide the requested data, and the tool will calculate the target frequency!");


// 2. Gather Environmental Data

Console.WriteLine("What is the length of the bridge?");
bool lengthParsed = int.TryParse(Console.ReadLine(), out length);

Console.WriteLine("What is the height of the bridge?");
bool heightParsed = int.TryParse(Console.ReadLine(), out height);

// 3. Calculate Harmonic Target

Random random = new Random();
targetFrequency = ((length * height) + random.Next(1, 101)) % 100;

Console.WriteLine("Agent, please use Frequency... *ERROR*... *ERROR*... Result Encrypted!");
if (isDebugMode)
{
    Console.WriteLine($"DEBUG MODE: Target Frequency is {targetFrequency} Hz \nTarget breaks are at 3,6 and 7+ attempts");
}
Console.WriteLine("The Agent will need to guess the targeted frequency!");

// 5. The Harmonic Loop (The Game Loop)

bool isGuessCorrect = false;
int currentGuess = 0;
int guessCount = 0;

while (!isGuessCorrect)
{
    Console.WriteLine("Input predicted resonance frequency (0-99 Hz): ");
    bool guessParsed = int.TryParse(Console.ReadLine(), out currentGuess);

    if (currentGuess == targetFrequency)
    {
        isGuessCorrect = true;
        Console.WriteLine($"Congratulations Agent, {currentGuess} is correct!");
    } else if (currentGuess > targetFrequency)
    {
        Console.WriteLine("Incorrect Agent, guess appears too high.");
    }
    else
    {
        Console.WriteLine("Incorrect Agent, guess appears too low.");
    }

    guessCount++;
}
//Victory conditions
Console.Clear();
Console.WriteLine("--- MISSION COMPLETE ---");
if (guessCount <=3)
{
    Console.WriteLine($"Excellent work Agent, \nyou cracked the encryption in only {guessCount} attempts. \nPlease enter {targetFrequency} in the device and make your escape!");
} else if ( guessCount <= 6)
{
    Console.WriteLine($"Acceptable work Agent, \nyou cracked the encryption in {guessCount} attempts. \nPlease enter {targetFrequency} in the device and make your escape!");
}
else
{
    Console.WriteLine($"We are dissapointed Agent. \nYou finally solved the encryption in {guessCount} attempts. \nPlease enter {targetFrequency} in the device and do not return. \nPray we do not find you.");
}



Console.ReadKey();