// p01.VegetableExchange.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{

	double price_kg_vegetables;
	double price_kg_fruits;
	double total_price_vegetables;
	double total_price_fruits;
	cin >> price_kg_vegetables 
		>> price_kg_fruits 
		>> total_price_vegetables 
		>> total_price_fruits;

	price_kg_vegetables *= total_price_vegetables;
	price_kg_fruits *= total_price_fruits;
	double total = (price_kg_vegetables + price_kg_fruits) / 1.94;

	cout << total << endl;

    return 0;
}

