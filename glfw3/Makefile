PROJECT    = glfw3
SWIG       = swig
BUILD      = build
OUTPUT     = $(BUILD)/$(PROJECT)
INCLUDE    = $(BUILD)/$(PROJECT).h
INTERFACE  = $(PROJECT).i
OPTIONS		= -forth -no-sectioncomments -stackcomments -use-structs

all: $(OUTPUT).fs $(OUTPUT).f $(OUTPUT).fth
	@ echo "All created"
	cp $(OUTPUT).fs  $(PROJECT).fs
	cp $(OUTPUT).f   $(PROJECT).f
	cp $(OUTPUT).fth $(PROJECT).fth

$(OUTPUT).fs: $(OUTPUT).fsx
	./$(OUTPUT).fsx -gforth > $(OUTPUT).fs

$(OUTPUT).f: $(OUTPUT).fsx
	./$(OUTPUT).fsx -swiftforth > $(OUTPUT).f

$(OUTPUT).fth: $(OUTPUT).fsx
	./$(OUTPUT).fsx -vfx > $(OUTPUT).fth

$(OUTPUT).fsx: $(OUTPUT)-fsi.c
	$(CC) -o $(OUTPUT).fsx $(OUTPUT)-fsi.c

$(OUTPUT)-fsi.c: $(INCLUDE)
	$(SWIG) $(OPTIONS) -o $(OUTPUT)-fsi.c $(INTERFACE)

# obtain most recent glfw.h from github
$(INCLUDE):
	mkdir $(BUILD)
	wget -O $(INCLUDE) https://github.com/glfw/glfw/raw/master/include/GLFW/glfw3.h

.PHONY: clean

clean:
	rm -Rf $(BUILD)
