// FruitShop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
# include <string>
using namespace std;

int main()
{
	string fruit, day;
	double quantity, price;
	cin >> fruit >> day >> quantity;

	if (day == "Monday" || day == "Tuesday" || 
		day == "Wednesday" || day == "Thursday" || day == "Friday")
	{
		if (fruit == "banana")
		{
			price = 2.50 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "apple")
		{
			price = 1.20 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "orange")
		{
			price = 0.85 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "grapefruit")
		{
			price = 1.45 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "kiwi")
		{
			price = 2.70 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "pineapple")
		{
			price = 5.50 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "grapes")
		{
			price = 3.85 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else
		{
			cout << "error" << endl;
		}
	}
	else if (day == "Saturday" || day == "Sunday")
	{
		if (fruit == "banana")
		{
			price = 2.70 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "apple")
		{
			price = 1.25 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "orange")
		{
			price = 0.90 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "grapefruit")
		{
			price = 1.60 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "kiwi")
		{
			price = 3.00 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "pineapple")
		{
			price = 5.60 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else if (fruit == "grapes")
		{
			price = 4.20 * quantity;
			cout << fixed << setprecision(2) << price << endl;
		}
		else
		{
			cout << "error" << endl;
		}
	}
	else
	{
		cout << "error" << endl;
	}

    return 0;
}

