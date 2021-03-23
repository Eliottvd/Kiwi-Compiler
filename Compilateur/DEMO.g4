grammar DEMO;

import DEMOWords;

// Program

demo: BEGIN 
         instruction?
      END 
      ;

instruction: expr                             #InstExpr
             | PRINT LPAR expr RPAR           #InstPrint
             ;

expr: exprent op=(PLUS|MINUS) exprent         #RightExprPlusMinus
      | exprent                               #RightExprEnt
      ;

exprent: NUMBER                               #RightExprNumber
         ;