// SumNumbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number_of_input;
	cin >> number_of_input;
	int sum = 0;

	for (int i = 0; i < number_of_input; i++)
	{
		int current_number;
		cin >> current_number;
		sum += current_number;
	}
	cout << sum << endl;

    return 0;
}

