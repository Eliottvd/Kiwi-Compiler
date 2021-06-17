using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Compilateur.Exception;
using CompilateurTest._Masm;
namespace Compilateur.Tests
{
    [TestClass()]
    public class instruction_semanticTest
    {
                public string RootFolder => Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../").ToLower());
    //
    // Serie instruction 
    //
        [TestMethod()]
        public void testinstruction_add_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\instruction\add_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\add_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"add_instruction.asm", true);
            Assert.AreEqual("", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_add_print_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\instruction\add_print_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\add_print_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"add_print_instruction.asm", true);
            Assert.AreEqual("101010", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_declaration_All(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\instruction\declaration_All.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\declaration_All.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"declaration_All.asm", true);
            Assert.AreEqual("25502", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_sub_print_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\instruction\sub_print_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\sub_print_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"sub_print_instruction.asm", true);
            Assert.AreEqual("010", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_var_print_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\instruction\var_print_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\var_print_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"var_print_instruction.asm", true);
            Assert.AreEqual("010052010", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

    }
}
