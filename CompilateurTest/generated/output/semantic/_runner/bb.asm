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
	
	add 5

	mov ah, 4ch
	int 21h

code ends
end start