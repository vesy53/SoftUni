// p05.Triangle.cpp : Defines the entry point for the console application.
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
	int height = num * 2 + 1;

	cout << string(width, '#') << endl;

	int dies = num * 2 - 1;
	int space = 1;

	for (int i = 1; i <= num; i++)
	{
		if (i == num / 2 + 1)
		{
			cout << string(i, '.')
				<< string(dies, '#')
				<< string(((num / 2) - 1), ' ')
				<< "(@)"
				<< string(((num / 2) - 1), ' ')
				<< string(dies, '#')
				<< string(i, '.')
				<< endl;
		}
		else
		{
			cout << string(i, '.')
				<< string(dies, '#')
				<< string(space, ' ')
				<< string(dies, '#')
				<< string(i, '.')
				<< endl;
		}

		dies -= 2;
		space += 2;
	}

	int dots = num + 1;
	dies = num * 2 - 1;

	for (int i = 0; i < num; i++)
	{
		cout << string(dots, '.')
			<< string(dies, '#')
			<< string(dots, '.')
			<< endl;

		dots++;
		dies -= 2;
	}

    return 0;
}

