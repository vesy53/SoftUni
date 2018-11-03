// p14.TableWithNumbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int number = 0;

	for (int row = 0; row < num; row++)
	{
		for (int col = 0; col < num; col++)
		{
			number = row + col + 1;

			if (number > num)
			{
				number -= 2 * num;
			}

			cout << std::abs(number) << " ";
		}

		cout << endl;
	}

    return 0;
}

