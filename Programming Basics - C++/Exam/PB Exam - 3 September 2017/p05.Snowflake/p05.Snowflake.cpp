// p05.Snowflake.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int height = 2 * size + 1;
	int width = 2 * size + 3;
	int out_point = 0;
	int in_point = size;

	for (int row = 1; row <= size - 1; row++)
	{
		cout << string(out_point, '.') 
			<< "*" << string(in_point, '.') 
			<< "*"
			<< string(in_point, '.') 
			<< "*" 
			<< string(out_point, '.') 
			<< endl;

		out_point++;
		in_point--;
	}

	int stars = 5;

	cout << string(out_point, '.') 
		<< string(stars, '*')
		<< string(out_point, '.') 
		<< endl;

	stars = width;

	cout << string(stars, '*') 
		<< endl;

	stars = 5;

	cout << string(out_point, '.') 
		<< string(stars, '*')
		<< string(out_point, '.') 
		<< endl;

	out_point--;
	in_point = 2;

	for (int row = 1; row <= size - 1; row++)
	{
		cout << string(out_point, '.') 
			<< "*" 
			<< string(in_point, '.') 
			<< "*"
			<< string(in_point, '.') 
			<< "*" 
			<< string(out_point, '.') 
			<< endl;

		out_point--;
		in_point++;
	}

	return 0;
}