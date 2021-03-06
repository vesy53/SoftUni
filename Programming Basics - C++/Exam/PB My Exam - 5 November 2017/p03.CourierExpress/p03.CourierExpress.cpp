// p03.CourierExpress.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double weight_kg;
	string type_service;
	double distance_km;
	cin >> weight_kg >> type_service >> distance_km;

	double price = 0;
	double overcharge = 0;
	double total_dist = 0;

	if (type_service == "standard")
	{
		if (weight_kg <= 1)
		{
			price = 0.03;
		}
		else if (weight_kg > 1 && weight_kg <= 10)
		{
			price = 0.05;
		}
		else if (weight_kg >= 11 && weight_kg <= 40)
		{
			price = 0.10;
		}
		else if (weight_kg >= 41 && weight_kg <= 90)
		{
			price = 0.15;
		}
		else if (weight_kg >= 91 && weight_kg <= 150)
		{
			price = 0.20;
		}

		total_dist = distance_km * price;
	}
	else if (type_service == "express")
	{
		if (weight_kg <= 1)
		{
			price = 0.03;
			overcharge = 0.03 * 0.8;
		}
		else if (weight_kg > 1 && weight_kg <= 10)
		{
			price = 0.05;
			overcharge = 0.05 * 0.4;
		}
		else if (weight_kg >= 11 && weight_kg <= 40)
		{
			price = 0.10;
			overcharge = 0.10 * 0.05;
		}
		else if (weight_kg >= 41 && weight_kg <= 90)
		{
			price = 0.15;
			overcharge = 0.15 * 0.02;
		}
		else if (weight_kg >= 91 && weight_kg <= 150)
		{
			price = 0.20;
			overcharge = 0.20 * 0.01;
		}

		double total = distance_km * price;
		double result = distance_km * weight_kg * overcharge;
		total_dist = total + result;
	}

	cout << "The delivery of your shipment with weight of " 
		<< fixed << setprecision(3) << weight_kg
		<< " kg. would cost " 
		<< fixed << setprecision(2) << total_dist 
		<< " lv." 
		<< endl;

    return 0;
}

