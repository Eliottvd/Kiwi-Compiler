using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class assignation_SyntaxTest
    {
    //
    // Serie assignation OK
    //
        [TestMethod()]
        public void testassignation_declaration_bin_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ok\declaration_bin.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ok\declaration_bin.asm");
        }

        [TestMethod()]
        public void testassignation_declaration_dec_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ok\declaration_dec.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ok\declaration_dec.asm");
        }

        [TestMethod()]
        public void testassignation_declaration_hex_ok(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ok\declaration_hex.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ok\declaration_hex.asm");
        }

    //
    // Serie assignation KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_bin_ko(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ko\bad_declaration_bin.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_bin.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_dec_ko(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ko\bad_declaration_dec.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_dec.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_hex_ko(){
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\syntax\assignation\ko\bad_declaration_hex.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_hex.asm");
        }

    }
}
