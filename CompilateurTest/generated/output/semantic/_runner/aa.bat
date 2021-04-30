del c:\genera~1\output\semantic\_runner\aa.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\_runner\aa.asm,,,,,, > aa.log
c:\_Masm\MP\link.exe aa.obj,,,,, >> aa.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\_runner\aa.exe > c:\genera~1\output\semantic\_runner\aa.txt
exit -1
