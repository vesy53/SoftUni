// p05.Parallelepiped.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int height = num * 4 + 4;
	int width = num * 3 + 1;

	cout << "+"
		<< string(num - 2, '~')
		<< "+"
		<< string(num * 2 + 1, '.')
		<< endl;

	int dots = num * 2;

	for (int i = 0; i < num * 2 + 1; i++)
	{
		cout << "|" 
			<< string(i, '.')
			<< "\\"
			<< string(num - 2, '~')
			<< "\\"
			<< string(dots, '.')
			<< endl;

		dots--;
	}
	
	dots = num * 2;

	for (int i = 0; i < num * 2 + 1; i++)
	{
		cout << string(i, '.')
			<< "\\"
			<< string(dots, '.')
			<< "|"
			<< string(num - 2, '~')
			<< "|"
			<< endl;

		dots--;
	}
	
	cout << string(num * 2 + 1, '.')
		<< "+"
		<< string(num - 2, '~')
		<< "+"
		<< endl;

    return 0;
}

