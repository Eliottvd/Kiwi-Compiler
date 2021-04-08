using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class instruction_SyntaxTest
    {
    //
    // Serie instruction OK
    //
        [TestMethod()]
        public void testinstruction_add_instruction_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\instruction\ok\add_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\instruction\ok\add_instruction.asm");
        }

        [TestMethod()]
        public void testinstruction_arith_instruction_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\instruction\ok\arith_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\instruction\ok\arith_instruction.asm");
        }

        [TestMethod()]
        public void testinstruction_binary_instruction_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\instruction\ok\binary_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\instruction\ok\binary_instruction.asm");
        }

        [TestMethod()]
        public void testinstruction_print_instruction_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\instruction\ok\print_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\instruction\ok\print_instruction.asm");
        }

    //
    // Serie instruction KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testinstruction_bad_add_instruction_ko(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\instruction\ko\bad_add_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\instruction\ko\bad_add_instruction.asm");
        }

    }
}
