// p02.NumbersFromNTo1InReversedRow.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number;
	cin >> number;

	for (int i = number; i >= 1; i--)
	{
		cout << i << endl;
	}

    return 0;
}

