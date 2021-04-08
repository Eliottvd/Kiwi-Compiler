using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class function_SyntaxTest
    {
    //
    // Serie function OK
    //
        [TestMethod()]
        public void testfunction_function_sous_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\function\ok\function_sous.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\function\ok\function_sous.asm");
        }

        [TestMethod()]
        public void testfunction_function_sum_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\function\ok\function_sum.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\function\ok\function_sum.asm");
        }

    //
    // Serie function KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testfunction_function_missing_paranthesis_ko(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\function\ko\function_missing_paranthesis.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\function\ko\function_missing_paranthesis.asm");
        }

    }
}
