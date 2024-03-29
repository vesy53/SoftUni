// p03.Vacation.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int num_elderly;
	int num_students;
	int num_night;
	string transport;
	cin >> num_elderly >> num_students >> num_night >> transport;

	double price_elderlys = 0;
	double price_students = 0;
	int total_person = num_elderly + num_students;

	if (transport == "train")
	{
		price_elderlys = 24.99;
		price_students = 14.99;

		if (total_person >= 50)
		{
			price_elderlys *= 0.5;
			price_students *= 0.5;
		}
	}
	else if (transport == "bus")
	{
		price_elderlys = 32.50;
		price_students = 28.50;
	}
	else if (transport == "boat")
	{
		price_elderlys = 42.99;
		price_students = 39.99;
	}
	else if (transport == "airplane")
	{
		price_elderlys = 70;
		price_students = 50;
	}

	double price_transport = 
		num_elderly * price_elderlys + num_students * price_students;
	price_transport *= 2;
	double price_hotel = num_night * 82.99;
	double commission = (price_transport + price_hotel) * 0.1;
	double total = price_transport + price_hotel + commission;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

