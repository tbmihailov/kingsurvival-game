using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KingSurvival.Core;

namespace KingSurvival.Console
{
    public class KingSurvivalGameConsole : KingSurvivalGame
    {
        public bool PawnMove(char pawnSymbol, int rowDirection, int columnDirection)
        {
            Figure currentPawn = Figures.Where(f => f.DisplaySymbol == pawnSymbol).FirstOrDefault();

            bool isKingTurn = IsKingTurn;

            bool isPawnMoveValid = TryFigureMove(currentPawn, rowDirection, columnDirection, isKingTurn);
            return isPawnMoveValid;
        }

        private string[] _validKingCommands;
        public string[] ValidKingCommands
        {
            get { return _validKingCommands; }
            set { _validKingCommands = value; }
        }

        private string[] _validPawnsCommands;
        public string[] ValidPawnsCommands
        {
            get { return _validPawnsCommands; }
            set { _validPawnsCommands = value; }
        }

        public void InitValidInputCommands()
        {
            ValidKingCommands = new string[] { "KUL", "KUR", "KDL", "KDR" };
            ValidPawnsCommands = new string[] { "ADL", "ADR", "BDL", "BDR", "CDL", "CDR", "DDL", "DDR" };
        }

        public void Start()
        {
            InitValidInputCommands();
            base.Start();

            bool isKingLose = false;
            bool isKingWin = false;

            do
            {
                if (IsKingTurn)
                {
                    KingTurn();
                }
                else if (IsPawnsTurn)
                    {
                        PawnsTurn();
                    }
                isKingLose = IsKingLose();
                isKingWin = IsKingWin();
            } while ((!isKingWin) && !isKingLose);

            if (isKingLose)
            {
                KingLoses();
            }
            else
            {
                KingWins();
            }
        }

        private void KingWins()
        {
            PrintGameBoard(GameBoard);
            System.Console.WriteLine(String.Format("King wins in {0} turns.", KingMovesCount));
        }

        private void KingLoses()
        {
            PrintGameBoard(GameBoard);
            System.Console.WriteLine("King loses.");
        }

        private void PawnsTurn()
        {
            bool isPawnMoveSuccessfull = false;
            while (!isPawnMoveSuccessfull)
            {
                PrintGameBoard(GameBoard);
                System.Console.Write("Pawns' turn:");

                string inputCommand = GetCommand();
                bool isCommandValid = IsCommandValid(inputCommand, ValidPawnsCommands);

                inputCommand = inputCommand.ToUpper();
                switch (inputCommand)
                {
                    case "ADR":
                        {
                            isPawnMoveSuccessfull = PawnMove('A', 1, 1);
                            break;
                        }
                    case "ADL":
                        {
                            isPawnMoveSuccessfull = PawnMove('A', 1, -1);
                            break;
                        }
                    case "BDL":
                        {
                            isPawnMoveSuccessfull = PawnMove('B', 1, -1);
                            break;
                        }
                    case "BDR":
                        {
                            isPawnMoveSuccessfull = PawnMove('B', 1, 1);
                            break;
                        }
                    case "CDL":
                        {
                            isPawnMoveSuccessfull = PawnMove('C', 1, -1);
                            break;
                        }
                    case "CDR":
                        {
                            isPawnMoveSuccessfull = PawnMove('C', 1, 1);
                            break;
                        }
                    case "DDR":
                        {
                            isPawnMoveSuccessfull = PawnMove('D', 1, 1);
                            break;
                        }
                    case "DDL":
                        {
                            isPawnMoveSuccessfull = PawnMove('D', 1, -1);
                            break;
                        }
                    default:
                        {
                            isPawnMoveSuccessfull = false;
                            break;
                        }
                }
                if (!isPawnMoveSuccessfull)
                {
                    System.Console.WriteLine(" Illegal move!");
                }
            }
        }

        private bool IsCommandValid(string inputCommand, string[] validCommands)
        {
            if (string.IsNullOrEmpty(inputCommand)
                || string.IsNullOrWhiteSpace(inputCommand))
            {
                return false;
            }

            if (validCommands.Contains(inputCommand))
            {
                return true;
            }

            return false;

        }


        private string GetCommand()
        {
            string inputCommand = System.Console.ReadLine();
            return inputCommand;
        }

        private void KingTurn()
        {
            bool isKingMoveSuccessfull = false;
            while (!isKingMoveSuccessfull)
            {
                isKingMoveSuccessfull = false;

                PrintGameBoard(GameBoard);
                System.Console.Write("King's turn:");
                string direction = System.Console.ReadLine();
                if (direction == "")
                {
                    isKingMoveSuccessfull = false;
                    continue;
                }
                direction = direction.ToUpper();

                switch (direction)
                {
                    case "KUL":
                        {
                            isKingMoveSuccessfull = KingMove(-1, -1);
                            break;
                        }
                    case "KUR":
                        {
                            isKingMoveSuccessfull = KingMove(1, -1);
                            break;
                        }
                    case "KDL":
                        {
                            isKingMoveSuccessfull = KingMove(-1, 1);
                            break;
                        }
                    case "KDR":
                        {
                            isKingMoveSuccessfull = KingMove(1, 1);
                            break;
                        }
                    default:
                        {
                            isKingMoveSuccessfull = false;
                            break;
                        }
                }
                if (!isKingMoveSuccessfull)
                {
                    IllegalMove();
                    continue;
                }


            }
        }

        private static void IllegalMove()
        {
            System.Console.WriteLine("Illegal move!");
        }

        void PrintGameBoard(char[,] gameBoard)
        {
            //Console.Clear();

            int columnsCount = gameBoard.GetLength(1);
            int rowsCount = gameBoard.GetLength(0);

            //Build board columns enumeraction     0 1 2 3 4 5 6 7   
            System.Console.Write("   ");
            for (int column = 0; column < columnsCount; column++)
            {
                System.Console.Write("{0,2}", column);
            }
            System.Console.Write(" ");
            System.Console.WriteLine();

            //Build board line under column enumeration "   -----------------"
            System.Console.Write("   -");
            for (int column = 0; column < columnsCount; column++)
            {
                System.Console.Write("--", column);
            }
            System.Console.Write("  ");
            System.Console.WriteLine();

            for (int row = 0; row < rowsCount; row++)
            {
                System.Console.Write("{0} |", row);
                for (int column = 0; column < columnsCount; column++)
                {
                    System.Console.Write("{0,2}", gameBoard[row, column]);
                }
                System.Console.Write(" |");
                System.Console.WriteLine();
            }

            //Build board line under board "   -----------------  "
            System.Console.Write("   -");
            for (int column = 0; column < columnsCount; column++)
            {
                System.Console.Write("--", column);
            }
            System.Console.Write("  ");
            System.Console.WriteLine();
        }
    }
}
