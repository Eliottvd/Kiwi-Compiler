data segment
    msg db "My message$"
data ends

code segment
    assume cs:code, ds:data
start:
    MOV AX,5
    ADD AX,5
    mov ah, 4ch
    int 21h
code ends
end start
