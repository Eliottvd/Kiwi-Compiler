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
        public void testassignation_assignation_bin_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\assignation_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\assignation_bin.asm");
        }

        [TestMethod()]
        public void testassignation_assignation_const_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\assignation_const.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\assignation_const.asm");
        }

        [TestMethod()]
        public void testassignation_assignation_dec_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\assignation_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\assignation_dec.asm");
        }

        [TestMethod()]
        public void testassignation_assignation_hex_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\assignation_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\assignation_hex.asm");
        }

        [TestMethod()]
        public void testassignation_declaration_bin_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\declaration_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\declaration_bin.asm");
        }

        [TestMethod()]
        public void testassignation_declaration_dec_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\declaration_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\declaration_dec.asm");
        }

        [TestMethod()]
        public void testassignation_declaration_hex_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ok\declaration_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ok\declaration_hex.asm");
        }

    //
    // Serie assignation KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_assignation_bin_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_assignation_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_assignation_bin.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ValueOverflowException))]
        public void testassignation_bad_assignation_dec_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_assignation_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_assignation_dec.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_assignation_hex_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_assignation_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_assignation_hex.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_bin_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_declaration_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_bin.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_dec_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_declaration_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_dec.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testassignation_bad_declaration_hex_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\assignation\ko\bad_declaration_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\assignation\ko\bad_declaration_hex.asm");
        }

    }
}
