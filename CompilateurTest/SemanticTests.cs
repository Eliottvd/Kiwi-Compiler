using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Compilateur.Tests
{
    [TestClass()]
    public class SemanticTests
    {
        [TestMethod()]
        public void VisitDemoTest()
        {
            var code = "Begin\n 5+2 \n 6++ \n 10-- \n End\n";
            var tree = Program.Parse(code);
            var asmCode = Program.PrintAssemblyCode(tree);
            Console.Out.WriteLine(asmCode);
            var expectedResult = File.ReadAllText("../../../expectedResults/er1.asm");
            Assert.AreEqual(expectedResult, asmCode);
        }
    }
}