# **Exercises: Arrays**

## 01. Largest Common End

### Read two arrays of words and find the length of the largest common end (left or right).

#### Examples

Input |	Output |	Comments
:---  | :---  | :---
**hi php java** csharp sql html css js|
**hi php java** js softuni nakov java learn|	3	|The largest common end is at the left: **hi php java**
hi php java xml csharp **sql html css js** |
nakov java **sql html css js** |	4	|The largest common end is at the right: **sql html css js**
I love programming |
Learn Java or C#	| 0	| No common words at the left and right

### Hints

     • Scan the arrays from left to right until the end of the shorter is reached and count the equal elements.
     • Scan the arrays form right to left until the start of the shorter is reached.
     • Keep the start position and the length of the longest equal start / end.

## 02. Rotate and Sum

### To “rotate an array on the right” means to move its last element first: {1, 2, 3} **->** {3, 1, 2}.
### Write a program to read an array of n integers (space separated on a single line) and an integer k, rotate the array right k times and sum the obtained arrays after each rotation as shown below.

#### Examples

Input	   |Output	|Comments
:---     |:---    |:---
3 2 4 -1 | 3 2 5 6|rotated1[] = -1  3  2  4
2	       |        |rotated2[] =  4 -1  3  2
	       |        |sum[] =  3  2  5  6
1 2 3    | 3 1 2  |rotated1[] = 3 1 2
1	       |        |sum[] = 3 1 2
1 2 3 4 5|12 10 8 6 9|rotated1[] =  5  1  2  3  4
3	       |        |rotated2[] =  4  5  1  2  3
         |        |rotated3[] =  3  4  5  1  2
         |        |sum[] = 12 10  8  6  9




