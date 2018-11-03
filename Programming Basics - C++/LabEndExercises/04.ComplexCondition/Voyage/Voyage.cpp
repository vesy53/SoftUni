// Voyage.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double boudget, price;
	string season;

	cin >> boudget >> season;

	if (boudget <= 100)
	{
		cout << "Somewhere in Bulgaria" << endl;

		if (season == "summer")
		{
			price = boudget * 30 / 100;
			cout << "Camp - " << fixed << setprecision(2) << price << endl;
		}
		else if (season == "winter")
		{
			price = boudget * 70 / 100;
			cout << "Hotel - " << fixed << setprecision(2) << price << endl;
		}
	}
	else if (boudget <= 1000)
	{
		cout << "Somewhere in Balkans" << endl;

		if (season == "summer")
		{
			price = boudget * 40 / 100;
			cout << "Camp - " << fixed << setprecision(2) << price << endl;
		}
		else if (season == "winter")
		{
			price = boudget * 80 / 100;
			cout << "Hotel - " << fixed << setprecision(2) << price << endl;
		}
	}
	else if (boudget > 1000)
	{
		price = boudget * 90 / 100;
		cout << "Somewhere in Europe" << endl;
		cout << "Hotel - " << fixed << setprecision(2) << price << endl;
	}

    return 0;
}

