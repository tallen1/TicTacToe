using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeDemoTests
    {
        [TestMethod()]
        public void CreateBoardTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3,3];
            game.CreateBoard(newGame);
            Assert.AreEqual(9, newGame.Length);
        }

        [TestMethod()]
        public void currentPlayerTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerX = "X";
            //game.currentPlayer(playerX);
            Assert.AreEqual("X", game.currentPlayer(playerX));
        }

        [TestMethod()]
        public void makeMoveTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerX = "X";
            //game.makeMove(newGame, playerX);
            Assert.AreEqual("X", game.makeMove(newGame, playerX));
        }

        [TestMethod()]
        public void spaceTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerX = "X";
            game.makeMove(newGame, playerX);
            //game.spaceInUse(newGame);
            Assert.AreEqual(true, game.spaceInUse(newGame));
        }

        [TestMethod()]
        public void changePlayerTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerX = "X";
            string playerO = "O";
            //game.changePlayer(playerX, playerO);
            Assert.AreEqual("O", game.changePlayer(playerX, playerO));
        }

        [TestMethod()]
        public void currentPlayerOTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerO = "O";
            //game.currentPlayer(playerO);
            Assert.AreEqual("O", game.currentPlayer(playerO));
        }

        [TestMethod()]
        public void makeMoveOTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerO = "O";
            //game.makeMove(newGame, playerO);
            Assert.AreEqual("O", game.makeMove(newGame, playerO));

        }

        [TestMethod()]
        public void spaceOTest()
        {
            TicTacToeDemo game = new TicTacToeDemo();
            string[,] newGame = new string[3, 3];
            string playerO = "O";
            game.makeMove(newGame, playerO);
            //game.spaceInUse(newGame);
            Assert.AreEqual(true, game.spaceInUse(newGame));

        }

    }
}