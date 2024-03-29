// p05.ChristmasHat.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int width = num * 4 + 1;
	int height = num * 2 + 5;

	cout << string(width / 2 - 1, '.')
		<< "/|\\"
		<< string(width / 2 - 1, '.')
		<< endl;

	cout << string(width / 2 - 1, '.')
		<< "\\|/"
		<< string(width / 2 - 1, '.')
		<< endl;

	int dashes = width / 2 - 1;

	for (int i = 0; i < num * 2; i++)
	{
		cout << string(dashes, '.') << "*"
			<< string(i, '-') << "*"
			<< string(i, '-') << "*"
			<< string(dashes, '.')
			<< endl;

		dashes--;
	}

	cout << string(width, '*') << endl;

	for (int i = 0; i < 1; i++)
	{
		for (int j = 1; j <= width; j++)
		{
			if (j % 2 == 1)
			{
				cout << "*";
			}
			else
			{
				cout << ".";
			}
		}

		cout << endl;
	}

	cout << string(width, '*') << endl;

    return 0;
}

