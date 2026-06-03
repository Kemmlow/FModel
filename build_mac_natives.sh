#!/bin/bash
mkdir -p CUE4Parse/CUE4Parse-Natives/build
cd CUE4Parse/CUE4Parse-Natives/build
cmake .. -DCMAKE_OSX_ARCHITECTURES="x86_64"
make
