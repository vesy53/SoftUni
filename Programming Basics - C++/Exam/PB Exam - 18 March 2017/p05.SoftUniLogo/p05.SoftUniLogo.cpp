// p05.SoftUniLogo.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int height = size * 4 - 2;
	int width = size * 12 - 5;

	int left_dots = (width - 1) / 2;
	int right_dots = (width - 1) / 2;
	int sharp = 1;

	for (int row = 1; row <= (height / 2) + 1; row++)
	{
		cout << string(left_dots, '.') 
			<< string(sharp, '#')
			<< string(right_dots, '.') 
			<< endl;

		left_dots -= 3;
		right_dots -= 3;
		sharp += 6;
	}

	left_dots = 2;
	right_dots = 3;
	sharp -= 12;

	for (int row = 1; row <= size - 1; row++)
	{
		cout << "|" 
			<< string(left_dots, '.')
			<< string(sharp, '#')
			<< string(right_dots, '.') 
			<< endl;

		left_dots += 3;
		right_dots += 3;
		sharp -= 6;
	}

	left_dots -= 3;
	right_dots -= 3;
	sharp += 6;

	for (int row = 1; row <= size - 2; row++)
	{
		cout << "|" 
			<< string(left_dots, '.')
			<< string(sharp, '#')
			<< string(right_dots, '.') 
			<< endl;
	}

	cout << "@" 
		<< string(left_dots, '.') 
		<< string(sharp, '#')
		<< string(right_dots, '.')
		<< endl;

	return 0;
}