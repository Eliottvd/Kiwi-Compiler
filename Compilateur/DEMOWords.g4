lexer grammar DEMO;

// Words
PRINT: 'print';
LPAR: '(';
RPAR: ')';
LBRACKET: '{';
RBRACKET: '}';
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
STRING_LITERAL : '"' (.)*? '"';
CONST: 'const';

NUMBER: (DIGIT)+;
ID: (LETTER)(LETTER|DIGIT)*;
HEXA8 : ([0])('x')(HEXA)(HEXA);
HEXA16 : ([0])('x')(HEXA)(HEXA)(HEXA)(HEXA);
BINARY8 : ([0])('b')(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT); 
BINARY16 : ([0])('b')(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT)(BIT);

fragment LETTER: [a-z]|[A-Z];
fragment DIGIT: [0-9];
fragment BIT: [0-1];
fragment HEXA : [0-9]|[a-f]|[A-F];


// Comments -> ignored
COMMENT: '#'~('\r'|'\n')* -> skip;

// Whitespaces -> ignored
NEWLINE: '\r'? '\n'  -> skip ;
WS: [ \t]+ -> skip ;
