del c:\genera~1\output\semantic\function\param5~1.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\function\param5~1.asm,,,,,, > param5~1.log
c:\_Masm\MP\link.exe param5~1.obj,,,,, >> param5~1.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\function\param5~1.exe > c:\genera~1\output\semantic\function\param5~1.txt
exit -1
