data segment
    b DW 0
    b2 DW 10
    msg db "My message$"
data ends

code segment
    assume cs:code, ds:data
start:
; initialise var
    MOV [b],0
    MOV [b2],10

    MOV AX,0
    ADD AX,[b]
    CALL print_ax
    MOV AX,5
    ADD AX,[b]
    CALL print_ax
    MOV AX,[b2]
    ADD AX,10
    CALL print_ax
    MOV AX,5
    ADD AX,5
    CALL print_ax
    mov ah, 4ch
    int 21h

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
print_ax PROC
CMP AX, 0
JNE print_ax_r
    PUSH AX
    MOV DL, '0'
    MOV AH, 02h
    INT 21h
    POP AX
    RET 
print_ax_r:
    PUSHA
    MOV DX, 0
    CMP AX, 0
    JE pn_done
    MOV BX, 10
    DIV BX
    CALL print_ax_r
    MOV AX, DX
    ADD AL, 30h
    MOV DL, AL
    MOV AH, 02h
    INT 21h
    JMP pn_done
pn_done:
    POPA
    RET
print_ax ENDP


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

code ends
end start
