// p05.Ax.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int width = 5 * size;
	int left_dashes = 3 * size;
	int middle_dashes = 0;
	int right_dashes = width - left_dashes - 2;

	for (int row = 1; row <= size; row++)
	{
		cout << string(left_dashes, '-') 
			<< "*"
			<< string(middle_dashes, '-')
			<< "*" 
			<< string(right_dashes, '-')
			<< endl;

		middle_dashes++;
		right_dashes--;
	}

	int stars = left_dashes + 1;
	middle_dashes--;
	right_dashes++;

	for (int row = 1; row <= size / 2; row++)
	{
		cout << string(stars, '*')
			<< string(middle_dashes, '-')
			<< "*" 
			<< string(right_dashes, '-')
			<< endl;
	}

	for (int row = 1; row <= size / 2 - 1; row++)
	{
		cout << string(left_dashes, '-') 
			<< "*"
			<< string(middle_dashes, '-') 
			<< "*"
			<< string(right_dashes, '-') 
			<< endl;

		left_dashes--;
		right_dashes--;
		middle_dashes += 2;
	}

	stars = middle_dashes + 2;
	cout << string(left_dashes, '-') 
		<< string(stars, '*')
		<< string(right_dashes, '-') 
		<< endl;

	return 0;
}