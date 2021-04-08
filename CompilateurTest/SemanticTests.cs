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
            var code = "Begin\n 5+2 \nEnd\n";
            var tree = Program.Parse(code);
            var asmCode = Program.PrintAssemblyCode(tree);
            Console.Out.WriteLine(asmCode);
            var expectedResult = File.ReadAllText("../../../expectedResults/er1.txt");
            Assert.AreEqual(expectedResult, asmCode);
        }
    }
}