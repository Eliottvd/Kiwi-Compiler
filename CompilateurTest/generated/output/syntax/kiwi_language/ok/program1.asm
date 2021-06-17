.MODEL SMALL
.STACK 100H
.DATA
    LF EQU 13
    MIL EQU 003E8h

    b DW 069h
    w DW 012FFh
    hello EQU " Hello World ! $"
    s DB " message $"

.CODE
MAIN PROC FAR
    MOV AX,@DATA
    MOV DS,AX
    ; initialise var
    MOV [b],069h
    MOV [w],012FFh

    ; w=b*b
    ; b*b
    push [b]
    push [b]
    pop BX
    pop AX
    MUL BX
    push AX
    pop AX
    MOV [w],AX
    ; b=5
    ; 5
    MOV AX,5
    push AX
    pop AX
    MOV [b],AX
    ; w++
    INC [w]
    push [w]
    ; b=b>>4
    ; b>>4
    push [b]
    ; 4
    MOV AX,4
    push AX
    pop BX
    pop AX
    SHR AX, BX
    push AX
    pop AX
    MOV [b],AX
    ; w=Sum(b,5)
    ; Sum(b,5)
    push CX
    push [b]
    ; 5
    MOV AX,5
    push AX
    call Sum
    pop AX
    push AX
    pop AX
    MOV [w],AX
    ; print(w)
    push [w]
    CALL print_ax
    ; print(s)
    push [s]
    CALL print_ax
    ; print(Sum(w,b))
    ; Sum(w,b)
    push CX
    push [w]
    push [b]
    call Sum
    pop AX
    push AX
    CALL print_ax
    ; b=b&0b11110000
    ; b&0b11110000
    push [b]
    ; 0b11110000
    MOV AX,11110000b
    push AX
    pop BX
    pop AX
    AND AX, BX
    push AX
    pop AX
    MOV [b],AX
    ;interrupt to exit
    mov ah, 4ch
    int 21h
MAIN ENDP

;------------------------------------------------
;  PUSH tout les registres
;------------------------------------------------
PUSHA    MACRO
    push ax
    push bx
    push cx
    push dx
    push bp
    push si
    push di
ENDM


;------------------------------------------------
;  POP tout les registres
;------------------------------------------------
POPA MACRO
    pop di
    pop si
    pop bp
    pop dx
    pop cx
    pop bx
    pop ax
ENDM

    ; wordSum(bytea,bytec){returna+c}

;------------------------------------------------
;PROCEDURE : Sum
;------------------------------------------------
Sum PROC
    PUSHA
    MOV BP,SP

    ; returna+c
    ; a+c
    MOV AX,[bp+18]
    push AX
    MOV AX,[bp+16]
    push AX
    pop BX
    pop AX
    ADD AX, BX
    push AX
    pop AX
    MOV [BP+20], AX

    POPA
    RET 4
Sum ENDP


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
