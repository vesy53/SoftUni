// p08.Factorial.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int factorial = 1;

	do
	{
		factorial *= num;
		num--;

	} while (num > 1);

	cout << factorial << endl;

    return 0;
}

