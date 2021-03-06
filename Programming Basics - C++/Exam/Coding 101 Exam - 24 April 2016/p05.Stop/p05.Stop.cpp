// Stop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = 4 * size + 1;
	int height = 2 * size + 2;
	int dots = size + 1;
	int dashes = 2 * size + 1;

	cout << string(dots, '.') 
		<< string(dashes, '_') 
		<< string(dots, '.') 
		<< endl;

	dashes -= 2;
	dots--;

	for (int row = 1; row <= size; row++)
	{
		cout << string(dots, '.') 
			<< "//" 
			<< string(dashes, '_')
			<< "\\\\" 
			<< string(dots, '.') 
			<< endl;

		dashes += 2;
		dots--;
	}

	cout << "//" 
		<< string((dashes - 5) / 2, '_') 
		<< "STOP!"
		<< string((dashes - 5) / 2, '_') 
		<< "\\\\" 
		<< endl;

	for (int row = 0; row < size; row++)
	{
		cout << string(dots, '.') 
			<< "\\\\" 
			<< string(dashes, '_')
			<< "//" 
			<< string(dots, '.') 
			<< endl;

		dashes -= 2;
		dots++;
	}

	return 0;
}

