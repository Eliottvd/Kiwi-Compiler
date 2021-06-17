del c:\genera~1\output\semantic\function\simple~1.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\function\simple~1.asm,,,,,, > simple~1.log
c:\_Masm\MP\link.exe simple~1.obj,,,,, >> simple~1.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\function\simple~1.exe > c:\genera~1\output\semantic\function\simple~1.txt
exit -1
