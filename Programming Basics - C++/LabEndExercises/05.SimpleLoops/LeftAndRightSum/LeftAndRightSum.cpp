// LeftAndRightSum.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number_of_input;
	cin >> number_of_input;
	int left_sum = 0;
	int right_sum = 0;

	for (int i = 0; i < number_of_input; i++)
	{
		int current_number;
		cin >> current_number;
		left_sum += current_number;
	}
	for (int i = 0; i < number_of_input; i++)
	{
		int current_number;
		cin >> current_number;
		right_sum += current_number;
	}
	if (left_sum == right_sum)
	{
		cout << "Yes, sum = " << left_sum << endl;
	}
	else
	{
		int diff = abs(left_sum - right_sum);
		cout << "No, diff = " << diff << endl;
	}

    return 0;
}

