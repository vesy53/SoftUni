// p01.NumbersFrom1ToNThrough3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number;
	cin >> number;

	for (int i = 1; i <= number; i += 3)
	{
		cout << i << endl;
	}

    return 0;
}

