// p01.AlcoholMarket.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double price_whiskey;
	double quantity_beer;
	double quantity_wine;
	double quantity_rakia;
	double quantity_whiskey;
	cin >> price_whiskey 
		>> quantity_beer 
		>> quantity_wine 
		>> quantity_rakia 
		>> quantity_whiskey;

	double price_rakia = price_whiskey / 2;
	double price_wine = price_rakia - price_rakia * 0.4;
	double price_beer = price_rakia - price_rakia * 0.8;
	double sum_rakia = price_rakia * quantity_rakia;
	double sum_wine = price_wine * quantity_wine;
	double sum_beer = price_beer * quantity_beer;
	double sum_whisky = price_whiskey * quantity_whiskey;
	double total = sum_rakia + sum_wine + sum_beer + sum_whisky;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

