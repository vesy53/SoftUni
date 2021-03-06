// p05.Fox.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = size * 2 + 3;

	int exes = 1;
	int dash = width - 4;

	for (int i = 1; i <= size; i++)
	{
		cout << string(exes, '*')
			<< "\\"
			<< string(dash, '-') 
			<< "/"
			<< string(exes, '*') 
			<< endl;

		exes++;
		dash -= 2;
	}

	exes = size / 2;
	int inner_exes = size;

	for (int i = 1; i <= size / 3; i++)
	{
		cout << "|" 
			<< string(exes, '*')
			<< "\\"
			<< string(inner_exes, '*')
			<< "/"
			<< string(exes, '*') 
			<< "|"
			<< endl;

		exes++;
		inner_exes -= 2;
	}

	dash = 1;
	exes = width - 4;

	for (int i = 1; i <= size; i++)
	{
		cout << string(dash, '-') 
			<< "\\"
			<< string(exes, '*') 
			<< "/"
			<< string(dash, '-') 
			<< endl;

		exes -= 2;
		dash++;
	}

	return 0;
}