// p06.SelectionOrArtwork.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int control_num;
	cin >> control_num;

	int selection = 0;
	int artwork = 0;
	bool is_counter = false;

	for (int i = 1; i <= 30; i++)
	{
		for (int j = 1; j <= 30; j++)
		{
			for (int k = 1; k <= 30; k++)
			{
				selection = i + j + k;

				if (selection == control_num && i < j && j < k)
				{
					cout << i << " + " << j << " + " << k << " = " << selection << endl;
					
					is_counter = true;
				}

				artwork = i * j * k;

				if (artwork == control_num && i > j && j > k)
				{
					cout << i << " * " << j << " * " << k << " = " << artwork << endl;

					is_counter = true;
				}
			}
		}
	}

	if (!is_counter)
	{
		cout << "No!" << endl;
	}

    return 0;
}

