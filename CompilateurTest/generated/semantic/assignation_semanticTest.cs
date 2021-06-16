using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Compilateur.Exception;
using CompilateurTest._Masm;
namespace Compilateur.Tests
{
    [TestClass()]
    public class assignation_semanticTest
    {
                public string RootFolder => Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../").ToLower());
    //
    // Serie assignation 
    //
        [TestMethod()]
        public void testassignation_assign_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\assignation\assign_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\assignation\assign_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "assignation",  @"assign_instruction.asm", true);
            Assert.AreEqual("69", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testassignation_assign_simplection(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\assignation\assign_simplection.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\assignation\assign_simplection.asm");

            var res = AssemblyRunner.Start(RootFolder, "assignation",  @"assign_simplection.asm", true);
            Assert.AreEqual("71", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testassignation_complex_assign_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\assignation\complex_assign_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\assignation\complex_assign_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "assignation",  @"complex_assign_instruction.asm", true);
            Assert.AreEqual("2555", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testassignation_multi_assign_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\assignation\multi_assign_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\assignation\multi_assign_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "assignation",  @"multi_assign_instruction.asm", true);
            Assert.AreEqual("6925505", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testassignation_paranthesis_assign_instruction(){
            Program.Compile(@"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\semantic\assignation\paranthesis_assign_instruction.kiwi", 
                    @"D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\CompilateurTest\generated\output\semantic\assignation\paranthesis_assign_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "assignation",  @"paranthesis_assign_instruction.asm", true);
            Assert.AreEqual("50125", res, "Le r�sultat de sortie de l'assembleur n'est pas celui attentdu");
        }

    }
}
