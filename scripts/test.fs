: test
    .s
    3 1 +
    .s
;
num x
: local_var
    .v
    X @  7 + X !
    .v
    X @ 4 * X !
    .v
;

: global_var
    num local
    .l
    local @  7 + local !
    .l
    local @ 4 * local !
    .l
;
: loop_example
    num count
    do
        count @ 1+ count !
    loop
    count @
    .l
;
: if_else_then
    if
        if
            "ONE-ONE"
        else
            "ONE-ZERO"
        then
    else
        if
            "ZERO-ONE"
        else
            "ZERO-ZERO"
        then
    then
    .s
;
: main
    global_var
    local_var
    10 0 loop_example
    0 0 if_else_then
    0 1 if_else_then
    1 0 if_else_then
    1 1 if_else_then
;