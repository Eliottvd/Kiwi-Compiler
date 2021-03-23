using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;

namespace Compilateur.Tests
{
    [TestClass()]
    public class SyntaxTest
    {
        [DataTestMethod]  
        [DataRow("Begin\n 4*8 \nEnd", "Bad operator")]  
        [DataRow("4*8 \nEnd", "Missing Begin")]  
        [DataRow("Begin\n 4+8", "Missing end")]  
        [DataRow("4*8", "Missing both")]  
        [ExpectedException(typeof(ParsingException))]
        public void ErrorTest(string code, string other)
        {
            Console.Out.WriteLine(code + Environment.NewLine);
            var context = Program.Parse(code);
        }

        [DataTestMethod]  
        [DataRow("Begin\n print(5+2) \nEnd\n", "Bad expression")]  
        [DataRow("Begin\n 5+2 \nEnd\n", "Bad expression")]  
        [DataRow("Begin\n /*Mon commentaire*/ \nEnd", "Bad expression")]  
        [DataRow("Begin\n /*Mon commentaire*/ \n4+6 \nEnd", "Bad expression")]  
        public void BeginEndTest(string code, string other)
        {
            Console.Out.WriteLine(code + Environment.NewLine);
            var context = Program.Parse(code);
        }
    }
}