using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingSurvival.Core
{
    public class KingSurvivalGame
    {
        const int GAMEBOARD_SIZE = 8;
        const char BLACK_FIELD = '-';
        const char WHITE_FIELD = '+';

        char[,] _gameBoard;
        public char[,] GameBoard
        {
            get { return _gameBoard; }
            set { _gameBoard = value; }
        }

        public bool IsKingTurn
        {
            get
            {
                bool isKingTurn = IsCurrentMoveNumberOdd();

                return isKingTurn;
            }
        }

        public bool IsPawnsTurn
        {
            get
            {
                bool isPawnsTurn = IsCurrentMoveNumberEven();

                return isPawnsTurn;
            }
        }

        Figure _king;
        public Figure King
        {
            get { return _king; }
            set { _king = value; }
        }

        private List<Figure> _figures;
        public List<Figure> Figures
        {
            get
            {
                if (_figures == null)
                {
                    _figures = new List<Figure>();
                }
                return _figures;
            }
            set { _figures = value; }
        }

        private int _kingMovesCount;
        public int KingMovesCount
        {
            get { return _kingMovesCount; }
            private set { _kingMovesCount = value; }
        }

        private int _pawnsMovesCount;
        public int PawnsMovesCount
        {
            get { return _pawnsMovesCount; }
            private set { _pawnsMovesCount = value; }
        }

        public int MovesCount
        {
            get
            {
                int movesCount = KingMovesCount + PawnsMovesCount;
                return movesCount;
            }
        }

        private bool IsCurrentMoveNumberEven()
        {
            int currentMoveNumber = MovesCount + 1;

            bool isPawnsTurn = true;
            if (currentMoveNumber % 2 == 0)
            {
                isPawnsTurn = true;
            }
            else
            {
                isPawnsTurn = false;
            }
            return isPawnsTurn;
        }

        private bool IsCurrentMoveNumberOdd()
        {
            bool isCurrentMoveNumberEven = IsCurrentMoveNumberEven();
            bool isCurrentMoveNumberOdd = !isCurrentMoveNumberEven;

            return isCurrentMoveNumberOdd;
        }

        public bool KingMove(int columnDirection, int rowDirection)
        {
            var king = King;

            bool isKingTurn = IsKingTurn;
            bool isKingMoveValid = TryFigureMove(king, rowDirection, columnDirection, isKingTurn);
            return isKingMoveValid;
        }

        public KingSurvivalGame()
        {
        }

        public bool TryFigureMove(Figure currentFigure, int rowDirection, int columnDirection, bool isKingTurn)
        {
            if (currentFigure == null)
            {
                throw new ArgumentNullException("currentFigure must not be null!");
            }

            bool isFigureMovingInCorrectTurn = IsFigureMovingInCorrectTurn(currentFigure, isKingTurn);
            if (!isFigureMovingInCorrectTurn)
            {
                return false;
            }


            int nextFigureRow = currentFigure.Row + rowDirection;
            int nextFigureColumn = currentFigure.Column + columnDirection;
            bool isFigureMoveValid = IsCellValidForMoveTo(nextFigureRow, nextFigureColumn);
            if (!isFigureMoveValid)
            {
                return false;
            }

            MoveFigureOnTheBoard(currentFigure, nextFigureRow, nextFigureColumn);
            if (isKingTurn)
            {
                KingMovesCount++;
            }
            else
            {
                PawnsMovesCount++;
            }

            return isFigureMoveValid;
        }

        private static bool IsFigureMovingInCorrectTurn(Figure currentFigure, bool isKingTurn)
        {
            bool isFigureMovingInCorrectTurn = true;
            //Check if now is king turn and figure is a pawn
            bool isPawnTurn = !isKingTurn;
            var currentFigureType = currentFigure.Type;
            if (isKingTurn && currentFigureType == FigureType.Pawn)
            {
                //It is king turn and figure is a pawn
                isFigureMovingInCorrectTurn = false;
            }
            else
                if (isPawnTurn && currentFigureType == FigureType.King)
                {
                    //It is a pawns turn and figure is a king
                    isFigureMovingInCorrectTurn = false;
                }
            return isFigureMovingInCorrectTurn;
        }

        private void MoveFigureOnTheBoard(Figure currentFigure, int nextFigureRow, int nextFigureColumn)
        {
            int figureCurrentRow = currentFigure.Row;
            int figureCurrentColumn = currentFigure.Column;

            GameBoard[figureCurrentRow, figureCurrentColumn] = GetBoardCellColorSymbol(figureCurrentRow, figureCurrentColumn);
            GameBoard[nextFigureRow, nextFigureColumn] = currentFigure.DisplaySymbol;

            currentFigure.Row = nextFigureRow;
            currentFigure.Column = nextFigureColumn;
        }

        private bool IsCellValidForMoveTo(int row, int column)
        {
            bool isCellValidForMoveTo = true;

            int gameBoardMaxColumn = GameBoard.GetLength(1);
            int gameBoardMaxRow = GameBoard.GetLength(0);

            if ((column < 0 || column > gameBoardMaxColumn - 1)
              || (row < 0 || row > gameBoardMaxRow - 1)
              || ((GameBoard[row, column] != '+')
                      && (GameBoard[row, column] != '-')))
            {
                isCellValidForMoveTo = false;
            }

            return isCellValidForMoveTo;
        }

        public void Start()
        {
            SetInitialGameState();
        }

        public bool IsKingLose()
        {
            bool hasKingValidMoves = true;
            int row = King.Row;
            int column = King.Column;
            if ((!IsCellValidForMoveTo(row + 1, column + 1))
               && (!IsCellValidForMoveTo(row + 1, column - 1))
               && (!IsCellValidForMoveTo(row - 1, column + 1))
               && (!IsCellValidForMoveTo(row - 1, column - 1))
                )
            {
                hasKingValidMoves = false;
            }

            bool isKingLose = !hasKingValidMoves;
            return isKingLose;
        }

        private Figure GetFigureBySymbolFromCurrentGame(char symbol)
        {
            var figure = GetFigureBySymbol(symbol, this.Figures);
            return figure;
        }

        private Figure GetFigureBySymbol(char symbol, IEnumerable<Figure> figures)
        {
            var figure = figures.Where(f => f.DisplaySymbol == symbol).FirstOrDefault();
            return figure;
        }

        public bool IsKingWin()
        {
            bool isKingOnTop = IsKingOnTop();
            if (isKingOnTop)
            {
                return true;
            }

            bool hasPawnsValidMove = HasPawnsValidMoves();

            bool isKingWin = false;
            if (isKingOnTop || !hasPawnsValidMove)
            {
                isKingWin = true;
            }

            return isKingWin;
        }

        private bool IsKingOnTop()
        {
            //King wins if he is on top
            int kingRow = King.Row;
            bool isKingOnTop = IsFigureOnTop(kingRow);
            return isKingOnTop;
        }

        private bool HasPawnsValidMoves()
        {
            //King wins if pawns has no more valid moves
            bool hasPawnsValidMove = false;
            var pawns = Figures.Where(f => f.Type == FigureType.Pawn);
            foreach (var pawn in pawns)
            {
                if (HasPawnValidMoves(pawn.Row, pawn.Column))
                {
                    hasPawnsValidMove = true;
                    break;
                }
            }
            return hasPawnsValidMove;
        }

        private bool IsFigureOnTop(int row)
        {
            if (row <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasPawnValidMoves(int currentRow, int currentColumn)
        {
            bool hasFigureValidMoves = true;
            int row = currentRow;
            int column = currentColumn;
            if ((!IsCellValidForMoveTo(row + 1, column + 1))
             && (!IsCellValidForMoveTo(row + 1, column - 1)))
            {
                hasFigureValidMoves = false;
            }

            return hasFigureValidMoves;
        }

        private void SetInitialGameState()
        {
            GameBoard = GenerateGameBoard(GAMEBOARD_SIZE);
            InitializeFigures();
            PlaceFiguresOnGameBoard();
        }

        private void InitializeFigures()
        {
            King = AddFigureToGame(FigureType.King, 'K', 7, 3); ;

            AddFigureToGame(FigureType.Pawn, 'A', 0, 0);
            AddFigureToGame(FigureType.Pawn, 'B', 0, 2);
            AddFigureToGame(FigureType.Pawn, 'C', 0, 4);
            AddFigureToGame(FigureType.Pawn, 'D', 0, 6);
        }

        private Figure AddFigureToGame(FigureType figureType, char figureSymbol, int row, int column)
        {
            if (this.Figures.Where(f => f.DisplaySymbol == figureSymbol).Count()>0)
            {
                throw new FigureExistsException(string.Format("Figure {0} already exists!", figureSymbol));
            }

            var figure = new Figure(figureType, figureSymbol, row, column);
            Figures.Add(figure);

            return figure;
        }

        private void PlaceFiguresOnGameBoard()
        {
            foreach (Figure figure in Figures)
            {
                GameBoard[figure.Row, figure.Column] = figure.DisplaySymbol;
            }
        }

        private char[,] GenerateGameBoard(int GAMEBOARD_SIZE)
        {
            var gameBoard = new char[GAMEBOARD_SIZE, GAMEBOARD_SIZE];

            int gameBoardRows = gameBoard.GetLength(0);
            int gameBoardColumns = gameBoard.GetLength(1);

            for (int row = 0; row < gameBoardRows; row++)
            {
                for (int column = 0; column < gameBoardColumns; column++)
                {
                    char currentCellValue = GetBoardCellColorSymbol(row, column);
                    gameBoard[row, column] = currentCellValue;
                }
            }

            return gameBoard;
        }

        private static char GetBoardCellColorSymbol(int row, int column)
        {
            char currentCellValue = ' ';
            if (row % 2 == 0)
            {
                if (column % 2 == 0)
                {
                    currentCellValue = WHITE_FIELD;
                }
                else
                {
                    currentCellValue = BLACK_FIELD;
                }
            }
            else
            {
                if (column % 2 == 0)
                {
                    currentCellValue = BLACK_FIELD;
                }
                else
                {
                    currentCellValue = WHITE_FIELD;
                }
            }
            return currentCellValue;
        }
    }
}

