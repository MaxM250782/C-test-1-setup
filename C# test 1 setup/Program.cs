//Max Martin Math game
int points = 0;
int currentQuestionnum = 0;
int totalQuestions = 5;
string currentQuestion = "";
int num1 = 0;
int num2 = 0;
Random random = new Random();
int answer = 0;

Console.WriteLine("Hello are you ready for the game? (yes/no)");
if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine("Great! Let's get started.");
    mainMenu();

}
else
{
    Console.WriteLine("No worries! Come back when you're ready.");
    return;
}
// Main menu function basic change later add more options for requirments hi
void mainMenu()
{
    Console.WriteLine("Welcome to the game!");
    Console.WriteLine("Pick an operation to practice:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    int operationchoice = Convert.ToInt16(Console.ReadLine());
    if (operationchoice == 1)
    {
        Console.WriteLine("You chose Addition!");
        startGameAddition();
    }
    else if (operationchoice == 2)
    {
        Console.WriteLine("You chose Subtraction!");
        startGameSubtraction(); 
    }
    else if (operationchoice == 3)
    {
        Console.WriteLine("You chose Multiplication!");
        startGameMultiplication();
    }
    else if (operationchoice == 4)
    {
        Console.WriteLine("You chose Division!");
        startGameDivision();
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
        mainMenu();
    }
}

void startGameAddition()
{
    while (currentQuestionnum < totalQuestions)
    {
        currentQuestionnum++;
        Console.WriteLine($"Question {currentQuestionnum}");
        num1 = random.Next(1, 10);
        num2 = random.Next(1, 10);
        currentQuestion = $"{num1} + {num2} = ?";
        Console.WriteLine(currentQuestion);
        answer = Convert.ToInt16(Console.ReadLine());
        if (answer == num1 + num2)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine($"You have {points} points.");
        }
        else
        {
            Console.WriteLine($"Incorrect! The correct answer is {num1 + num2}");
            Console.WriteLine($"You have {points} points.");

        }
    }

}
void startGameMultiplication()
{
    while (currentQuestionnum < totalQuestions)
    {
        currentQuestionnum++;
        Console.WriteLine($"Question {currentQuestionnum}");
        num1 = random.Next(1, 10);
        num2 = random.Next(1, 10);
        currentQuestion = $"{num1} * {num2} = ?";
        Console.WriteLine(currentQuestion);
        answer = Convert.ToInt16(Console.ReadLine());
        if (answer == num1 * num2)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine($"You have {points} points.");
        }
        else
        {
            Console.WriteLine($"Incorrect! The correct answer is {num1 * num2}");
            Console.WriteLine($"You have {points} points.");

        }
    }

}

void startGameSubtraction()
{
    while (currentQuestionnum < totalQuestions)
    {
        currentQuestionnum++;
        Console.WriteLine($"Question {currentQuestionnum}");
        num1 = random.Next(1, 10);
        num2 = random.Next(1, 10);
        currentQuestion = $"{num1} - {num2} = ?";
        Console.WriteLine(currentQuestion);
        answer = Convert.ToInt16(Console.ReadLine());
        if (answer == num1 - num2)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine($"You have {points} points.");
        }
        else
        {
            Console.WriteLine($"Incorrect! The correct answer is {num1 - num2}");
            Console.WriteLine($"You have {points} points.");

        }
    }

}

void startGameDivision()//do the thing for the division game whole numbers only
{
    while (currentQuestionnum < totalQuestions)
    {
        currentQuestionnum++;
        Console.WriteLine($"Question {currentQuestionnum}");
        num1 = random.Next(1, 10);
        num2 = random.Next(1, 10);
        currentQuestion = $"{num1} / {num2} = ?";
        Console.WriteLine(currentQuestion);
        answer = Convert.ToInt16(Console.ReadLine());
        if (answer == num1 / num2)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine($"You have {points} points.");
        }
        else
        {
            Console.WriteLine($"Incorrect! The correct answer is {num1 / num2}");
            Console.WriteLine($"You have {points} points.");

        }
    }

}

