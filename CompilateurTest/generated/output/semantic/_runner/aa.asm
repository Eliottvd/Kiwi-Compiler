data segment
	msg db "My message$"
data ends

code segment
	assume cs:code, ds:data
start:
	mov ax, data
	mov ds, ax
	mov dx, offset msg
	mov ah, 09h
	int 21h
		

	mov ah, 4ch
	int 21h

code ends



;------------------------------------------------
;  Affiche la valeur entiere de AX 
;------------------------------------------------
print_ax PROC
CMP AX, 0
JNE print_ax_r
    PUSH AX
    MOV AL, '0'
    MOV AH, 0eh
    INT 10h
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
    MOV AH, 0eh
    INT 10h
    JMP pn_done
pn_done:
    POPA
    RET
ENDP


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
ENDP



end start