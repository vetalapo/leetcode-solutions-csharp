#!/bin/bash

# [-B] disables creation of bytecode
# [-m] runs module [unittest]
# [discover] searches test folder in [-s]
# [-v] shows result verbose, aka more details like what tests are running
python -B -m unittest discover -s src/tests -v
