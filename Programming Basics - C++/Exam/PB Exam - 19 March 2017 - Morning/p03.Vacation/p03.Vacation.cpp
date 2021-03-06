// p03.Vacation.cpp : Defines the entry point for the console application.
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

	string accommodation = "";
	string location = "";
	double price = 0;

	if (boudget <= 1000)
	{
		accommodation = "Camp";

		if (season == "Summer")
		{
			location = "Alaska";
			price = boudget * 0.65;
		}
		else if (season == "Winter")
		{
			location = "Morocco";
			price = boudget * 0.45;
		}
	}
	else if (boudget > 1000 && boudget <= 3000)
	{
		accommodation = "Hut";

		if (season == "Summer")
		{
			location = "Alaska";
			price = boudget * 0.8;
		}
		else if (season == "Winter")
		{
			location = "Morocco";
			price = boudget * 0.6;
		}
	}
	else if (boudget > 3000)
	{
		accommodation = "Hotel";

		if (season == "Summer")
		{
			location = "Alaska";
			price = boudget * 0.9;
		}
		else if (season == "Winter")
		{
			location = "Morocco";
			price = boudget * 0.9;
		}
	}

	cout << location 
		<< " - " 
		<< accommodation
		<< " - " 
		<< fixed << setprecision(2) << price
		<< endl;

    return 0;
}

