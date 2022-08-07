# Recruitment task for Junior .NET Developer position

## Description

The task is about making an ASP.NET MVC webpage that displays a text field, a button and a label.
In the text field you should be able to enter an integer array in the format "[x,y,z]".

After pressing the button process input in the back-end and then label should display:
 1. If input format is incorrect => an error message
 2. If input format is correct => <br>
     a) numbers repeated at least 3 times in the input array in format "[x,y]".
        Those numbers should have descending order. <br>
     b) "[]" if none is repeated.

Example i/o:
1. input: [1,2,3,4,5,1,1] output: [1]
2. input: [9,3,3,2,1,1,1,2,9,9,9] output: [9,1]
3. input: [1,1,1,1,3,3,3,3,2,1,2,9,9,9] output: [9,3,1]
4. input: [1,2,3,2,1,9,9,8] output: []
5. input: [112, he3,2,1,9,9,8] output: Error

## Launch

To launch the project you should open the MyProject.sln file using Visual Studio. Then click the IIS Express button to start the localhost server. Once started, the home page should appear.
