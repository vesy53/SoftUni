// p06.Profit.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int monets_1;
	int monets_2;
	int banknotes_5;
	int sum;
	cin >> monets_1 >> monets_2 >> banknotes_5 >> sum;

	for (int i = 0; i <= monets_1; i++)
	{
		for (int j = 0; j <= monets_2; j++)
		{
			for (int k = 0; k <= banknotes_5; k++)
			{
				int result = i * 1 + j * 2 + k * 5;

				if (sum == result)
				{
					cout << i << " * 1 lv. + " 
						<< j << " * 2 lv. + " 
						<< k << " * 5 lv. = " 
						<< sum << " lv." 
						<< endl;
				}
			}
		}
	}

    return 0;
}

