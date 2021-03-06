using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class kiwi_language_SyntaxTest
    {
    //
    // Serie kiwi_language OK
    //
        [TestMethod()]
        public void testkiwi_language_begin_nop_end_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ok\begin_nop_end.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ok\begin_nop_end.asm");
        }

        [TestMethod()]
        public void testkiwi_language_program1_ok(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ok\program1.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ok\program1.asm");
        }

    //
    // Serie kiwi_language KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testkiwi_language_missing_begin_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ko\missing_begin.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ko\missing_begin.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testkiwi_language_missing_begin2_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ko\missing_begin2.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ko\missing_begin2.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testkiwi_language_missing_end_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ko\missing_end.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ko\missing_end.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testkiwi_language_missing_end2_ko(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\syntax\kiwi_language\ko\missing_end2.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\syntax\kiwi_language\ko\missing_end2.asm");
        }

    }
}
