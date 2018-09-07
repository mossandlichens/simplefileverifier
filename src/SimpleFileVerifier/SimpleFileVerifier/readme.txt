Simple File Verifier helps to create the CRC32 hash for a file or files satisfying a pattern in a directory. It also creates a SFV file with files and hashes.

Simple File Verifier by Moss and Lichens (Ranjith Venkatesh)

Usage:
Simple File Verifier 1.1.0.0
Copyright © 2018

  -o, --output       Path to SFV File

  -d, --directory    Path to Directory

  -f, --file         Path to File

  -p, --pattern      Search pattern

  -c, --check        Check SFV File

  -r, --recursive    Look at subdirectories. Default: false. Options:
                     true/false

  -l, --log          Log file generated during check

  -v, --verbose      (Default: True) Prints all messages to standard output.

  --help             Display this help screen.


Examples:

1. Display CRC32 Hash for file

SimpleFileVerifier -f "<<path>>\file.ext"

2. Create SFV file for files in directory satisfying pattern

SimpleFileVerifier -d "<<path>>" -p "*.ext" -o "<<path>>\output.sfv"

3. Create SFV file for files in directory with recursive check
SimpleFileVerifier -d "<<path>>" -r true -o "<<path>>\output.sfv"

4. Check SFV file and log it with OK, NOT OK and FILE NOT FOUND
SimpleFileVerifier -c "<<path>>\input.sfv" -l "<<path>>\sfv.log"