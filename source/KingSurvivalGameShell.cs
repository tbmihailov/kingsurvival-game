using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KingSurvival.Core;
namespace KingSurvival.Console
{
    class KingSurvivalGameShell
    {
        static void Main()
        {
            KingSurvivalGameConsole kingSurvivalGameConsole = new KingSurvivalGameConsole();
            kingSurvivalGameConsole.Start();
        }
    }
}
