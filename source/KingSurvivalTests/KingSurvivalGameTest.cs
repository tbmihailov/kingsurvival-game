using KingSurvival;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using KingSurvival.Console;
using KingSurvival.Core;
using System.Collections.Generic;

namespace KingSurvivalTests
{


    /// <summary>
    ///This is a test class for KingSurvivalGameTest and is intended
    ///to contain all KingSurvivalGameTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KingSurvivalGameTest
    {

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void PawnD_Trying_To_Get_On_King()
        {

            string consoleInput = "KUR\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KDL\n" +
                                "DDR\n" +
                                "KUR\n" +
                                "CDR\n" +
                                "KDL\n" +
                                "DDR\n";
            string expectedConsoleOutput =
                "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - D - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - D - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - D - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - D - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - D - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - D - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - D - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - D - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - D - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - D - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - D - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void PawnC_Trying_To_Get_On_King()
        {

            string consoleInput = "KUR\n" +
                                "CDL\n" +
                                "KUR\n" +
                                "CDR\n" +
                                "KUR\n" +
                                "CDR\n" +
                                "KUR\n" +
                                "DDR\n" +
                                "KDL\n" +
                                "CDR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - K |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - + - D |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - K |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - + - D |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - + - D |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void PawnB_Trying_To_Get_On_King()
        {

            string consoleInput = "KUR\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KDR\n" +
                                "CDR\n" +
                                "KDL\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - B - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - B - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - K |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - + - D - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - K |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - + - D - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - K - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - + - D - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - B - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - K - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - + - D - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - B - |\r\n5 | - + - + - + - K |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - + - D - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - B - |\r\n5 | - + - + - + - K |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void PawnA_Trying_To_Get_On_King()
        {

            string consoleInput = "KUR\n" +
                                "ADR\n" +
                                "KUL\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KDL\n" +
                                "ADR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - A - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - A - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - A - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - A - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - K - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - K - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void King_Trying_To_Get_On_A()
        {

            string consoleInput = "KUR\n" +
                                "ADR\n" +
                                "KUL\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KUL\n";
            string expectedConsoleOutput =
     "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - A - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - A - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - A - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - A - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | + - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - A - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void King_Trying_To_Get_On_B()
        {

            string consoleInput = "KUR\n" +
                                "BDR\n" +
                                "KUL\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KUR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - B - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - B - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - B - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - + - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - B - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void King_Trying_To_Get_On_C()
        {

            string consoleInput = "KUR\n" +
                                "CDL\n" +
                                "KUL\n" +
                                "CDR\n" +
                                "KUR\n" +
                                "CDR\n" +
                                "KUR\n";
            string expectedConsoleOutput =
     "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - K - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - C - + |\r\n4 | + - + - K - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void King_Trying_To_Get_On_D()
        {

            string consoleInput = "KUR\n" +
                                "DDR\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDR\n" +
                                "KUR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - D |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - D |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - D - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - D - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - D |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - D |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void KingGettingOutOfBoundsUpLeft()
        {

            string consoleInput = "KUL\n" +
                                "CDL\n" +
                                "KUL\n" +
                                "CDR\n" +
                                "KUL\n" +
                                "CDL\n" +
                                "KUL\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - K - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - K - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - C - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - K - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - K - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - C - + - |\r\n3 | - + - + - + - + |\r\n4 | K - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - C - + - + |\r\n4 | K - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - C - + - + |\r\n4 | K - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void KingGettingOutOfBoundsDownLeft()
        {

            string consoleInput = "KDL\n";

            string expectedConsoleOutput =
                "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void KingGettingOutOfBoundsDownRight()
        {

            string consoleInput = "KDR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void MainGeneralCaseKingLosesTest()
        {
            string consoleInput = "KUR\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDR\n" +
                                "KUR\n" +
                                "DDR\n" +
                                "KUL\n" +
                                "CDR\n" +
                                "KDR\n" +
                                "CDR\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - D - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - D - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - D - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - K - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - D - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - D - + |\r\n4 | + - + - + - K - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - D - K |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - K |\r\n4 | + - + - + - D - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - K - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - D - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - K - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - D - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - C - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - K |\r\n4 | + - + - + - D - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - + - + - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - C - |\r\n3 | - + - + - + - K |\r\n4 | + - + - + - D - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nKing loses.\r\n";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void IllegalKingMoreThanThreeLetterCommand()
        {

            string consoleInput = "KALADSD\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void IllegalPawnThreeLetterCommandTest()
        {

            string consoleInput = "KUR\n" +
                                 "CAL\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void IllegalPawnMoreThanThreeLetterCommand()
        {

            string consoleInput = "KUR\n" +
                                 "CARADS\n";
            string expectedConsoleOutput =
    "    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - + - + - |\r\n7 | - + - K - + - + |\r\n   -----------------  \r\nKing's turn:    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn: Illegal move!\r\n    0 1 2 3 4 5 6 7 \r\n   -----------------  \r\n0 | A - B - C - D - |\r\n1 | - + - + - + - + |\r\n2 | + - + - + - + - |\r\n3 | - + - + - + - + |\r\n4 | + - + - + - + - |\r\n5 | - + - + - + - + |\r\n6 | + - + - K - + - |\r\n7 | - + - + - + - + |\r\n   -----------------  \r\nPawns' turn:";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }

        [TestMethod()]
        [DeploymentItem("KingSurvival.Console.exe")]
        public void KingWinsAllPawnsOnLowestRow()
        {

            string consoleInput = "KUR\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KDL\n" +
                                "ADR\n" +
                                "KUR\n" +
                                "ADR\n" +
                                "KDL\n" +
                                "ADR\n" +
                                "KUR\n" +

                                "BDL\n" +
                                "KDL\n" +
                                "BDL\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KDL\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n" +
                                "KDL\n" +
                                "BDR\n" +
                                "KUR\n" +
                                "BDR\n" +

                                "KDL\n" +
                                "CDL\n" +
                                "KUR\n" +
                                "CDL\n" +
                                "KDL\n" +
                                "CDL\n" +
                                "KUR\n" +
                                "CDL\n" +
                                "KDL\n" +
                                "CDR\n" +
                                "KUR\n" +
                                "CDR\n" +
                                "KDL\n" +
                                "CDR\n" +

                                "KUR\n" +
                                "DDL\n" +
                                "KDL\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KDL\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDL\n" +
                                "KDL\n" +
                                "DDL\n" +
                                "KUR\n" +
                                "DDR\n";
            string expectedConsoleOutput =
    @"    0 1 2 3 4 5 6 7 
   -----------------  
0 | A - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - K - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | A - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - K - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - A - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - K - + - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - A - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - + - |
5 | - + - + - K - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - A - + - + - |
3 | - + - + - + - + |
4 | + - + - + - + - |
5 | - + - + - K - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - A - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - A - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - A - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - A - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - A - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - A - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - A - + |
6 | + - + - + - + - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - A - |
7 | - + - + - + - + |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - A - |
7 | - + - + - + - + |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - B - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - B - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - B - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | B - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | B - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - B - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - B - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - B - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - B - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - B - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - B - + - + |
6 | + - + - + - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - B - + - |
7 | - + - + - + - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - B - + - |
7 | - + - + - + - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - C - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - C - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - C - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - C - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - C - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - C - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - C - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | C - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | C - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - C - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - C - + - + - + |
6 | + - + - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - C - + - + - |
7 | - + - + - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - C - + - + - |
7 | - + - + - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - D - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - D - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - D - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - D - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - D - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - D - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - D - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - D - + - K - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - D - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - D - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - D - + - + - + |
6 | + - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - + |
4 | + - + - + - K - |
5 | - + - + - + - + |
6 | D - + - + - + - |
7 | - + - C - B - A |
   -----------------  
King's turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | D - + - + - + - |
7 | - + - C - B - A |
   -----------------  
Pawns' turn:    0 1 2 3 4 5 6 7 
   -----------------  
0 | + - + - + - + - |
1 | - + - + - + - + |
2 | + - + - + - + - |
3 | - + - + - + - K |
4 | + - + - + - + - |
5 | - + - + - + - + |
6 | + - + - + - + - |
7 | - D - C - B - A |
   -----------------  
King wins in 28 turns.
";
            string actualConsoleOutput = ExecuteMainProgramMethod(consoleInput);
            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput);
        }



        private string ExecuteMainProgramMethod(string consoleInput)
        {
            StringReader inputReader = new StringReader(consoleInput);
            StringWriter outputWriter = new StringWriter();
            Console.SetIn(inputReader);
            Console.SetOut(outputWriter);
            try
            {
                KingSurvivalGameShell_Accessor.Main();
            }
            catch (Exception)
            {
            }
            string consoleOutput = outputWriter.ToString();
            return consoleOutput;
        }

        private void AssertGameBoardsAreEqual(
            int[,] firstBoard, int[,] secondBoard)
        {
            Assert.IsNotNull(firstBoard);
            Assert.IsNotNull(secondBoard);

            int rowsCountFirstMatrix = firstBoard.GetLength(0);
            int rowsCountSecondMatrix = secondBoard.GetLength(0);
            Assert.AreEqual(rowsCountFirstMatrix, rowsCountSecondMatrix);

            int columnsCountFirstMatrix = firstBoard.GetLength(1);
            int columnsCountSecondMatrix = secondBoard.GetLength(1);
            Assert.AreEqual(columnsCountFirstMatrix, columnsCountSecondMatrix);

            for (int row = 0; row < rowsCountFirstMatrix; row++)
            {
                for (int col = 0; col < columnsCountFirstMatrix; col++)
                {
                    int firstCell = firstBoard[row, col];
                    int secondCell = secondBoard[row, col];
                    Assert.AreEqual(firstCell, secondCell);
                }
            }
        }

        


    }
}
