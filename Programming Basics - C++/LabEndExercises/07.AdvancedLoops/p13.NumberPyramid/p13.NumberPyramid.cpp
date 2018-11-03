// p13.NumberPyramid.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int number = 1;
	
	for (int row = 1; row <= num; row++)
	{
		for (int col = 1; col <= row; col++)
		{
			if (col > 1)
			{
				cout << " ";
			}

			cout << number;
			number++;

			if (number > num)
			{
				break;
			}
		}

		cout << endl;

		if (number > num)
		{
			break;
		}
	}

    return 0;
}

