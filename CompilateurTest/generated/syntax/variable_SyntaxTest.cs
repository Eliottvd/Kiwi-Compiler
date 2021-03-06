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
        public void testvariable_const_number_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\const_number.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\const_number.asm");
        }

        [TestMethod()]
        public void testvariable_const_string_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\const_string.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\const_string.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_All_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_All.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_All.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_bin_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_bin.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_const_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_const.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_const.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_dec_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_dec.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_hex_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_hex.asm");
        }

        [TestMethod()]
        public void testvariable_declaration_string_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\declaration_string.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\declaration_string.asm");
        }

        [TestMethod()]
        public void testvariable_var_byte_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\var_byte.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\var_byte.asm");
        }

        [TestMethod()]
        public void testvariable_var_string_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\var_string.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\var_string.asm");
        }

        [TestMethod()]
        public void testvariable_var_word_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ok\var_word.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ok\var_word.asm");
        }

    //
    // Serie variable KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testvariable_bad_declaration_bin_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ko\bad_declaration_bin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ko\bad_declaration_bin.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ValueOverflowException))]
        public void testvariable_bad_declaration_dec_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ko\bad_declaration_dec.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ko\bad_declaration_dec.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testvariable_bad_declaration_hex_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ko\bad_declaration_hex.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ko\bad_declaration_hex.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testvariable_bad_type_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ko\bad_type.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ko\bad_type.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(SymbolAlreadyDefinedException))]
        public void testvariable_var_redefinition_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\variable\ko\var_redefinition.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\variable\ko\var_redefinition.asm");
        }

    }
}
