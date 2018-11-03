// OddEvenPosition.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number_of_inputs;
	int even_sum = 0;
	int odd_sum = 0;
	cin >> number_of_inputs;

	for (int i = 0; i < number_of_inputs; i++)
	{
		int current_number;
		cin >> current_number;
		if (i % 2 == 0)
		{
			even_sum += current_number;
		}
		else
		{
			odd_sum += current_number;
		}
	}
	if (even_sum == odd_sum)
	{
		cout << "Yes" << endl;
		cout << "Sum = " << even_sum << endl;
	}
	else
	{
		cout << "No" << endl;
		cout << "Diff = " << abs(even_sum - odd_sum) << endl;
	}
    return 0;
}

