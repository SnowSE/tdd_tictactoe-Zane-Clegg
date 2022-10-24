using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace TTTclassLib
{
    public class Class1
    {
        public char[,] grid = new char[3,3];
        public int turn = 0;
        public string winner = "No winner yet";

        public char Turn()
        {
            if (turn%2 == 0)
            {
                return 'x';
            }
            return 'o';
        }

        public void SetPlay(int x, int y)
        {
            grid[x,y] = Turn();
            turn++;
        }
        
        public char CheckCell(int x, int y)
        {
            return grid[x, y];
        }

        public string WinCondition()
        {
            if (columnCheck() || rowCheck() || diagonalCheck())
            {
                turn++;
                winner = $"{Turn()} has won";
                winner = "x has won";
                Console.WriteLine(winner);
            }
            return winner;
        }

        public bool columnCheck()
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0].CompareTo(grid[i, 1]) == 0 && grid[i, 2].CompareTo(grid[i, 1]) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool rowCheck()
        { 
            for (int i = 0; i < 3; i++)
            {
                if (grid[0, i].CompareTo(grid[1,i]) == 0 && grid[2,i].CompareTo(grid[1,i]) == 0)
                {
                    return true;
                }
            }
            return false;

        }
        public bool diagonalCheck()
        {
            if (grid[0, 0].CompareTo(grid[1, 1]) == 0 && grid[2, 2].CompareTo(grid[1, 1]) == 0)
            {
                return true;
            }
            else if (grid[0,2].CompareTo(grid[1, 1]) == 0 && grid[2,0].CompareTo(grid[1, 1]) == 0)
            {
                return true;
            }
            return false;
        }
    }
}