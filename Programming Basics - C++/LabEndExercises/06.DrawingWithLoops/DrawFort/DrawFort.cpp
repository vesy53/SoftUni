// DrawFort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = 2 * size;
	int height = size;
	int column = size / 2;
	int middle = 2 * size - 2 * column - 4;
	int middle_body = 2 * size - 2;
	string under_dash = string(middle, '_');
	string fur_caps = string(column, '^');
	string centre = string(middle_body, ' ');
	cout << "/" << fur_caps << "\\" << under_dash 
		 << "/" << fur_caps << "\\" << endl;

	for (int row = 1; row <= size - 3; row++)
	{
		cout << "|" << centre << "|" << endl;
	}
	string side_col = string(column + 1, ' ');
	cout << "|" << side_col << under_dash 
		 << side_col << "|" << endl;

	string middle_space = string(middle, ' ');
	string below_dash = string(column, '_');
	cout << "\\" << below_dash << "/" << middle_space 
		 << "\\" << below_dash << "/" << endl;

    return 0;
}

