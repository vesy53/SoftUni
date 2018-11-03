// House.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int number_of_stars = 1;
	int number_of_rows = (size - 1) / 2;

	if (size % 2 == 0)
	{
		number_of_stars += 1;
	}

	int number_of_dashes;
	for (int row = 0; row <= number_of_rows; row++)
	{
		number_of_dashes = (size - number_of_stars) / 2;
		cout << string(number_of_dashes, '-')
			<< string(number_of_stars, '*')
			<< string(number_of_dashes, '-')
			<< endl;
		number_of_stars += 2;
	}
	number_of_rows = size / 2;
	for (int row = 0; row < number_of_rows; row++)
	{
		cout << "|" << string(size - 2, '*') << "|" << endl;
	}
    return 0;
}

