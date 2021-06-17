del c:\genera~1\output\semantic\assign~1\equati~1.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\assign~1\equati~1.asm,,,,,, > equati~1.log
c:\_Masm\MP\link.exe equati~1.obj,,,,, >> equati~1.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\assign~1\equati~1.exe > c:\genera~1\output\semantic\assign~1\equati~1.txt
exit -1
