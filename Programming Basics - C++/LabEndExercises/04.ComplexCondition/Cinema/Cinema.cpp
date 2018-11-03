// Cinema.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string type_cinema;
	int row, column;
	double price;

	cin >> type_cinema >> row >> column;

	if (type_cinema == "Premiere")
	{
		price = (row * column) * 12;
	}
	else if (type_cinema == "Normal")
	{
		price = (row * column) * 7.50;
	}
	else if (type_cinema == "Discount")
	{
		price = (row * column) * 5;
	}

	cout << fixed << setprecision(2) << price << endl;

    return 0;
}

 