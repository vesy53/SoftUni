// p01.FavorizingCampaign.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int days;
	int confectioners;
	int num_cake;
	int num_waffles;
	int num_pancake;
	cin >> days >> confectioners >> num_cake >> num_waffles >> num_pancake;

	double price_cake = num_cake * 45;
	double price_waffers = num_waffles * 5.80;
	double price_pancake = num_pancake * 3.20;
	double total_price =
		(price_cake + price_waffers + price_pancake) * confectioners;

	double total_sum = total_price * days;
	total_sum -= total_sum * 1 / 8;

	cout << fixed << setprecision(2) << total_sum << endl;

    return 0;
}

