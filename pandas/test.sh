#!/bin/bash

python -m unittest discover -s src/tests -v

find . -name __pycache__ -type d -exec rm -r {} +

