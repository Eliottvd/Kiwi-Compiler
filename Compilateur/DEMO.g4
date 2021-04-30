grammar DEMO;

import DEMOWords;

// Program

demo: BEGIN
         (declaration|instruction)*
      END 
      ;

declaration: type=(BYTE|WORD|STRING) ID       #Decl
             ;

instruction: expr                             #InstExpr
             | PRINT LPAR expr RPAR           #InstPrint
             | NOP                            #InstNOP
             | ID EQUAL expr                  #InstAssignation
             ;

expr: exprent op=(PLUS|MINUS) exprent         #RightExprPlusMinus
      | exprent                               #RightExprEnt
      | NOT exprent                           #RightExpNot
      | exprent INC                           #RightExpIncrement
      | exprent DEC                           #RightExpDecrement
      ;

exprent: NUMBER                               #RightExprNumber
         ;

