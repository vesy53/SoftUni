// p03.NumbersFrom2Pow0To2powN.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number;
	cin >> number;

	int my_number = 1;

	for (int i = 0; i < number; i++)
	{
		cout << my_number << endl;

		my_number *= 2;
	}

	cout << my_number << endl;

    return 0;
}

