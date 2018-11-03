// SmallShop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	string product_name, town_name;
	double quantity;
	double total_price;
	cin >> product_name >> town_name >> quantity;

	if (town_name == "Sofia")
	{
		if (product_name == "coffee")
		{
			total_price = 0.5 * quantity;
		}
		else if (product_name == "water")
		{
			total_price = 0.8 * quantity;
		}
		else if (product_name == "beer")
		{
			total_price = 1.2 * quantity;
		}
		else if (product_name == "sweets")
		{
			total_price = 1.45 * quantity;
		}
		else if (product_name == "peanuts")
		{
			total_price = 1.6 * quantity;
		}
	}
	else if (town_name == "Plovdiv")
	{
		if (product_name == "coffee")
		{
			total_price = 0.4 * quantity;
		}
		else if (product_name == "water")
		{
			total_price = 0.7 * quantity;
		}
		else if (product_name == "beer")
		{
			total_price = 1.15 * quantity;
		}
		else if (product_name == "sweets")
		{
			total_price = 1.30 * quantity;
		}
		else if (product_name == "peanuts")
		{
			total_price = 1.5 * quantity;
		}
	}
	else if (town_name == "Varna")
	{
		if (product_name == "coffee")
		{
			total_price = 0.45 * quantity;
		}
		else if (product_name == "water")
		{
			total_price = 0.7 * quantity;
		}
		else if (product_name == "beer")
		{
			total_price = 1.10 * quantity;
		}
		else if (product_name == "sweets")
		{
			total_price = 1.35 * quantity;
		}
		else if (product_name == "peanuts")
		{
			total_price = 1.55 * quantity;
		}
	}

	cout << total_price << endl;

    return 0;
}

