using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeDemo
    {
        string CurrentPlayer;

        public int CreateBoard (string[,] array)
        {
            return array.Length;
        }

        public string currentPlayer (string player1)
        {
            //tracks the current player
            return CurrentPlayer = player1;

        }

        public string changePlayer(string player1, string player2)
        {
            //changes the player after the current player made a move
            player1 = player2;
            CurrentPlayer = player1;
            return CurrentPlayer;
        }

        public string makeMove(string [,] array, string player1)
        {
            //current player puts only a X or an O in a empty space
            array[1, 2] = player1;
            return array[1, 2];
        }

        public bool spaceInUse(string[,] array)
        {
            //tracks which spaces in the array already have a X or a O
            if (array[1,2] == " ")
            {
                return false;
            }

            return true;
        }
    }
}
