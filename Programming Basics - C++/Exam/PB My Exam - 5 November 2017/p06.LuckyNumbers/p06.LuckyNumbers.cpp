// p06.LuckyNumbers.cpp : Defines the entry point for the console application.
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
					int sum_1 = i + j;
					int sum_2 = k + m;

					if (sum_1 == sum_2)
					{
						if (num % sum_1 == 0)
						{
							cout << i << j << k << m << " ";
						}
					}
				}
			}
		}
	}

    return 0;
}

