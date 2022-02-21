# Streams and File System

Create a console application.
Implement reading from files with extensions:
- .txt;
- .csv;
Add an option to select input file extension from the Console.
Reading from file should be implemented using System.IO.
File should contain ONLY integers. As input values you have 2 numbers separated by space (' ') for .txt and by comma (',') for .csv formats.
Input file can have 1 or several lines with data.

Your code should get input data from file and do next operations:
- calculate the sum of numbers (x+y);
- multiply (x*y);
- divide the first number in line by the second one (x/y).

Note: dividing by 0 can be handled with simple verification if second number is not 0 (if y != 0)
Optional task: dividing by 0 can be handled by try/catch construction.
Results of calculation should be saved in a NEW file.
Writing to the file should be implemented using FileStream class

Example of output:  
x, y, x+y, x*y, x/y
output result should be the same for both file types - .txt and .csv
in case if y=0, log an error into the file
extension of output file should be an opposite from the input, like, if you read from .txt file, the result should be saved into .csv and vice versa.
File naming should be like this: 
- output_DateTime.Now().(.txt/.csv);

.csv input file example:
2, 13  
23, 6  
16, 41  

.txt input file example:
2 13  
23 6  
16 41  
