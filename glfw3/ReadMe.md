# GLFW3
Official description taken from https://www.glfw.org/index.html :
*GLFW is an Open Source, multi-platform library for OpenGL, OpenGL ES and Vulkan development on the desktop. It provides a simple API for creating windows, contexts and surfaces, receiving input and events.*

## Forth interface
This directory contains the interface files for the above library.
They are created by the [Forth Extension](https://github.com/GeraldWodni/swig) for [SWIG](http://swig.org/).

Each major system has its own file (contact me if you want to sponsor a common interface):

| Extension | System                                               |
| --------- | ---------------------------------------------------- |
| `.fs`     | (Gforth)[https://gforth.org/]                        |
| `.f`      | (Swift Forth)[https://www.forth.com/swiftforth/]     |
| `.fth`    | (VFX)[https://www.mpeforth.com/software/pc-systems/] |

Just include the above file and hack away ;)
