del c:\genera~1\output\semantic\instru~1\add_in~1.exe
c:\_Masm\MP\masm.exe c:\genera~1\output\semantic\instru~1\add_in~1.asm,,,,,, > add_in~1.log
c:\_Masm\MP\link.exe add_in~1.obj,,,,, >> add_in~1.log
del *.crf
del *.lst
del *.obj
del *.map
c:\genera~1\output\semantic\instru~1\add_in~1.exe > c:\genera~1\output\semantic\instru~1\add_in~1.txt
exit -1
