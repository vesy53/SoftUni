// p01.Fishland.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double mackerel_price;
	double sprats_price;
	double palmwood;
	double horse_mackerel;
	double mussels;
	cin >> mackerel_price >> sprats_price >> palmwood >> horse_mackerel >> mussels;

	palmwood *= mackerel_price + mackerel_price * 0.6;
	horse_mackerel *= sprats_price + sprats_price * 0.8;
	mussels *= 7.50;

	double total = palmwood + horse_mackerel + mussels;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

