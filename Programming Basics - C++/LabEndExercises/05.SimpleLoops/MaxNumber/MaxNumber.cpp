// ofMaxNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <climits>
using namespace std;

int main()
{
	int number_of_input;
	cin >> number_of_input;
	int max_number = INT_MIN;

	for (int i = 0; i < number_of_input; i++)
	{
		int current_number;
		cin >> current_number;
		if (current_number > max_number)
		{
			max_number = current_number;
		}
	}
	cout << max_number << endl;

    return 0;
}

