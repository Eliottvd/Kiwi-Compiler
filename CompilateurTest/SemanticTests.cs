using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Compilateur.Tests
{
    [TestClass()]
    public class SemanticTests
    {
        [TestMethod()]
        public void VisitDemoTest()
        {
            var code = "Begin\n 5+2 \nEnd\n";
            var expectedResult = "start:"  + Environment.NewLine
                                           + "MOV AX,5" + Environment.NewLine
                                           + "ADD 2" + Environment.NewLine
                                           + "END start" + Environment.NewLine;

            var tree = Program.Parse(code);
            var asmCode = Program.PrintAssemblyCode(tree);
            Console.Out.WriteLine(asmCode);
            Assert.AreEqual(expectedResult, asmCode);
        }

        [TestMethod()]
        public void VisitDemoTest2()
        {
            var code = "Begin\n 5-2 \nEnd\n";
            var expectedResult = "start:"  + Environment.NewLine
                                           + "MOV AX,5" + Environment.NewLine
                                           + "SUB 2" + Environment.NewLine
                                           + "END start" + Environment.NewLine;

            var tree = Program.Parse(code);
            var asmCode = Program.PrintAssemblyCode(tree);
            Console.Out.WriteLine(asmCode);
            Assert.AreEqual(expectedResult, asmCode);
        }
    }
}