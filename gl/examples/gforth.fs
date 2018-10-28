\ Minimal GLFW example
\ (c)copyright 2018 by Gerald Wodni <gerald.wodni@gmail.com>

include ../gl.fs
include ../../glfw3/glfw3.fs

variable window

: game ( -- )
    glfwInit 0= abort" glfw Init failed"
    640 480 s" Hello Forth ;)" 0 0 glfwCreateWindow ?dup 0= abort" glfw glfwCreateWindow failed" window !

    window @ glfwMakeContextCurrent

    begin
        window @ glfwWindowShouldClose 0=
    while
        \ Just clear with green to show that the OpenGL Context is up and running
        0.e0 5.e-1 0.e0 0.e0 glClearColor
        GL_COLOR_BUFFER_BIT glClear

        window @ glfwSwapBuffers
        glfwPollEvents
    repeat
    glfwTerminate ;

game
