using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class variable_SyntaxTest
    {
    //
    // Serie variable OK
    //
        [TestMethod()]
        public void testvariable_var_byte_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\variable\ok\var_byte.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\variable\ok\var_byte.asm");
        }

        [TestMethod()]
        public void testvariable_var_word_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\variable\ok\var_word.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\variable\ok\var_word.asm");
        }

    //
    // Serie variable KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testvariable_bad_type_ko(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\variable\ko\bad_type.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\variable\ko\bad_type.asm");
        }

    }
}
