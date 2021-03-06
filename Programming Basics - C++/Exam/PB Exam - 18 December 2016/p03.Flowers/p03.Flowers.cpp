// p03.Flowers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	int num_chrysant;
	int num_roses;
	int num_tulips;
	string season;
	string holidays;
	cin >> num_chrysant >> num_roses >> num_tulips >> season >> holidays;

	double price_chrysant = 0;
	double price_roses = 0;
	double price_tulips = 0;

	if (season == "Spring" || season == "Summer")
	{
		price_chrysant = 2;
		price_roses = 4.10;
		price_tulips = 2.50;
	}
	else if (season == "Autumn" || season == "Winter")
	{
		price_chrysant = 3.75;
		price_roses = 4.50;
		price_tulips = 4.15;
	}

	double total =
		num_chrysant * price_chrysant + num_roses * price_roses + num_tulips * price_tulips;

	if (holidays == "Y")
	{
		total += total * 0.15;
	}

	if (season == "Spring" && num_tulips > 7)
	{
		total -= total * 0.05;
	}

	if (season == "Winter" && num_roses >= 10)
	{
		total -= total * 0.1;
	}

	if (num_chrysant + num_roses + num_tulips > 20)
	{
		total -= total * 0.2;
	}

	total += 2;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

