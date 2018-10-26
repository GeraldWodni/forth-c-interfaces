\ Minimal GLFW example
\ (c)copyright 2018 by Gerald Wodni <gerald.wodni@gmail.com>

include ../glfw3.fs

variable window

: game ( -- )
    glfwInit 0= abort" glfw Init failed"
    640 480 s" Hello Forth ;)" 0 0 glfwCreateWindow ?dup 0= abort" glfw glfwCreateWindow failed" window !

    window @ glfwMakeContextCurrent

    begin
        window @ glfwWindowShouldClose 0=
    while
        \ main game loop, do GL-Stuff here
        window @ glfwSwapBuffers
        glfwPollEvents
    repeat
    glfwTerminate ;

game
