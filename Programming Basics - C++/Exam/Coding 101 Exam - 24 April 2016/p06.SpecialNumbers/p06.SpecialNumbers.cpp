// p06.SpecialNumbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int num;
	cin >> num;

	for (int i = 1; i <= 9; i++)
	{
		for (int j = 1; j <= 9; j++)
		{
			for (int k = 1; k <= 9; k++)
			{
				for (int m = 1; m <= 9; m++)
				{
					if (num % i == 0 && num % j == 0
						&& num % k == 0 && num % m == 0)
					{
						cout << i << j << k << m << " " << endl;
					}
				}
			}
		}
	}

    return 0;
}

