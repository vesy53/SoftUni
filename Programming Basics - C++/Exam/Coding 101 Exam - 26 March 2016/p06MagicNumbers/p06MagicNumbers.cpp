// p06MagicNumbers.cpp : Defines the entry point for the console application.
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
				for (int l = 1; l <= 9; l++)
				{
					for (int m = 1; m <= 9; m++)
					{
						for (int n = 1; n <= 9; n++)
						{
							int sum = i * j * k * l * m * n;

							if (sum == num)
							{
								cout << i << j << k << l << m << n << " " << endl;
							}
						}
					}
				}
			}
		}

    return 0;
}

