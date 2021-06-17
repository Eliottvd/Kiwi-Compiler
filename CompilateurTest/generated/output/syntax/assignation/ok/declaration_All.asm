.MODEL SMALL
.STACK 100H
.DATA
    LF EQU 13
    MIL EQU 003E8h

    b1 DW 00001111b
    b2 DW 0000111100001111b
    d1 DW 10
    d2 DW 512
    h1 DW 0FAh
    h2 DW 0FC10h
    hello EQU " Hello World ! $"
    s1 DB "Hello$"
    s2 DB "World$"

.CODE
MAIN PROC FAR
    MOV AX,@DATA
    MOV DS,AX
    ; initialise var
    MOV [b1],00001111b
    MOV [b2],0000111100001111b
    MOV [d1],10
    MOV [d2],512
    MOV [h1],0FAh
    MOV [h2],0FC10h

    NOP 
    ;interrupt to exit
    mov ah, 4ch
    int 21h
MAIN ENDP

PUSHA    MACRO
    push ax
    push bx
    push cx
    push dx
    push bp
    push si
    push di
ENDM


POPA MACRO
    pop di
    pop si
    pop bp
    pop dx
    pop cx
    pop bx
    pop ax
ENDM


;------------------------------------------------
;  Affiche la valeur entiere de AX 
;------------------------------------------------
PRINT_AX PROC
    cmp ax, 0
    jne label0
    ;print 0 if ax is 0
    mov dx, 48
    mov ah, 02h
    int 21h
    jmp exit
    
    label0:
;initilize count
mov cx,0
mov dx,0
label1:
    ; if ax is zero
    cmp ax,0
    je print1	
    ;initilize bx to 10
    mov bx,10
    ; extract the last digit
    div bx
    ;push it in the stack
    push dx
    ;increment the count
    inc cx
    ;set dx to 0
    xor dx,dx
    jmp label1
print1:
    ;check if count
    ;is greater than zero
    cmp cx,0
    je exit
    ;pop the top of stack
    pop dx
    ;add 48 so that it
    ;represents the ASCII
    ;value of digits
    add dx,48
    ;interuppt to print a
    ;character
    mov ah,02h
    int 21h
    ;decrease the count
    dec cx
    jmp print1
exit:
    ret
PRINT_AX ENDP 


;------------------------------------------------
;  Affiche une nouvelle ligne
;------------------------------------------------
print_nl PROC 
    PUSH AX  
    PUSH DX 
    MOV AH, 2
    MOV DL, 0Dh
    INT 21h
    MOV DL, 0Ah
    INT 21h
    POP DX 
    POP AX
    RET
print_nl ENDP

END MAIN
