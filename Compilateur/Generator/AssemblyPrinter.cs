﻿using System;
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

            this.PrintPusha();
            this.PrintPopa();
            this.PrintProcPrintAX();
            this.PrintProcPrintEndl();
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

        public void PrintSub(AssemblyRegister register, AssemblyRegister register2)
        {
            this.writer.WriteLine("    SUB " + register + "," + register2);
        }

        public void PrintNot(AssemblyRegister register)
        {
            this.writer.WriteLine("    NOT " + register);
        }

        public void PrintProcPrintAX()
        {
            var v = Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  Affiche la valeur entiere de AX " + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    "print_ax PROC" + Environment.NewLine +
                    "CMP AX, 0" + Environment.NewLine +
                    "JNE print_ax_r" + Environment.NewLine +
                    "    PUSH AX" + Environment.NewLine +
                    "    MOV DL, '0'" + Environment.NewLine +
                    "    MOV AH, 02h" + Environment.NewLine +
                    "    INT 21h" + Environment.NewLine +
                    "    POP AX" + Environment.NewLine +
                    "    RET " + Environment.NewLine +
                    "print_ax_r:" + Environment.NewLine +
                    "    PUSHA" + Environment.NewLine +
                    "    MOV DX, 0" + Environment.NewLine +
                    "    CMP AX, 0" + Environment.NewLine +
                    "    JE pn_done" + Environment.NewLine +
                    "    MOV BX, 10" + Environment.NewLine +
                    "    DIV BX" +     Environment.NewLine +
                    "    CALL print_ax_r" + Environment.NewLine +
                    "    MOV AX, DX" + Environment.NewLine +
                    "    ADD AL, 30h" + Environment.NewLine +
                    "    MOV DL, AL" + Environment.NewLine +
                    "    MOV AH, 02h" + Environment.NewLine +
                    "    INT 21h" + Environment.NewLine +
                    "    JMP pn_done" + Environment.NewLine +
                    "pn_done:" + Environment.NewLine +
                    "    POPA" + Environment.NewLine +
                    "    RET" + Environment.NewLine +
                    "print_ax ENDP" +  Environment.NewLine;
            this.writer.WriteLine(v);
        }

        public void PrintProcPrintEndl()
        {
            var v = Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  Affiche une nouvelle ligne" + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    "print_nl PROC " + Environment.NewLine +
                    "    PUSH AX  " + Environment.NewLine +
                    "    PUSH DX " + Environment.NewLine +
                    "    MOV AH, 2" + Environment.NewLine +
                    "    MOV DL, 0Dh" + Environment.NewLine +
                    "    INT 21h" + Environment.NewLine +
                    "    MOV DL, 0Ah" + Environment.NewLine +
                    "    INT 21h" + Environment.NewLine +
                    "    POP DX " + Environment.NewLine +
                    "    POP AX" + Environment.NewLine +
                    "    RET" + Environment.NewLine +
                    "print_nl ENDP" + Environment.NewLine;
            this.writer.WriteLine(v);
        }

        public void PrintPusha()
        {
            var v = Environment.NewLine +
                    "PUSHA    MACRO" + Environment.NewLine +
                    "    push ax" + Environment.NewLine +
                    "    push bx" + Environment.NewLine +
                    "    push cx" + Environment.NewLine +
                    "    push dx" + Environment.NewLine +
                    "    push bp" + Environment.NewLine +
                    "    push si" + Environment.NewLine +
                    "    push di" + Environment.NewLine +
                    "ENDM" + Environment.NewLine;
            this.writer.WriteLine(v);
        }

        public void PrintPopa()
        {
            var v = Environment.NewLine +
                    "POPA MACRO" + Environment.NewLine +
                    "    pop di" + Environment.NewLine +
                    "    pop si" + Environment.NewLine +
                    "    pop bp" + Environment.NewLine +
                    "    pop dx" + Environment.NewLine +
                    "    pop cx" + Environment.NewLine +
                    "    pop bx" + Environment.NewLine +
                    "    pop ax" + Environment.NewLine +
                    "ENDM" + Environment.NewLine;
            this.writer.WriteLine(v);
        }

        public void PrintCallPrintAX()
        {
            this.writer.WriteLine("    CALL print_ax");
        }
    }
}
