// p03.CarToGo.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	double boudget;
	string season;
	cin >> boudget >> season;

	string class_car = "";
	double price = 0.0;
	string car = "";

	if (boudget <= 100)
	{
		class_car = "Economy class";

		if (season == "Summer")
		{
			car = "Cabrio";
			price = boudget * 0.35;
		}
		else if (season == "Winter")
		{
			car = "Jeep";
			price = boudget * 0.65;
		}
	}
	else if (boudget > 100 && boudget <= 500)
	{
		class_car = "Compact class";

		if (season == "Summer")
		{
			car = "Cabrio";
			price = boudget * 0.45;
		}
		else if (season == "Winter")
		{
			car = "Jeep";
			price = boudget * 0.8;
		}
	}
	else if (boudget > 500)
	{
		class_car = "Luxury class";

		if (season == "Summer" || season == "Winter")
		{
			car = "Jeep";
			price = boudget * 0.9;
		}
	}

	cout << class_car << endl;
	cout << car 
		<< " - " 
		<< fixed << setprecision(2) << price
		<< endl;

    return 0;
}

