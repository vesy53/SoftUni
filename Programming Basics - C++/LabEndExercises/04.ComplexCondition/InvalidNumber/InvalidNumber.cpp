// InvalidNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	double number;
	cin >> number;

	bool is_valid = number >= 100 && number <= 200 || number == 0;

	if (!is_valid)
	{
		cout << "invalid" << endl;
	}

    return 0;
}

