// p04.OffsetsOf2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int my_number = 1;

	for (int i = 0; i <= num; i += 2)
	{
		cout << my_number << endl;

		my_number *= 4;
	}

    return 0;
}

