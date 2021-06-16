using System;
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
        public void PrintBeginData()
        {
            this.writer.WriteLine("data segment");
            this.writer.WriteLine("    msg db \"My message$\"");
        }
        public void PrintBeginCode()
        {
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

        public void PrintStartProc(string name)
        {
            this.writer.WriteLine(name + " PROC");
        }
        public void PrintEndProc(string name)
        {
            this.writer.WriteLine(name + " ENDP");
        }

        public void PrintByteDeclaration(string id)
        {
            this.writer.WriteLine("    " + id + " dw 0");
        }

        public void PrintWordDeclaration(string id)
        {
            this.writer.WriteLine("    " + id + " dw 0");
        }

        public void PrintStringDeclaration(string id)
        {
            this.writer.WriteLine("    " + id + " dw '$'");
        }

        public void PrintMov(AssemblyRegister register, Int16 b)
        {
            this.writer.WriteLine("    MOV " + register + "," + b);
        }

        public void PrintConstDeclarationNbr(string id, Int16 i)
        {
            this.writer.WriteLine("    " + id + " EQU " + i);
        }
        public void PrintConstDeclarationStr(string id, string s)
        {
            this.writer.WriteLine("    " + id + " EQU " + s);
        }
        public void PrintInc(AssemblyRegister register)
        {
            this.writer.WriteLine("    INC " + register);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintDec(AssemblyRegister register)
        {
            this.writer.WriteLine("    DEC " + register);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintAdd(AssemblyRegister register, Int16 i)
        {
            this.writer.WriteLine("    ADD " + register + "," + i);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintAdd(AssemblyRegister register, AssemblyRegister register2)
        {
            this.writer.WriteLine("    ADD " + register + "," + register2);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintSub(AssemblyRegister register, AssemblyRegister register2)
        {
            this.writer.WriteLine("    SUB " + register + "," + register2);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintNot(AssemblyRegister register)
        {
            this.writer.WriteLine("    NOT " + register);
            if (register != AssemblyRegister.AX)
            {
                this.writer.WriteLine("    MOV AX, " + register);
            }
        }

        public void PrintAssignation(string id, AssemblyRegister register)
        {
            this.writer.WriteLine("    MOV [" + id + "], " + register);
        }

        public void PrintId(string id)
        {
            this.writer.WriteLine("    MOV AX, [" + id + "]");
        }

        public void PrintPushRegister(AssemblyRegister register)
        {
            this.writer.WriteLine("    PUSH " + register);
        }
        public void PrintPopRegister(AssemblyRegister register)
        {
            this.writer.WriteLine("    POP " + register);
        }
        public void PrintCallProc(string procName)
        {
            this.writer.WriteLine("    call " + procName);
        }


        #region Print PopA ...

        public void PrintProcPrintAX()
        {
            var v = Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  Affiche la valeur entiere de AX " + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    "PRINT_AX PROC" + Environment.NewLine +
                    "    cmp ax, 0" + Environment.NewLine +
                    "    jne label0" + Environment.NewLine +
                    "    ;print 0 if ax is 0" + Environment.NewLine +
                    "    mov dx, 48" + Environment.NewLine +
                    "    mov ah, 02h" + Environment.NewLine +
                    "    int 21h" + Environment.NewLine +
                    "    jmp exit" + Environment.NewLine +
                    "    " + Environment.NewLine +
                    "    label0:" + Environment.NewLine +
                    ";initilize count" + Environment.NewLine +
                    "mov cx,0" + Environment.NewLine +
                    "mov dx,0" + Environment.NewLine +
                    "label1:" + Environment.NewLine +
                    "    ; if ax is zero" + Environment.NewLine +
                    "    cmp ax,0" + Environment.NewLine +
                    "    je print1	" + Environment.NewLine +
                    "    ;initilize bx to 10" + Environment.NewLine +
                    "    mov bx,10" + Environment.NewLine +
                    "    ; extract the last digit" + Environment.NewLine +
                    "    div bx" + Environment.NewLine +
                    "    ;push it in the stack" + Environment.NewLine +
                    "    push dx" + Environment.NewLine +
                    "    ;increment the count" + Environment.NewLine +
                    "    inc cx" + Environment.NewLine +
                    "    ;set dx to 0" + Environment.NewLine +
                    "    xor dx,dx" + Environment.NewLine +
                    "    jmp label1" + Environment.NewLine +
                    "print1:" + Environment.NewLine +
                    "    ;check if count" + Environment.NewLine +
                    "    ;is greater than zero" + Environment.NewLine +
                    "    cmp cx,0" + Environment.NewLine +
                    "    je exit" + Environment.NewLine +
                    "    ;pop the top of stack" + Environment.NewLine +
                    "    pop dx" + Environment.NewLine +
                    "    ;add 48 so that it" + Environment.NewLine +
                    "    ;represents the ASCII" + Environment.NewLine +
                    "    ;value of digits" + Environment.NewLine +
                    "    add dx,48" + Environment.NewLine +
                    "    ;interuppt to print a" + Environment.NewLine +
                    "    ;character" + Environment.NewLine +
                    "    mov ah,02h" + Environment.NewLine +
                    "    int 21h" + Environment.NewLine +
                    "    ;decrease the count" + Environment.NewLine +
                    "    dec cx" + Environment.NewLine +
                    "    jmp print1" + Environment.NewLine +
                    "exit:" + Environment.NewLine +
                    "    ret" + Environment.NewLine +
                    "PRINT_AX ENDP " + Environment.NewLine;
            this.writer.WriteLine(v);
        }        
        
        public void PrintProcPrintAXOld()
        {
            var v = Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  Affiche la valeur entiere de AX " + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
                    "print_ax PROC" + Environment.NewLine +
                    "CMP AX, 0" + Environment.NewLine +
                    "JNE print_ax_r" + Environment.NewLine +
                    "    PUSH AX" + Environment.NewLine +
                    "    MOV AL, '0'" + Environment.NewLine +
                    "    MOV AH, 0Eh" + Environment.NewLine +
                    "    INT 10h" + Environment.NewLine +
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
                    "    MOV AH, 09h" + Environment.NewLine +
                    "    INT 10h" + Environment.NewLine +
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
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  PUSH tout les registres" + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
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
                    ";------------------------------------------------" + Environment.NewLine +
                    ";  POP tout les registres" + Environment.NewLine +
                    ";------------------------------------------------" + Environment.NewLine +
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

        public void PrintCallPrintEndl()
        {
            this.writer.WriteLine("    CALL print_nl");
        }

        #endregion Print PopA ...
    }
}
