// p03.BikeRace.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	int juniors_bake;
	int seniors_bake;
	string route;
	cin >> juniors_bake >> seniors_bake >> route;

	double prise_juniors = 0;
	double price_seniors = 0;

	if (route == "trail")
	{
		prise_juniors = 5.50;
		price_seniors = 7;
	}
	else if (route == "cross-country")
	{
		prise_juniors = 8;
		price_seniors = 9.50;

		if (juniors_bake + seniors_bake >= 50)
		{
			prise_juniors -= prise_juniors * 0.25;
			price_seniors -= price_seniors * 0.25;
		}
	}
	else if (route == "downhill")
	{
		prise_juniors = 12.25;
		price_seniors = 13.75;
	}
	else if (route == "road")
	{
		prise_juniors = 20;
		price_seniors = 21.50;
	}

	double total_price = 
		juniors_bake * prise_juniors + seniors_bake * price_seniors;
	double costs = total_price * 0.05;
	total_price -= costs;

	cout << fixed << setprecision(2) << total_price << endl;

    return 0;
}

