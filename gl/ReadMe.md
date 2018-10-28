# Open GL
Wikipedia's take on the description taken from https://en.wikipedia.org/wiki/OpenGL :
*Open Graphics Library (OpenGL)[3][4] is a cross-language, cross-platform application programming interface (API) for rendering 2D and 3D vector graphics.*

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
