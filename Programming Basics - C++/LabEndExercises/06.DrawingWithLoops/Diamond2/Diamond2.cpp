// Diamond2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = size * 5;
	int height = size * 3 + 2;

	int dots = size;
	int star = size * 3;
	cout << string(dots, '.') << string(star, '*') << string(dots, '.') << endl;

	int inner_dots = size * 3;
	for (int i = 1; i <= size - 1; i++)
	{
		dots--;
		cout << string(dots, '.') << "*"
			 << string(inner_dots, '.') << "*"
			 << string(dots, '.') << endl;
		inner_dots += 2;
	}
	cout << string(width, '*') << endl;

	dots = 1; 
	inner_dots = width - 4;
	for (int i = 1; i <= size * 2; i++)
	{
		cout << string(dots, '.') << "*"
			<< string(inner_dots, '.') << "*"
			<< string(dots, '.') << endl;
		dots++;
		inner_dots -= 2;
	}
	cout << string(size * 2 + 1, '.') << string(size - 2, '*')
		 << string(size * 2 + 1, '.') << endl;

    return 0;
}

