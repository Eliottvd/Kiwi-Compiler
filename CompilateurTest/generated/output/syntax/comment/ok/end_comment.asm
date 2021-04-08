data segment
    msg db "My message$"
data ends

code segment
    assume cs:code, ds:data
start:
    mov ah, 4ch
    int 21h
code ends
end start
