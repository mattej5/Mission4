
// Team 4-14 
// Hadley Garff, Sebastian McFarland, Vin Jones, Yuto Takamura 


using Mission4;

TicTacTools ttt = new TicTacTools();


//initializing our game board
char[,] board = new char[3,3]
{
    {' ', ' ', ' '}, 
    {' ', ' ', ' '}, 
    {' ', ' ', ' '}
};
//initializing our variables
int row = 0;
int column = 0;
int roundNumber = 0;
int currentPlayer = 1;
bool winCase = false;

//introduction
Console.WriteLine("Welcome to our Tic Tac Toe Game! \n");
Console.WriteLine("Player 1, you will be X's ");
Console.WriteLine("Player 2, you will be O's ");
   

ttt.PrintBoard(board);

//do while loop to play until win
do
{
    //logic to take turns and fill out array
    Console.WriteLine($"Player {(roundNumber % 2 == 0 ? 1 : 2)}, it's your turn!? ");
    Console.WriteLine("Which row would you like (0, 1, or 2)? ");
    row = int.Parse(Console.ReadLine()); // Get row input and convert to integer
    Console.WriteLine("Which column would you like (0, 1, or 2)? ");
    column = int.Parse(Console.ReadLine()); // Get column input and convert to integer
    
    //printing to show progress and what has been done
    
    if (ttt.isPossible(row, column))
    {
        ttt.PrintBoard(row, column, roundNumber);
        roundNumber++;
    }
    else
    {
        Console.WriteLine("That space is already taken.");
    }

} while (!ttt.winCase && roundNumber < 9);

if (ttt.winCase)
{
    Console.WriteLine($"Player {(roundNumber % 2 == 0 ? 2 : 1)} wins!");
}
else
{
    Console.WriteLine("It's a tie!");
}

// welcome users
//create array variable(specifiy the numbers inside the array 
//player inputs (while loop for gameplay)
//      player puts in number
//      call print method
// check for winner using method
