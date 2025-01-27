using Mission4Assignment;

BoardTools bt = new BoardTools();
string player1 = "";
string player2 = "";
char player = 'X';
bool gameOver = false;
int numturns = 0;
int spot = 0;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe! \n");

// Create the game board array
char [] gameBoard = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

// User input
Console.WriteLine("Enter player 1's name: ");
player1 = Console.ReadLine();
Console.WriteLine("\nEnter player 2's name: ");
player2 = Console.ReadLine();
Console.WriteLine("\n");
bt.PrintBoard(gameBoard);

do
{
    if (player == 'X')
    {
        Console.WriteLine($"{player1} ('X') enter the position of your move (1-9): ");
        string input = Console.ReadLine();
        Console.WriteLine();
        if (!int.TryParse(input, out spot) || spot < 1 || spot > 9)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.\n");
            continue;
        }

        if (gameBoard[spot - 1] == 'X' || gameBoard[spot - 1] == 'O')
        {
            Console.WriteLine("That place is already taken. Please try again.");
            continue;
        }
        bt.UpdateBoard(gameBoard, (spot - 1), player);
        numturns++;
        if (bt.CheckWin(gameBoard, player))
        {
            Console.WriteLine($"{player1} ('X') wins the game !");
            gameOver = true;
        }
        // Changes turn
        player = 'O';
    } 
    else if (player == 'O')
    {
        Console.WriteLine($"{player2} ('O') enter the position of your move (1-9): ");
        string input = Console.ReadLine();
        Console.WriteLine();
        if (!int.TryParse(input, out spot) || spot < 1 || spot > 9)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.\n");
            continue;
        }
        if (gameBoard[spot - 1] == 'X' || gameBoard[spot - 1] == 'O')
        {
            Console.WriteLine("That place is already taken. Please try again.");
            continue;
        }
        bt.UpdateBoard(gameBoard, (spot - 1), player);
        numturns++;

        if (bt.CheckWin(gameBoard, player))
        {
            Console.WriteLine($"{player2} ('O') wins the game !");
            gameOver = true;
        }
        // Changes turn
        player = 'X';
    }
    
} while (!gameOver && numturns < 9);

if (numturns == 9 && !gameOver)
{
    Console.WriteLine("\nIt was a tie!");
}

Console.WriteLine("Thank you for using our Tic-Tac-Toe Game!");
