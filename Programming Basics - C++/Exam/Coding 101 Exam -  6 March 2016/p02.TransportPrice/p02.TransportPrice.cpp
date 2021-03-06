// p02.TransportPrice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int num_km;
	string day_or_night;
	cin >> num_km >> day_or_night;

	double price = 0;
	double inner_price = 0;

	if (num_km < 20)
	{
		inner_price = 0.70;

		if (day_or_night == "day")
		{
			price = 0.79;
		}
		else if (day_or_night == "night")
		{
			price = 0.90;
		}
	}
	else if (num_km >= 20 && num_km < 100)
	{
		price = 0.09;
	}
	else if (num_km >= 100)
	{
		price = 0.06;
	}

	double total_price = inner_price + num_km * price;

	cout << fixed 
		<< setprecision(2) 
		<< total_price 
		<< endl;

    return 0;
}

