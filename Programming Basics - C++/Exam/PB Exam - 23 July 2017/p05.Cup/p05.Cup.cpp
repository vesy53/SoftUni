// p05.Cup.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int width = num * 5;
	int dots = num;
	int dies = num * 3;

	for (int i = 0; i < num / 2; i++)
	{
		cout << string(dots, '.')
			<< string(dies, '#')
			<< string(dots, '.')
			<< endl;

		dots++;
		dies -= 2;
	}

	dots = num + num / 2;
	int innerDots = num * 2 - 2;

	for (int i = 0; i < num / 2 + 1; i++)
	{
		cout << string(dots, '.')
			<< "#"
			<< string(innerDots, '.')
			<< "#"
			<< string(dots, '.')
			<< endl;

		dots++;
		innerDots -= 2;
	}

	cout << string(num * 2, '.')
		<< string(num, '#')
		<< string(num * 2, '.')
		<< endl;

	for (int i = 0; i < num + 2; i++)
	{
		if (i == num / 2)
		{
			cout << string(((width - 10) / 2), '.')
				<< "D^A^N^C^E^"
				<< string(((width - 10) / 2), '.')
				<< endl; 
		}
		else
		{
			cout << string(num * 2 - 2, '.')
				<< string(num + 4, '#')
				<< string(num * 2 - 2, '.')
				<< endl;
		}
	}

    return 0;
}

