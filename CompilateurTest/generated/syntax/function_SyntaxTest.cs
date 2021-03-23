using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class function_SyntaxTest
    {
    //
    // Serie function OK
    //
        [TestMethod()]
        public void testfunction_function_sum_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\function\ok\function_sum.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\function\ok\function_sum.asm");
        }

    //
    // Serie function KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testfunction_function_missing_paranthesis_ko(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\function\ko\function_missing_paranthesis.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\function\ko\function_missing_paranthesis.asm");
        }

    }
}
