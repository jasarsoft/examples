ASSAMBLY=MySharedAssambly.dll

BIN=.\bin
SRC=.
DEST=.\bin

CSC=csc /nologo /debug+ /d:DEBUG /d:TRACE

MODULETARGET=/t:module
LIBTARGET=/t:library
EXETARGET=/t:exe

REFERENCES=System.dll

MODULES=$(DEST)\Fraction.dll $(DEST)\Calc.dll
METADATA=$(SRC)\AssemblyInfo.cs

all: $(DEST)\MySharedAssambly.dll

# Assambly metadata placed in same module as manifest
$(DEST)\$(ASSAMBLY): $(METADATA) $(MODULES) $(DEST) 
	$(CSC) $(LIBTARGET) /addmodule:$(MODULES: =;) /out:$@ %s

# Add Calc.dll module to this depedency list
$(DEST)\Calc.dll: Calc.cs $(DEST) 
	$(CSC) $(MODULETARGET) /r:$(REFERENCES: =;) /out:$@ %s

# add Fraction
$(DEST)\Fraction.dll: Fraction.cs $(DEST) $(CSC) $(MODULETARGET) 
	/r:$(REFERENCES: =;) /out:$@ %s

$(DEST)::
!if !EXIST($(DEST))
	mkdir $(DEST)::
!endif