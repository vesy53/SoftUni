// p03.HotelRoom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string month;
	double num_night;
	cin >> month >> num_night;

	double price_studio = 0;
	double price_apartment = 0;

	if (month == "May" || month == "October")
	{
		price_studio = 50;
		price_apartment = 65;

		if (num_night > 14)
		{
			price_studio -= price_studio * 0.3;
			price_apartment -= price_apartment * 0.1;
		}
		else if (num_night > 7)
		{
			price_studio -= price_studio * 0.05;
		}
	}
	else if (month == "June" || month == "September")
	{
		price_studio = 75.20;
		price_apartment = 68.70;

		if (num_night > 14)
		{
			price_studio -= price_studio * 0.2;
			price_apartment -= price_apartment * 0.1;
		}
	}
	else if (month == "July" || month == "August")
	{
		price_studio = 76;
		price_apartment = 77;

		if (num_night > 14)
		{
			price_apartment -= price_apartment * 0.1;
		}
	}

	double total_price_studio = price_studio * num_night;
	double total_price_apartment = price_apartment * num_night;

	cout << "Apartment: "
		<< fixed << setprecision(2) << total_price_apartment 
		<< " lv." 
		<< endl;
	cout << "Studio: " 
		<< fixed << setprecision(2) << total_price_studio
		<< " lv." 
		<< endl;

    return 0;
}

