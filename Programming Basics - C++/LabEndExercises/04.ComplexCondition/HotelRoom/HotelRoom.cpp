// HotelRoom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string month;
	double number_night;
	cin >> month >> number_night;

	double discount_apartment, discount_studio, cost_apartment, cost_studio;
	double total_cost_apartment, total_cost_studio;

	if (month == "May" || month == "October")
	{
		if (number_night > 14)
		{
			discount_apartment = 65 * 0.1;
			cost_apartment = 65 - discount_apartment;
			total_cost_apartment = cost_apartment * number_night;
			discount_studio = 50 * 0.3;
			cost_studio = 50 - discount_studio;
            total_cost_studio = cost_studio * number_night;

		}
		else if (number_night > 7)
		{
			total_cost_apartment = 65 * number_night;
			discount_studio = 50 * 0.05;
			cost_studio = 50 - discount_studio;
			total_cost_studio = cost_studio * number_night;
		}
		else 
		{
			total_cost_apartment = 65 * number_night;
			total_cost_studio = 50 * number_night;
		}
	}
	else if (month == "June" || month == "September")
	{
		if (number_night > 14)
		{
			discount_apartment = 68.70 * 0.1;
			cost_apartment = 68.70 - discount_apartment;
			total_cost_apartment = cost_apartment * number_night;
			discount_studio = 75.20 * 0.2;
			cost_studio = 75.20 - discount_studio;
			total_cost_studio = cost_studio * number_night;
		}
		else if(number_night <= 14)
		{
			total_cost_apartment = 68.70 * number_night;
			total_cost_studio = 75.20 * number_night;
		}
	}
	else if (month == "July" || month == "August")
	{
		if (number_night > 14)
		{
			discount_apartment = 77 * 0.1;		
			cost_apartment = 77 - discount_apartment;
			total_cost_apartment = cost_apartment * number_night;
			total_cost_studio = 76 * number_night;
		}
		else if (number_night <= 14)
		{
			total_cost_apartment = 77 * number_night;
			total_cost_studio = 76 * number_night;
		}
	}

	cout << "Apartment: " << fixed << setprecision(2) << total_cost_apartment << " lv." << endl;
	cout << "Studio: " << fixed << setprecision(2) << total_cost_studio << " lv." << endl;

    return 0;
}

