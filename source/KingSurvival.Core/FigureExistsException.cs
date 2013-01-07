using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingSurvival.Core
{
    class FigureExistsException : Exception
    {
        public FigureExistsException(string message)
            : base(message)
        {

        }
    }
}
