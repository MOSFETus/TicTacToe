using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentInput = 1;
            string escString = "";
            bool correctInput;

            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252); //extended UTF support for console display
            Console.WindowHeight = 45;  //console window height in number of lines NOT pixels
            Console.WindowWidth = 120;  //console window width in number of chars NOT pixels

            Board newGame = new Board();
            Player playa1 = new Player(1);
            Player playa2 = new Player(2);

            Console.Write("Game Loading: ");
            newGame.LoadingGameScreen();
            Console.Clear();
            Console.Write($"[Player 1: Choose your field (Type 'menu' to open menu)]");

            while (true)
            {
                
                if (newGame.CheckWin(newGame))
                {
                    Console.Write($"['y': Play again]\n['exit': Close the game]\n['highscore': Display highscore table]\n");
                    string yOrN = Console.ReadLine();
                    newGame.DisplayMenu(newGame, yOrN);
                }
                newGame.DrawBoard();

                //Console.WriteLine(newGame.counter);

                escString = Console.ReadLine();

                correctInput = int.TryParse(escString, out currentInput);

                Console.Clear();
                
                if(newGame.counter % 2 != 0) //player 1
                {
                    if(escString == "exit")
                    {
                        break;
                    }
                    else if(escString == "menu")
                    {
                        newGame.DisplayPauseMenu(newGame, escString);
                    }
                    else if (correctInput && currentInput >= 1 && currentInput <= 9)
                    {
                        
                        if (newGame.SetBoard(currentInput, playa1))
                        {
                            Console.Write($"[Player 2: Your turn]");
                            newGame.counter++;
                        }    
                    }
                    else
                    {
                        Console.Write($"[Player 1: Enter a valid field number]");
                    }
                }
                else //player 2
                {
                    if (escString == "exit")
                    {
                        break;
                    }
                    else if (escString == "menu")
                    {
                        newGame.DisplayPauseMenu(newGame, escString);
                    }
                    else if (correctInput && currentInput >= 1 && currentInput <= 9)
                    {
                        if (newGame.SetBoard(currentInput, playa2))
                        {
                            Console.Write($"[Player 1: Your turn]");
                            newGame.counter++;
                        }
                    }
                    else
                    {
                        Console.Write($"[Player 2: Enter a valid field number]");
                    }
                } 
            } 
        }
    }
}
