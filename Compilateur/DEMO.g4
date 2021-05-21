grammar DEMO;

import DEMOWords;

// Program

demo: BEGIN
         (declarationFunction|declaration|instruction)*
      END 
      ;

declarationFunction: type=(BYTE|WORD) ID LPAR (parameterDeclaration*)? RPAR LBRACKET 
                    (instruction)* 
                RBRACKET #DeclFunction
             ;

parameterDeclaration : typeVar=(BYTE|WORD) ID COMMA
             ;

declaration: type=(BYTE|WORD|STRING) ID       #DeclVar
             | CONST ID EQUAL type=(NUMBER|STRING_LITERAL) #DeclConst
             ;

instruction: expr                             #InstExpr
             | PRINT LPAR expr RPAR           #InstPrint
             | NOP                            #InstNOP
             | ID EQUAL expr                  #InstAssignation
             ;

expr: expr op=(PLUS|MINUS) expr               #RightExprPlusMinus
      | exprent                               #RightExprEnt
      | NOT expr                              #RightExpNot
      | expr INC                              #RightExpIncrement
      | expr DEC                              #RightExpDecrement
      | ID                                    #RightExpID
      | LPAR expr RPAR                        #RightExpPar
      ;

exprent: NUMBER                               #RightExprNumber
         | HEXA8                              #RightExprHexa8
         | HEXA16                             #RightExprHexa16
         | BINARY8                            #RightExprBinary8
         | BINARY16                           #RightExprBinary16
         ;