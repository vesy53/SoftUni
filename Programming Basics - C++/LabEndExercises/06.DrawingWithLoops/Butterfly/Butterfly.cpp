// Butterfly.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = 2 * size - 1;
	int height = 2 * (size - 2) + 1;
	int left_part = size - 1;
	int right_part = size - 1;

	int half_butterfly = size - 2;
	for (int row = 1; row <= half_butterfly; row++)
	{
		if (row % 2 != 0)
		{
			string odd_row = string(half_butterfly, '*');
			cout << odd_row << "\\ /" << odd_row << endl;
		}
		else
		{
			string even_row = string(half_butterfly, '-');
			cout << even_row << "\\ /" << even_row << endl;
		}
	}
	string spaces = string(half_butterfly + 1, ' ');
	cout << spaces << "@" << spaces << endl;

	for (int row = 1; row <= half_butterfly; row++)
	{
		if (row % 2 != 0)
		{
			string odd_row = string(half_butterfly, '*');
			cout << odd_row << "/ \\" << odd_row << endl;
		}
		else
		{
			string even_row = string(half_butterfly, '-');
			cout << even_row << "/ \\" << even_row << endl;
		}
	}

    return 0;
}

