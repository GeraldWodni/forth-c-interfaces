PROJECT    = glfw3
SWIG       = swig
BUILD      = build
OUTPUT     = $(BUILD)/$(PROJECT)
INTERFACE  = $(PROJECT).i
INCLUDES   = -I/usr/include
OPTIONS	   = -forth -no-sectioncomments -stackcomments -use-structs $(INCLUDES)

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

$(OUTPUT)-fsi.c: $(INTERFACE)
	mkdir $(BUILD)
	$(SWIG) $(OPTIONS) -o $(OUTPUT)-fsi.c $(INTERFACE)

.PHONY: clean

clean:
	rm -Rf $(BUILD)
