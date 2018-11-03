// SquareOfStars.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;
	string spaces;

	cout << string(size, '*') << endl;
	spaces = string(size - 2, ' ');

	for (int row = 1; row <= size - 2; row++)
	{
		cout << "*" << spaces << "*" << endl;
	}

	cout << string(size, '*') << endl;

    return 0;
}

