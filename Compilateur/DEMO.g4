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
             | ID EQUAL expr                  #InstAssignation
             | NOP                            #InstNOP
             ;

expr: LPAR expr RPAR                                #RightExpPar
      | expr op=(MUL|DIV|MOD) expr                  #RightExpMulDivMod
      | expr op=(PLUS|MINUS) expr                   #RightExprPlusMinus
      | expr INC                                    #RightExpIncrement
      | expr DEC                                    #RightExpDecrement
      | expr op=(AND|OR) expr                       #RightExprAndOr
      | expr op=(LSHIFT|RSHIFT) exprent             #RightExprShift
      | exprent                                     #RightExprEnt
      | ID                                          #RightExpID
      | NOT expr                                    #RightExpNot
      | ID LPAR (parameterDeclaration*)? RPAR       #RightExprFctCall
      ;

exprent: NUMBER                               #RightExprNumber
         | HEXA8                              #RightExprHexa8
         | HEXA16                             #RightExprHexa16
         | BINARY8                            #RightExprBinary8
         | BINARY16                           #RightExprBinary16
         ;
