// p15.SongOfTheBikes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int special_value;
	cin >> special_value;

	int counter = 0;
	string special_pass;

	for (int i = 1; i <= 9; i++)
	{
		for (int j = i + 1; j <= 9; j++)
		{
			for (int k = 1; k <= 9; k++)
			{
				for (int l = 1; l < k; l++)
				{
					string current_pass = to_string(i) + to_string(j) + to_string(k) + to_string(l);

					int temp = i * j + k * l;

					if (temp == special_value)
					{
						cout << current_pass << " ";
						counter++;

						if (counter == 4)
						{
							special_pass = current_pass;
						}
					}
				}
			}
		}
	}

	if (counter > 0)
	{
		cout << endl;
	}

	if (counter < 4)
	{
		cout << "No!" << endl;
	}
	else
	{
		cout << "Password: " << special_pass << endl;
	}

    return 0;
}

