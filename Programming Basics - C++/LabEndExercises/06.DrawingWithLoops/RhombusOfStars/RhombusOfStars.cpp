// RhombusOfStars.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int size;
	cin >> size;

	for (int row = 1; row <= size; row++)
	{
		int number_of_stars = row;
		int number_of_spaces = size - row;
		for (int spaces = 1; spaces <= number_of_spaces; spaces++)
		{
			cout << " ";
		}
		cout << "* ";
		for (int stars = 1; stars < number_of_stars; stars++)
		{
			cout << "* ";
		}
		cout << endl;
	}

	for (int row = size - 1; row >= 1; row--)
	{
		int number_of_stars = row;
		int number_of_spaces = size - row;

		for (int spaces = 1; spaces <= number_of_spaces; spaces++)
		{
			cout << " ";
		}
		cout << "* ";
		for (int stars = 1; stars < number_of_stars; stars++)
		{
			cout << "* ";
		}
		cout << endl;
	}
    return 0;
}

