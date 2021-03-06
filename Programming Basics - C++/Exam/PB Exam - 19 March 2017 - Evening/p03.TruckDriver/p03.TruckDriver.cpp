// p03.TruckDriver.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string season;
	double km_per_month;
	cin >> season >> km_per_month;

	double price = 0;

	if (km_per_month <= 5000)
	{
		if (season == "Spring" || season == "Autumn")
		{
			price = 0.75;
		}
		else if (season == "Summer")
		{
			price = 0.9;
		}
		else if (season == "Winter")
		{
			price = 1.05;
		}
	}
	else if (km_per_month > 5000 && km_per_month <= 10000)
	{
		if (season == "Spring" || season == "Autumn")
		{
			price = 0.95;
		}
		else if (season == "Summer")
		{
			price = 1.10;
		}
		else if (season == "Winter")
		{
			price = 1.25;
		}
	}
	else if (km_per_month > 10000 && km_per_month <= 20000)
	{
		if (season == "Spring" || season == "Summer"
			|| season == "Autumn" || season == "Winter")
		{
			price = 1.45;
		}
	}

	double salary = (km_per_month * price) * 4;
	double total = salary - salary * 0.1;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

