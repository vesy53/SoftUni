// ChristmasTree.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	for (int row = 0; row <= size; row++)
	{
		int number_of_stars = row;
		int number_of_spaces = size - number_of_stars;
		string spaces = string(number_of_spaces, ' ');
		string stars = string(number_of_stars, '*');

		cout << spaces << stars << " | " << stars << endl;
	}
    return 0;
}

