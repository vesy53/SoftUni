// Rectangle10To10Stars.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	for (int row = 1; row <= 10; row++)
	{
		for (int col = 1; col <= 10; col++)
		{
			cout << "*";
		}

		cout << endl;
	}

    return 0;
}

