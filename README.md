# Early version of Funnel Scripting Engine

>This manual assumes basic knowledge of Docker. If you are not familiar with Docker, please read the [official documentation](https://www.docker.com/get-started).

## Clone Repository

Clone the scripting engine binary with a sample funnel script:

```
git clone https://github.com/tagion/experiments-funnel.git
cd experiments-funnel
```


## Write Simple Script

There is a sample script `./scripts/test.fs`, it will run by default.

You can change it and use existing code as a reference.

## Execute

Current docker image executes `watch.sh` script, that watches `./scripts/test.fs` for changes and executes on each change.

```
docker-compose up
```

You should see output printed to console like this:

```
funnel_1  | src[]=[":", "test", ".s", "3", "1", "+", ".s", ";", "num", "x", ":", "local_var", ".v", "X", "@", "7", "+", "X", "!", ".v", "X", "@", "4", "*", "X", "!", ".v", ";", ":", "global_var", "num", "local", ".l", "local", "@", "7", "+", "local", "!", ".l", "local", "@", "4", "*", "local", "!", ".l", ";", ":", "loop_example", "num", "count", "do", "count", "@", "1+", "count", "!", "loop", "count", "@", ".l", ";", ":", "if_else_then", "if", "if", "\"ONE-ONE\"", "else", "\"ONE-ZERO\"", "then", "else", "if", "\"ZERO-ONE\"", "else", "\"ZERO-ZERO\"", "then", "then", ".s", ";", ":", "main", "global_var", "local_var", "10", "0", "loop_example", "0", "0", "if_else_then", "0", "1", "if_else_then", "1", "0", "if_else_then", "1", "1", "if_else_then", ";"]
funnel_1  | call main
funnel_1  | call
funnel_1  | .l
funnel_1  | Locals: GLOBAL_VAR
funnel_1  |  001:LOCAL null
funnel_1  | LOCAL @
funnel_1  | 7
funnel_1  | +
funnel_1  | LOCAL !
funnel_1  | .l
funnel_1  | Locals: GLOBAL_VAR
funnel_1  |  001:LOCAL 7
funnel_1  | LOCAL @
funnel_1  | 4
funnel_1  | *
funnel_1  | LOCAL !
funnel_1  | .l
funnel_1  | Locals: GLOBAL_VAR
funnel_1  |  001:LOCAL 28
funnel_1  | call
funnel_1  | .v
funnel_1  | Globals: LOCAL_VAR
funnel_1  |  .000:X null
funnel_1  | X @
funnel_1  | 7
funnel_1  | +
funnel_1  | X !
funnel_1  | .v
funnel_1  | Globals: LOCAL_VAR
funnel_1  |  .000:X 7
funnel_1  | X @
funnel_1  | 4
funnel_1  | *
funnel_1  | X !
funnel_1  | .v
funnel_1  | Globals: LOCAL_VAR
funnel_1  |  .000:X 28
funnel_1  | 10
funnel_1  | 0
funnel_1  | call
funnel_1  | do
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | 1+
funnel_1  | COUNT !
funnel_1  | loop
funnel_1  | COUNT @
funnel_1  | .l
funnel_1  | Locals: LOOP_EXAMPLE
funnel_1  |  002:I1 10
funnel_1  |  001:COUNT 10
funnel_1  |  003:TO1 10
funnel_1  | 0
funnel_1  | 0
funnel_1  | call
funnel_1  | if
funnel_1  | if
funnel_1  | "ZERO-ZERO"
funnel_1  | 0
funnel_1  | 1
funnel_1  | call
funnel_1  | if
funnel_1  | if
funnel_1  | "ONE-ZERO"
funnel_1  | 1
funnel_1  | 0
funnel_1  | call
funnel_1  | if
funnel_1  | if
funnel_1  | "ZERO-ONE"
funnel_1  | 1
funnel_1  | 1
funnel_1  | call
funnel_1  | if
funnel_1  | if
funnel_1  | "ONE-ONE"
funnel_1  | 
funnel_1  | 
funnel_1  | Starting to watch ./scripts/test.fs for changes...
funnel_1  | 
funnel_1  | 
```

Now you can try changing the script. 

Congratulations, you are writing Funnel!