# Lab: Arrays

## 1.Day of Week

###### Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.

 Examples

| Input	| Output       |
| :---  | :---         |
| 1	| Monday       |
| 2	| Tuesday      |
| 7	| Sunday       |
| 0	| Invalid Day! |

Hints
•	Use an array of strings holding the day names: {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}.
•	Print the element at index (day-1) when it is in the range [1…7] or “Invalid Day!” otherwise.

## 2.Reverse an Array of Integers

###### Write a program to read an array of integers, reverse it and print its elements. The input consists of a number n (the number of elements) + n integers, each as a separate line. Print the output on a single line (space separated).

### Examples

| Input	| Output      |
| :---  | :---        |
| 3     |             |
| 10    |             |
| 20    |             |
| 30    | 30 20 10    |
| 4     |             |
| -1    |             |
| 20    |             |
| 99    |             |
| 5     | 5 99 20 -1  |


Hints
•	First, read the number n.
•	Allocate an array of n integers.
•	Read the integers in a for-loop.
•	Instead of reversing the array, you can just pass through the elements from the last (n-1) to the first (0) with a reverse for-loop.

