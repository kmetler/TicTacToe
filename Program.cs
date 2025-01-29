//Make a Tic Tac Toe Game
using TicTacToe;

TicTacToeTools tools = new TicTacToeTools();

//Welcome user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

//Create game board array to store players' choices
char[,] board =
{
    {'-','-','-'},
    {'-','-','-'},
    {'-','-','-'},
};
char currentPlayer = 'X'; //Start game with X

//Ask each player in turn for their choice and update the game board array
while (true)
{
    //tools.PrintBoard(board);

    Console.WriteLine($"Player {currentPlayer}, enter your move (row and column e.g.(1,2)");
    int row, col;

    //Make sure it is a valid input
    while (true)
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(",");

        if (parts.Length == 2 &&
            int.TryParse(parts[0], out row) &&
            int.TryParse(parts[1], out col) &&
            row >= 1 && row <= 3 &&
            col >= 1 && col <= 3 &&
            board[row -1, col - 1] == '-')
        {
            break; //Valid input
        }

        Console.WriteLine("Invalid move. Please enter row and column as \"1,2\" (1-3) and choose and empty spot.");
    }

    //Place move
    board[row - 1, col - 1] = currentPlayer;

    //Check if winner
    //tools.DetermineWinner(board);

    //Switch player
    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
}