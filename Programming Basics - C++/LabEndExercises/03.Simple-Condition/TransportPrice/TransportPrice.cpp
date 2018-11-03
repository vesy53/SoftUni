// TransportPrice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string one_day_or_night;
	double kilometers, price;
	cin >> kilometers >> one_day_or_night;

	double taxi_input_charge = 0.70;
	double taxi_day_charge = 0.79;
	double taxi_night_charge = 0.90;
	double bus_charge = 0.09;
	double train_charge = 0.06;

    if (kilometers >= 100)
	{
		if (one_day_or_night == "day" || one_day_or_night == "night")
		{
			price = kilometers * train_charge;
		}
	} 
	else if (kilometers >= 20)
	{
		if (one_day_or_night == "day" || one_day_or_night == "night")
		{
			price = kilometers * bus_charge;
		}
	}
	else if (kilometers < 20)
	{
		if (one_day_or_night == "day")
		{
			price = taxi_input_charge + kilometers * taxi_day_charge;
		}
		else if (one_day_or_night == "night")
		{
			price = taxi_input_charge + kilometers * taxi_night_charge;
		}
	}
	cout << fixed << setprecision(2) << price << endl;

    return 0;
}

