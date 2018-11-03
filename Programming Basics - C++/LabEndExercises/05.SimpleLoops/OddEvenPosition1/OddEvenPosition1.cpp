// OddEvenPosition1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <climits>
using namespace std;

int main()
{
	double number;
	cin >> number;

	double even_sum = 0;
	double odd_sum = 0;
	double even_min = INT_MAX;
	double odd_min = INT_MAX;
	double even_max = INT_MIN;
	double odd_max = INT_MIN;

	for (int i = 1; i <= number; i++)
	{
		double current_number;
		cin >> current_number;

		if (i % 2 == 0)
		{
			if (current_number > even_max)
			{
				even_max = current_number;
			}
			if (current_number < even_min)
			{
				even_min = current_number;
			}
			even_sum += current_number;
		}
		else
		{
			if (current_number > odd_max)
			{
				odd_max = current_number;
			}
			if (current_number < odd_min)
			{
				odd_min = current_number;
			}
			odd_sum += current_number;
		}
	}
	cout << "OddSum=" << odd_sum << "," << endl;
	if (odd_min == INT_MAX)
	{
		cout << "OddMin=No" << "," << endl;
	}
	else
	{
		cout << "OddMin=" << odd_min << "," << endl;
	}
	if (odd_max == INT_MIN)
	{
		cout << "OddMax=No" << "," << endl;
	}
	else
	{
		cout << "OddMax=" << odd_max << "," << endl;
	}
	cout << "EvenSum=" << even_sum << "," << endl;
	if (even_min == INT_MAX)
	{
		cout << "EvenMin=No" << "," << endl;
	}
	else
	{
		cout << "EvenMin=" << even_min << "," << endl;
	}
	if (even_max == INT_MIN)
	{
		cout << "EvenMax=No" << endl;
	}
	else
	{
		cout << "EvenMax=" << even_max << endl;
	}

    return 0;
}

