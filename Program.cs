//Make a Tic Tac Toe Game
using TicTacToe;

//Welcome user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

//Create game board array to store players' choices
char[,] board =
{
    {'-','-','-'},
    {'-','-','-'},
    {'-','-','-'},
};

TicTacToeTools tools = new TicTacToeTools(board);

char currentPlayer = 'X'; //Start game with X

//Ask each player in turn for their choice and update the game board array
while (true)
{
    tools.PrintBoard();

    Console.WriteLine($"\nPlayer {currentPlayer}, enter your move (row and column e.g.(1,2))");
    int row, col;

    //Make sure it is a valid input
    while (true)
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(",");

        if (parts.Length == 2 && //Only 2 inputs
            int.TryParse(parts[0], out row) && //Check to see if number
            int.TryParse(parts[1], out col) &&
            row >= 1 && row <= 3 && //Check to see if on board
            col >= 1 && col <= 3 &&
            board[row -1, col - 1] == '-') //Check to see if blank
        {
            break; //Valid input
        }

        Console.WriteLine("\nInvalid move. Please enter row and column as \"1,2\" (1-3) and choose and empty spot.");
    }

    //Place move
    board[row - 1, col - 1] = currentPlayer;

    //Check if winner
    char result = ' ';
    result = tools.DetermineWinner();
    if (result != ' ')
    {
        tools.PrintBoard();
        Console.WriteLine($"\nPlayer {currentPlayer} Wins!!!");
        break;
    }

    //Switch player
    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
}