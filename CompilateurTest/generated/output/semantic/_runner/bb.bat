del c:\genera~1\output\semantic\_runner\bb.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\_runner\bb.asm,,,,,, > bb.log
c:\_Masm\MP\link.exe bb.obj,,,,, >> bb.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\_runner\bb.exe > c:\genera~1\output\semantic\_runner\bb.txt
exit -1
