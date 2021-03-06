// p04.ParquePrize.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int parts_divided;
	double money_for_point;
	cin >> parts_divided >> money_for_point;

	double total = 0;

	for (int i = 1; i <= parts_divided; i++)
	{
		int points;
		cin >> points;

		if (i % 2 == 0)
		{
			points *= 2;
		}

		total += points;
	}

	money_for_point *= total;

	cout << "The project prize was " 
		<< fixed << setprecision(2) << money_for_point << " lv." << endl;

    return 0;
}

