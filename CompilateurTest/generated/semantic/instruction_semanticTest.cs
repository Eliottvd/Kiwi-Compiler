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
            Program.Compile(@"C:\Tmp\Compilateur\CompilateurTest\semantic\instruction\add_instruction.kiwi", 
                    @"C:\Tmp\Compilateur\CompilateurTest\generated\output\semantic\instruction\add_instruction.asm");

            AssemblyRunner.Start(RootFolder, "instruction",  @"add_instruction.asm");

        }

    }
}
