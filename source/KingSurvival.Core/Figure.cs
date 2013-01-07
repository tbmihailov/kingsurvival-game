using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingSurvival.Core
{
    public class Figure
    {
        int _column;
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }

        int _row;
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        private char _displaySymbol;
        public char DisplaySymbol
        {
            get { return _displaySymbol; }
            set { _displaySymbol = value; }
        }

        private FigureType _type;
        public FigureType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        
        public Figure(FigureType type, char displaySymbol)
        {
            this.Type = type;
            this.DisplaySymbol = displaySymbol;
            this.Row = 0;
            this.Column = 0;
        }

        public Figure(FigureType type, char displaySymbol, int row, int column)
            : this(type, displaySymbol)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
