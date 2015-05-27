SuperSecretary
Version 2.0
http://www.codecalculated.com

CONTENTS
--------

1. Description
2. Usage

1. Description
--------------
SuperSecretary is an application for sorting files into folders according to file properties or attributes.  It is provided as a console application to be run from the command line or used as an automated task.  More information can be found at http://www.codecalculated.com.

2. Usage
--------
SuperSecretary can be automated from the command line using the SuperSecretary.Console.exe application.

Usage: SuperSecretary.Console source destination [OPTIONS]
Sorts the files in the source directory to the destination according to the options.
    Options:
        -p, --properties names              A comma-separated list of properties to sort on.  See below for more.
        -r, --recurse                       Recurse to all subdirectories.
        -m, --move                          Move files to destination.  Omitting this option copies the files.
        -e, --extensions file-exts          A comma-separated list of file extensions to sort.  (ex. .jpg,.gif,.png)
        -u, --unsorted folder               The folder to sort to when an attribute value is not found.
        -d, --date format                   A .NET date format string for generating folder names from date attributes.
        -l, --log path                      Log the results to a file at the specified path.
        -h, --help                          Show the help message.

The following property values are built in to the application:
    * Camera Maker
    * Camera Model
    * Date Created
    * Date Modified
    * Date Taken
    * File Extension
    * Album
    * Artist
    * Genre

Any handler plugins will need to be referenced by the name specified.

NOTE: Property names that contain a space will need to be contained within quotation marks.