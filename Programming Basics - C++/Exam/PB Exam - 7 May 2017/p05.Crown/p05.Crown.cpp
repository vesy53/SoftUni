// p05.Crown.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int width = (2 * num) - 1;
	int height = (num / 2) + 4;

	cout << "@"
		<< string(num - 2, ' ')
		<< "@"
		<< string(num - 2, ' ')
		<< "@"
		<< endl;

	cout << "**"
		<< string(num - 3, ' ')
		<< "*"
		<< string(num - 3, ' ')
		<< "**"
		<< endl;

	int spase = num - 5;
	int innerDash = 1;

	for (int i = 1; i <= num / 2 - 2; i++)
	{
		cout << "*"
			<< string(i, '.')
			<< "*"
			<< string(spase, ' ')
			<< "*"
			<< string(innerDash, '.')
			<< "*"
			<< string(spase, ' ')
			<< "*"
			<< string(i, '.')
			<< "*"
			<< endl;

		innerDash += 2;
		spase -= 2;
	}

	cout << "*"
		<< string(num / 2 - 1, '.')
		<< "*"
		<< string(num - 3, '.')
		<< "*"
		<< string(num / 2 - 1, '.')
		<< "*"
		<< endl;

	cout << "*"
		<< string(num / 2, '.')
		<< string(num / 2 - 2, '*')
		<< "."
		<< string(num / 2 - 2, '*')
		<< string(num / 2, '.')
		<< "*"
		<< endl;

	for (int i = 0; i < 2; i++)
	{
		cout << string(width, '*') 
			<< endl;
	}

    return 0;
}

