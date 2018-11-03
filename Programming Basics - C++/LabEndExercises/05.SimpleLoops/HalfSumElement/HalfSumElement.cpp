// HalfSumElement.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <climits>
using namespace std;

int main()
{
	int input_number;
	cin >> input_number;
	int sum = 0;
	int max_number = INT_MIN;

	for (int i = 1; i <= input_number; i++)
	{
		int current_number;
		cin >> current_number;
		sum += current_number;

		if (current_number > max_number)
		{
			max_number = current_number;
		}
	}
	if (sum - max_number == max_number)
	{ 
		cout << "Yes" << endl;
		cout << "Sum = " << sum - max_number << endl;
	}
	else
	{
		cout << "No" << endl;
		cout << "Diff = " << abs(max_number - (sum - max_number)) << endl;
	}

	return 0;
}
