grammar DEMO;

import DEMOWords;

// Program

demo: BEGIN
         instruction*
      END 
      ;

instruction: expr                             #InstExpr
             | PRINT LPAR expr RPAR           #InstPrint
             | NOP                            #InstNOP
             ;

expr: exprent op=(PLUS|MINUS) exprent         #RightExprPlusMinus
      | exprent                               #RightExprEnt
      | NOT exprent                           #RightExpNot
      ;

exprent: NUMBER                               #RightExprNumber
         ;