# 					**Lab: Arrays**

## 01.Day of Week

###### Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.

### Examples

| Input	| Output       |
| :---  | :---         |
| 1	| Monday       |
| 2	| Tuesday      |
| 7	| Sunday       |
| 0	| Invalid Day! |

### Hints

      • Use an array of strings holding the day names: {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}.

      • Print the element at index (day-1) when it is in the range [1…7] or “Invalid Day!” otherwise.

## 02.Reverse an Array of Integers

###### Write a program to read an array of integers, reverse it and print its elements. The input consists of a number n (the number of elements) + n integers, each as a separate line. Print the output on a single line (space separated).

### Examples

| Input	| Output      |
| :---  | :---        |
| **3** |             |
| 10    |             |
| 20    | 30 20 10    |        
| 30    |             |
| ----- | ----------- |
| **4** |             |
| -1    |             |
| 20    | 5 99 20 -1  |         
| 99    |             |
| 5     |             |

### Hints

      • First, read the number n.

      • Allocate an array of n integers.

      • Read the integers in a for-loop.

      • Instead of reversing the array, you can just pass through the elements from the last (n-1) to the first (0) with a reverse for-loop.

## 03.Last K Numbers Sums Sequence

###### Enter two integers n and k. Generate and print the following sequence of n elements:
          • The first element is: 1
          • All other elements = sum of the previous k elements (if less than k are available, sum all of them)
          • Example: n = 9, k = 5 ? 120 = 4 + 8 + 16 + 31 + 61

### Examples

| :---  | :---   |
| Input	| Output |
| 6     |
| 3	| 1 1 2 4 7 13            |

| 8     |
| 2	| 1 1 2 3 5 8 13 21       |

| 9     |
| 5	| 1 1 2 4 8 16 31 61 120  |


### Hints

      • Use an array of integers to hold the sequence.

      • Initially seq[0] = 1

      • Use two nested loops:

            o Loop through all elements i = 1 … n 

            o Sum the elements i-k … i-1: seq[i] = sum(seq[i-k … i-1])

## 04.Triple Sum
