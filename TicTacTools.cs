namespace Mission4
{
    public class TicTacTools
    {
        // Method to print the board
        public void PrintBoard(char[,] board, int row, int column, int roundNumber)
        {
            // Update the board with the current player's symbol
            char currentSymbol = (roundNumber % 2 == 0) ? 'X' : 'O';
            if (row >= 0 && row < 3 && column >= 0 && column < 3)
            {
                board[row, column] = currentSymbol;
            }

            // Print the board
            Console.WriteLine("\nCurrent Board:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {board[i, j]} ");
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---+---+---");
            }
            Console.WriteLine();
        }

        // Method to check if the selected move is valid
        public bool IsPossible(char[,] board, int row, int column)
        {
            // Check if the cell is within bounds and empty
            if (row >= 0 && row < 3 && column >= 0 && column < 3)
            {
                if (board[row,column] != ' ')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
            else
            {
                Console.WriteLine("Invalid position, so please choose a valid place.");
                return false;
            }
            
        }

        // Method to check if there is a winner
        public bool CheckWinner(char[,] board)
        {
            // Check rows and columns for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2]) return true; // Row
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[0, i] == board[2, i]) return true; // Column
            }

            // Check diagonals for a winner
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) return true; // Top-left to bottom-right
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0]) return true; // Top-right to bottom-left

            // No winner found
            return false;
        }
    }
}
