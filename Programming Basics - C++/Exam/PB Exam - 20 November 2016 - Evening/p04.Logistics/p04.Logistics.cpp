// p04.Logistics.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int num_loads;
	cin >> num_loads;

	double price_minibus = 0;
	double price_truck = 0;
	double price_train = 0;
	double total = 0;
	double total_minibus = 0;
	double total_truck = 0;
	double total_train = 0;

	for (int i = 1; i <= num_loads; i++)
	{
		int tonnage_cargo;
		cin >> tonnage_cargo;

		total += tonnage_cargo;

		if (tonnage_cargo <= 3)
		{
			price_minibus = 200;
			total_minibus += tonnage_cargo;
		}
		else if (tonnage_cargo > 3 && tonnage_cargo <= 11)
		{
			price_truck = 175;
			total_truck += tonnage_cargo;
		}
		else if (tonnage_cargo >= 12)
		{
			price_train = 120;
			total_train += tonnage_cargo;
		}
	}

	price_minibus *= total_minibus;
	price_truck *= total_truck;
	price_train *= total_train;
	double average = (price_minibus + price_truck + price_train) / total;
	double minibus = total_minibus / total * 100;
	double truck = total_truck / total * 100;
	double train = total_train / total * 100;

	cout << fixed << setprecision(2) << average << endl;
	cout << fixed << setprecision(2) << minibus << "%" << endl;
	cout << fixed << setprecision(2) << truck << "%" << endl;
	cout << fixed << setprecision(2) << train << "%" << endl;

    return 0;
}

