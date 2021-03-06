// p05.Rocket.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int width = num * 3;
	int dots = width / 2 - 1;
	int spase = 0;

	for (int i = 0; i < num; i++)
	{
		cout << string(dots, '.')
			<< "/"
			<< string(spase, ' ')
			<< "\\"
			<< string(dots, '.')
			<< endl;

		dots--;
		spase += 2;
	}

	cout << string(num / 2, '.')
		<< string(num * 2, '*')
		<< string(num / 2, '.')
		<< endl;

	for (int i = 0; i < num * 2; i++)
	{
		cout << string(num / 2, '.')
			<< "|"
			<< string(num * 2 - 2, '\\')
			<< "|"
			<< string(num / 2, '.')
			<< endl;
	}

	dots = num / 2;
	int stars = num * 2 - 2;

	for (int i = 0; i < num / 2; i++)
	{
		cout << string(dots, '.')
			<< "/"
			<< string(stars, '*')
			<< "\\"
			<< string(dots, '.')
			<< endl;

		dots--;
		stars += 2;
	}

    return 0;
}

