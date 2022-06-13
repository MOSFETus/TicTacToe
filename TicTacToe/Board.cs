using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TicTacToe
{
    class Board
    {
        int playerID;
        internal int counter = 1;
        const int baseCounter = 1;

        string[] boardNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //alternatively 2D array string[] boardNumbers = {{"1","2","3"},{"4","5","6"},{"7","8","9"}};
        public int PlayerOneHighscore { get; private set; }
        public int PlayerTwoHighscore { get; private set; }
        public int PlayerID {
            get
            {
                return this.playerID;
            }
            private set
            {
                try
                {
                    if (value >= 0 && value <= 2)
                    {
                        playerID = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Check if the playerID value is set between 0 and 2\nDotNet error message: {e}");
                }
            }
        }

        public void ResetBoard()
        {
            #region Reset grid
            for (int i = 0; i < boardNumbers.Length; i++)
            {
                boardNumbers[i] = Convert.ToString(i + 1);
            }
            #endregion
        }

        public void DrawBoard()
        {
            #region Draws the main grid
            Console.WriteLine($"\n\n\t _________________ ");
            Console.WriteLine($"\t|     |     |     |");
            Console.WriteLine($"\t|  {boardNumbers[6]}  |  {boardNumbers[7]}  |  {boardNumbers[8]}  |");
            Console.WriteLine($"\t|_____|_____|_____|");
            Console.WriteLine($"\t|     |     |     |");
            Console.WriteLine($"\t|  {boardNumbers[3]}  |  {boardNumbers[4]}  |  {boardNumbers[5]}  |");
            Console.WriteLine($"\t|_____|_____|_____|");
            Console.WriteLine($"\t|     |     |     |");
            Console.WriteLine($"\t|  {boardNumbers[0]}  |  {boardNumbers[1]}  |  {boardNumbers[2]}  |");
            Console.WriteLine($"\t|_____|_____|_____|\n\n");
            #endregion
        }

        public void DrawEasterEgg()
        {
            #region Can be drawn at the end of a match
            Console.WriteLine(@" _n_________________");
            Console.WriteLine(@"|_|_______________|_|");
            Console.WriteLine(@"|  ,-------------.  |");
            Console.WriteLine(@"| |  .---------.  | |");
            Console.WriteLine(@"| |  |         |  | |");
            Console.WriteLine(@"| |  |         |  | |");
            Console.WriteLine(@"| |  |         |  | |");
            Console.WriteLine(@"| |  |         |  | |");
            Console.WriteLine(@"| |  `---------'  | |");
            Console.WriteLine(@"| `---------------' |");
            Console.WriteLine(@"|   _ GAME BOY      |");
            Console.WriteLine(@"| _| |_         .-. |");
            Console.WriteLine(@"||_ O _|   .-. '._.'|");
            Console.WriteLine(@"|  |_|    '._.'   A |");
            Console.WriteLine(@"|    _  _    B      |");
            Console.WriteLine(@"|   // //           |");
            Console.WriteLine(@"|  // //    \\\\\\  |");
            Console.WriteLine(@"|  `  `      \\\\\\ |");
            Console.WriteLine(@"|________...______,_/");
            #endregion
        }

        public bool SetBoard(int num, Player playa)
        {
            #region Sets grid with input values
            bool checkForCounter = false;

            if(playa.PlayerNumber == 1)
            {
                #region
                switch (num)
                {
                    case 1:
                        if (boardNumbers[0] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[0] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[0] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 2:
                        if (boardNumbers[1] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[1] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[1] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 3:
                        if (boardNumbers[2] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[2] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[2] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 4:
                        if (boardNumbers[3] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[3] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[3] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 5:
                        if (boardNumbers[4] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[4] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[4] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 6:
                        if (boardNumbers[5] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[5] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[5] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 7:
                        if (boardNumbers[6] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[6] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[6] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 8:
                        if (boardNumbers[7] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[7] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[7] = "X";
                            checkForCounter = true;
                        }
                        break;
                    case 9:
                        if (boardNumbers[8] == "O")
                            Console.Write("[Player 1: This field already belongs to player 2, please choose another field]");
                        else if (boardNumbers[8] == "X")
                            Console.Write("[Player 1: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[8] = "X";
                            checkForCounter = true;
                        }
                        break;
                    default:
                        Console.WriteLine($"Something went wrong");
                        break;
                }
                #endregion
            }
            if(playa.PlayerNumber == 2)
            {
                #region
                switch (num)
                {
                    case 1:
                        if (boardNumbers[0] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[0] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[0] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 2:
                        if (boardNumbers[1] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[1] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[1] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 3:
                        if (boardNumbers[2] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[2] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[2] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 4:
                        if (boardNumbers[3] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[3] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[3] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 5:
                        if (boardNumbers[4] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[4] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[4] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 6:
                        if (boardNumbers[5] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[5] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[5] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 7:
                        if (boardNumbers[6] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[6] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[6] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 8:
                        if (boardNumbers[7] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[7] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[7] = "O";
                            checkForCounter = true;
                        }
                        break;
                    case 9:
                        if (boardNumbers[8] == "X")
                            Console.Write("[Player 2: This field already belongs to player 1, please choose another field]");
                        else if (boardNumbers[8] == "O")
                            Console.Write("[Player 2: This field already belongs to you, please choose another field]");
                        else
                        {
                            boardNumbers[8] = "O";
                            checkForCounter = true;
                        }
                        break;
                    default:
                        Console.Write($"[Something went wrong]");
                        break;
                }
                #endregion
            }

            return checkForCounter;
            #endregion
        }

        public bool CheckWin(Board boardobject)
        {
            #region Has all winning combinations and checks if input matches
            bool winCheck = false;

            //player 1
            #region
            if (boardNumbers[0] == "X" && boardNumbers[1] == "X" && boardNumbers[2] == "X" || boardNumbers[3] == "X" && boardNumbers[4] == "X" && boardNumbers[5] == "X"
                || boardNumbers[6] == "X" && boardNumbers[7] == "X" && boardNumbers[8] == "X" || boardNumbers[0] == "X" && boardNumbers[3] == "X" && boardNumbers[6] == "X"
                || boardNumbers[1] == "X" && boardNumbers[4] == "X" && boardNumbers[7] == "X" || boardNumbers[2] == "X" && boardNumbers[5] == "X" && boardNumbers[8] == "X"
                || boardNumbers[0] == "X" && boardNumbers[4] == "X" && boardNumbers[8] == "X" || boardNumbers[6] == "X" && boardNumbers[4] == "X" && boardNumbers[2] == "X")
            {
                winCheck = true;
                Console.Clear();
                Console.Write("[Player 1, you're the winner!]");
                PlayerOneHighscore++;
                PlayerID = 1;
                DrawBoard();
            }
            #endregion
            //player2
            #region
            else if (boardNumbers[0] == "O" && boardNumbers[1] == "O" && boardNumbers[2] == "O" || boardNumbers[3] == "O" && boardNumbers[4] == "O" && boardNumbers[5] == "O"
                || boardNumbers[6] == "O" && boardNumbers[7] == "O" && boardNumbers[8] == "O" || boardNumbers[0] == "O" && boardNumbers[3] == "O" && boardNumbers[6] == "O"
                || boardNumbers[1] == "O" && boardNumbers[4] == "O" && boardNumbers[7] == "O" || boardNumbers[2] == "O" && boardNumbers[5] == "O" && boardNumbers[8] == "O"
                || boardNumbers[0] == "O" && boardNumbers[4] == "O" && boardNumbers[8] == "O" || boardNumbers[6] == "O" && boardNumbers[4] == "O" && boardNumbers[2] == "O")
            {
                winCheck = true;
                Console.Clear();
                Console.Write("[Player 2, you're the winner!]");
                PlayerTwoHighscore++;
                PlayerID = 2;
                DrawBoard();
            }
            #endregion
            //draw
            #region
            else if (boardobject.counter == 10 || (boardNumbers[0] != "1" && boardNumbers[1] != "2" && boardNumbers[2] != "3" && boardNumbers[3] != "4" && boardNumbers[4] == "5"
                && boardNumbers[5] != "6" && boardNumbers[6] != "7" && boardNumbers[7] != "8" && boardNumbers[8] != "9"))
            {
                winCheck = true;
                Console.Clear();
                Console.Write("[DRAW! There is no winner!]");
                PlayerID = 0;
                DrawBoard();
            }
            #endregion

            return winCheck;
            #endregion
        }

        public void DisplayHighscore()
        {
            #region Displays highscore of both players
            Console.WriteLine($"Player 1 points: {PlayerOneHighscore}\n");
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"\nPlayer 2 points: {PlayerTwoHighscore}\n");

            if(PlayerOneHighscore > PlayerTwoHighscore)
            {
                Console.WriteLine($"\n>>>Player 1 is leading the highscore table<<<\n\n");
            }
            else if(PlayerOneHighscore < PlayerTwoHighscore)
            {
                Console.WriteLine($"\n>>>Player 2 is leading the highscore table<<<\n\n");
            }
            else
            {
                Console.WriteLine($"\n>>> No one is leading the highscore table <<<\n\n");
            }
            #endregion
        }

        public void DisplayMenu(Board boardobj, string yOrN)
        {
            #region Menu displayed at the end of a match
            do
            {
                if (yOrN == "y")
                {
                    boardobj.counter = baseCounter;
                    boardobj.ResetBoard();
                    Console.Clear();
                    Console.Write($"[Player 1: Choose your field!]");
                    break;
                }
                else if (yOrN == "exit")
                {
                    Environment.Exit(0);
                }
                else if (yOrN == "game") //easter egg
                {
                    boardobj.counter = baseCounter;
                    boardobj.ResetBoard();
                    Console.Clear();
                    boardobj.DrawEasterEgg();
                    Console.ReadKey();
                    yOrN = "y";
                }
                else if (yOrN == "highscore")
                {
                    Console.Clear();
                    boardobj.DisplayHighscore();
                    Console.WriteLine("['y': Play again]\n['exit': Close the game]\n['board': Display board from current match again]\n['back' : Return to previous view]");
                    yOrN = Console.ReadLine();

                    if (yOrN == "board")
                    {
                        boardobj.DrawBoard();
                        yOrN = Console.ReadLine();
                    }
                }
                else if (yOrN == "board")
                {
                    yOrN = "highscore";
                }
                else if (yOrN == "back")
                {
                    try
                    {
                        Console.Clear();

                        if (boardobj.PlayerID == 1)
                        {
                            Console.Write("[Player 1, you're the winner!]");
                        }
                        else if (boardobj.PlayerID == 2)
                        {
                            Console.Write("[Player 2, you're the winner!]");
                        }
                        else if (boardobj.PlayerID == 0)
                        {
                            Console.Write("[There is no leading winner!]");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Something is wrong with the 'back' condition:\n{e}");
                    }
                    finally
                    {
                        boardobj.DrawBoard();
                        Console.Write($"['y': Play again]\n['exit': Close the game]\n['highscore': Display highscore table]\n");
                        yOrN = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"[Press 'y' to play again]\n[Press 'exit' to close the game]\n[Type 'highscore' to display current highscore]\n[Type 'back' to return to previous view]");
                    yOrN = Console.ReadLine(); 
                }
            } while (true);
            #endregion
        }

        public void DisplayPauseMenu(Board boardobj, string yOrN)
        {
            #region Menu displayed while in a match
            do
            {
                if (yOrN == "menu")
                {
                    Console.Clear();
                    Console.Write($"[Menu]");
                    boardobj.DrawBoard();
                    Console.Write($"['y': Resume game]\n['exit': Close the game]\n['highscore': Display highscore table]\n");
                    yOrN = Console.ReadLine();
                }
                else if(yOrN == "y")
                {
                    Console.Clear();
                    if(boardobj.counter % 2 != 0)
                    {
                        Console.Write($"[Player 1: Your turn]");
                    }
                    else
                    {
                        Console.Write($"[Player 2: Your turn]");
                    }
                    break;
                }
                else if (yOrN == "exit")
                {
                    Environment.Exit(0);
                }
                else if (yOrN == "highscore")
                {
                    Console.Clear();
                    boardobj.DisplayHighscore();
                    Console.Write($"['y': Resume game]\n['exit': Close the game]\n['back': Back to menu]\n");
                    yOrN = Console.ReadLine();

                    if(yOrN == "y")
                    {
                        yOrN = "y";
                    }
                    else if(yOrN == "exit")
                    {
                        yOrN = "exit";
                    }
                    else if(yOrN == "back")
                    {
                        yOrN = "menu";
                    }
                    else
                    {
                        yOrN = "highscore";
                    }
                }
                else if(yOrN == "back")
                {
                    yOrN = "menu";
                }
                else
                {
                    yOrN = "menu";
                }

            } while (true);
            #endregion
        }

        public void LoadingGameScreen()
        {
            #region Simulates a loading screen
            for (int i = 0; i <= 5; i++)
            {
                Console.Write(@"-");
                Thread.Sleep(200);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(@"\");
                Thread.Sleep(200);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(@"|");
                Thread.Sleep(200);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(@"/");
                Thread.Sleep(200);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            #endregion
        }
    }
}
