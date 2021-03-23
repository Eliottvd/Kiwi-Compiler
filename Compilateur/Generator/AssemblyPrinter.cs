using System.IO;

namespace Compilateur.Generator
{
    /// <summary>
    /// Représente un générateur lexicale d'assembleur sur un flux de sortie
    /// AssemblyPrinter est mutable
    /// De manière générale, AssemblyPrinter est représenté par un fluxdesortie
    /// 
    /// fluxdesortie : StreamWriter //le flux de sortie sur lequel est généré l'assembleur
    ///
    /// 
    /// data segment
    ///     YOUR DECLARATION HERE
    /// data ends
    /// 
    /// code segment
    ///     assume cs:code, ds:data
    /// start:
    ///
    ///     YOU CODE HERE
    /// 
    /// code ends
    /// end start
    /// </summary>
    public class AssemblyPrinter
    {
        private TextWriter writer;

        #region Constructor

        public AssemblyPrinter(StringWriter writer)
        {
            this.writer = writer;
        }
        public AssemblyPrinter(StreamWriter writer)
        {
            this.writer = writer;
        }

        #endregion Constructor

        public void Flush()
        {
            this.writer.Flush();
        }

        public void Close()
        {
            this.writer.Close();
        }

        public void PrintBegin()
        {
            this.writer.WriteLine("data segment");
            this.writer.WriteLine("    msg db \"My message$\"");
            this.writer.WriteLine("data ends");
            this.writer.WriteLine("");
            this.writer.WriteLine("code segment");
            this.writer.WriteLine("    assume cs:code, ds:data");
            this.writer.WriteLine("start:");
        }

        public void PrintEnd()
        {
            // INT 21h / AH=4Ch - return control to the operating system (stop program).
            this.writer.WriteLine("    mov ah, 4ch");
            this.writer.WriteLine("    int 21h");

            this.writer.WriteLine("code ends");
            this.writer.WriteLine("end start");
        }

        public void PrintMov(AssemblyRegister register, byte b)
        {
            this.writer.WriteLine("    MOV " + register + "," + b);
        }

        public void PrintAdd(AssemblyRegister register, AssemblyRegister register2)
        {
            this.writer.WriteLine("    ADD " + register + "," + register2);
        }
        public void PrintAdd(AssemblyRegister register, byte b)
        {
            this.writer.WriteLine("    ADD " + register + "," + b);
        }
    }
}
