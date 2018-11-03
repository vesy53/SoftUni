// MinNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <climits>
using namespace std;

int main()
{
	int number_of_input;
	cin >> number_of_input;
	int min_number = INT_MAX;

	for (int i = 0; i < number_of_input; i++)
	{
		int current_number;
		cin >> current_number;
		if (current_number < min_number)
		{
			min_number = current_number;
		}
	}
	cout << min_number << endl;

    return 0;
}

