lexer grammar DEMO;

// Words
PRINT: 'print';
LPAR: '(';
RPAR: ')';
COMMA: ',';
PLUS: '+';
MINUS: '-';
BEGIN: 'Begin';
END: 'End';
TRUE: 'TRUE';
FALSE: 'FALSE';

NUMBER: (DIGIT)+;

fragment DIGIT: [0-9] ;

// Comments -> ignored
COMMENT: '/*' .*? '*/' -> skip;

// Whitespaces -> ignored
NEWLINE: '\r'? '\n'  -> skip ;
WS: [ \t]+ -> skip ;
