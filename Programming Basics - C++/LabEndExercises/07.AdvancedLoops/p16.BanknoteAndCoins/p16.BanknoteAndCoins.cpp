// p16.BanknoteAndCoins.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int coint_one;
	int coint_two;
	int banknotes_five;
	int sum;
	cin >> coint_one >> coint_two >> banknotes_five >> sum;

	for (int i = 0; i <= coint_one; i++)
	{
		for (int j = 0; j <= coint_two; j++)
		{
			for (int k = 0; k <= banknotes_five; k++)
			{
				int current_sum = i * 1 + j * 2 + k * 5;

				if (current_sum == sum)
				{
					cout << i << " * 1 lv. + " << j << " * 2 lv. + " << k <<  " * 5 lv. = " << sum << " lv." << endl;
				}
			}
		}
	}

    return 0;
}

