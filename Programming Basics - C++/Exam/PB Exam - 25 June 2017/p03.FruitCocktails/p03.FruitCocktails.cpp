// p03.FruitCocktails.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string fruit;
	string size_cocktail;
	int drinks_ordered;
	cin >> fruit >> size_cocktail >> drinks_ordered;

	double price = 0;

	if (fruit == "Watermelon")
	{
		if (size_cocktail == "small")
		{
			price = 2 * 56;
		}
		else if (size_cocktail == "big")
		{
			price = 5 * 28.70;
		}
	}
	else if (fruit == "Mango")
	{
		if (size_cocktail == "small")
		{
			price = 2 * 36.66;
		}
		else if (size_cocktail == "big")
		{
			price = 5 * 19.60;
		}
	}
	else if (fruit == "Pineapple")
	{
		if (size_cocktail == "small")
		{
			price = 2 * 42.1;
		}
		else if (size_cocktail == "big")
		{
			price = 5 * 24.8;
		}
	}
	else if (fruit == "Raspberry")
	{
		if (size_cocktail == "small")
		{
			price = 2 * 20;
		}
		else if (size_cocktail == "big")
		{
			price = 5 * 15.2;
		}
	}

	double total = price * drinks_ordered;

	if (total > 1000)
	{
		total -= total * 0.5;
	}
	else if (total >= 400 && total <= 1000)
	{
		total -= total * 0.15;
	}

	cout << fixed << setprecision(2) << total << " lv." << endl;

    return 0;
}

