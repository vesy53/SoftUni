// p06.StupidPasswordGenerator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num_1;
	int num_2;
	cin >> num_1 >> num_2;

	for (int i = 1; i <= num_1; i++)
	{
		for (int j = 1; j <= num_1; j++)
		{
			for (char k = 'a'; k < 'a' + num_2; k++)
			{
				for (char n = 'a'; n < 'a' + num_2; n++)
				{
					for (int m = 1; m <= num_1; m++)
					{
						if (m > i && m > j)
						{
							cout << i << j << k << n << m << " " << endl;

						}
					}
				}
			}
		}
	}

    return 0;
}

