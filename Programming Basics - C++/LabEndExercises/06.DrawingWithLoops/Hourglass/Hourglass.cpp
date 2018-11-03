// Hourglass.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = size * 2 + 1;

	cout << string(width, '*') << endl;

	cout << "." << "*" << string(width - 4, ' ') 
		 << "*" << "." << endl;

	int dots = 2;
	int a_monkey = width - 6;
	for (int row = 1; row <= size - 2; row++)
	{
		cout << string(dots, '.') << "*"
			<< string(a_monkey, '@') << "*"
			<< string(dots, '.') << endl;
		dots++;
		a_monkey -= 2;
	}

	dots = (size * 2) / 2;
	cout << string(dots, '.') << "*" 
		 << string(dots, '.') << endl;

	dots--;
	int space = 0;
	for (int row = 1; row <= size - 2; row++)
	{
		cout << string(dots, '.') << "*" << string(space, ' ')
			 << "@" << string(space, ' ') << "*" 
			 << string(dots, '.') << endl;
		dots--;
		space++;
	}

	a_monkey = width - 4;
	cout << "." << "*" << string(a_monkey, '@')
		<< "*" << "." << endl;

	cout << string(width, '*') << endl;

    return 0;
}

