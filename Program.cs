using Mission4Assignment;

BoardTools bt = new BoardTools();
string player1 = "";
string player2 = "";
bool player1turn = true;
bool gameOver = false;
int numturns = 0;
int currentTurn = 0;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Create the game board array
char [,] gameBoard = {{'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'}};

// User input
Console.WriteLine("Enter player 1's name: ");
player1 = Console.ReadLine();
Console.WriteLine("Enter player 2's name: ");
player2 = Console.ReadLine();
do
{
    do
    {
        bt.PrintBoard(gameBoard);
        Console.WriteLine($"{player1} ('X') enter the position of your move: ");
        bt.PrintBoard(gameBoard);
        numturns++;
        
        // Changes turn
        player1turn = false;
    } while (player1turn);
    
    bt.PrintBoard(gameBoard);
    Console.WriteLine($"{player2} ('O') enter the position of your move: ");
    bt.PrintBoard(gameBoard);
    numturns++;
    
    // Changes turn
    player1turn = true;

    if (winner)
    {
        gameOver = true;
    }
} while (!gameOver && numturns <= 9);

Console.WriteLine("Thank you for using our Tic-Tac-Toe Game!");
