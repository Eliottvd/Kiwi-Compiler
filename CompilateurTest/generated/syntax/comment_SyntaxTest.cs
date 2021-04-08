using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Compilateur.Exception;
namespace Compilateur.Tests
{
    [TestClass()]
    public class comment_SyntaxTest
    {
    //
    // Serie comment OK
    //
        [TestMethod()]
        public void testcomment_end_comment_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\comment\ok\end_comment.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\comment\ok\end_comment.asm");
        }

        [TestMethod()]
        public void testcomment_everywhere_comment_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\comment\ok\everywhere_comment.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\comment\ok\everywhere_comment.asm");
        }

        [TestMethod()]
        public void testcomment_start_comment_ok(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\comment\ok\start_comment.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\comment\ok\start_comment.asm");
        }

    //
    // Serie comment KO
    //
        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testcomment_bad_comment_ko(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\comment\ko\bad_comment.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\comment\ko\bad_comment.asm");
        }

        [TestMethod()]
        [ExpectedException(typeof(ParsingException))]
        public void testcomment_other_bad_comment_ko(){
            Program.Compile(@"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\syntax\comment\ko\other_bad_comment.kiwi", 
                    @"D:\OneDrive - Enseignement de la Province de Liège\Ecole\PASSERELLE\Q2\WK_ Systemes a microp\Kiwi-Compiler\CompilateurTest\generated\output\syntax\comment\ko\other_bad_comment.asm");
        }

    }
}
