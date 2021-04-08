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
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\semantic\instruction\add_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\add_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"add_instruction.asm", false);
            Assert.AreEqual(res, "", "Le résultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_add_print_instruction(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\semantic\instruction\add_print_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\add_print_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"add_print_instruction.asm", false);
            Assert.AreEqual(res, "10", "Le résultat de sortie de l'assembleur n'est pas celui attentdu");
        }

        [TestMethod()]
        public void testinstruction_sub_print_instruction(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\semantic\instruction\sub_print_instruction.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\semantic\instruction\sub_print_instruction.asm");

            var res = AssemblyRunner.Start(RootFolder, "instruction",  @"sub_print_instruction.asm", false);
            Assert.AreEqual(res, "0\n10", "Le résultat de sortie de l'assembleur n'est pas celui attentdu");
        }

    }
}
