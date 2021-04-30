.MODEL SMALL
.STACK 100H
.DATA

    b DW 0
    b2 DW 10

.CODE
MAIN PROC FAR
    MOV AX,@DATA
    MOV DS,AX
    ; initialise var
    MOV [b],0
    MOV [b2],10

    ; print(b+0)
    ; b+0
    push [b]
    ; 0
    MOV AX,0
    push AX
    pop BX
    pop AX
    ADD AX, BX
    push AX
    CALL print_ax
    ; print(100+b)
    ; 100+b
    ; 100
    MOV AX,100
    push AX
    push [b]
    pop BX
    pop AX
    ADD AX, BX
    push AX
    CALL print_ax
    ; print(5+b)
    ; 5+b
    ; 5
    MOV AX,5
    push AX
    push [b]
    pop BX
    pop AX
    ADD AX, BX
    push AX
    CALL print_ax
    ; print(b2+10)
    ; b2+10
    push [b2]
    ; 10
    MOV AX,10
    push AX
    pop BX
    pop AX
    ADD AX, BX
    push AX
    CALL print_ax
    ; print(5+5)
    ; 5+5
    ; 5
    MOV AX,5
    push AX
    ; 5
    MOV AX,5
    push AX
    pop BX
    pop AX
    ADD AX, BX
    push AX
    CALL print_ax
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
