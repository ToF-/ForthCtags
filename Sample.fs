VARIABLE MY-VAR
variable MY-STUFF
4807 CONSTANT FOO
CREATE BAR 4 ALLOT

: MY-DEFINITION 
    PAGE ." Hello world" CR ;

: ANOTHER
    MY-VAR @ MY-STUFF !
    2 2 + . CR ;

: MAIN
    FOO BAR
    MY-DEFINITION ANOTHER 
;

BYE


