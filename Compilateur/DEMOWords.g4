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
NOP: 'NOP';
NOT: '!';
INC: '++';
DEC: '--';
EQUAL: '=';
BYTE: 'byte';
WORD: 'word';
STRING: 'string';

 

NUMBER: (DIGIT)+;
ID: (LETTER)(LETTER|DIGIT)*;

fragment LETTER: [a-z]|[A-Z];
fragment DIGIT: [0-9];
fragment BIT: [0-1];


// Comments -> ignored
COMMENT: '#'~('\r'|'\n')* -> skip;

// Whitespaces -> ignored
NEWLINE: '\r'? '\n'  -> skip ;
WS: [ \t]+ -> skip ;
