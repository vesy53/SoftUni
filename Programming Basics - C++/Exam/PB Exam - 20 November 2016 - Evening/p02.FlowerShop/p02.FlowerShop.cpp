// p02.FlowerShop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	int magnolia;
	int zymbuly;
	int roses;
	int cacti;
	double price_gift;
	cin >> magnolia >> zymbuly >> roses >> cacti >> price_gift;

	double price_magnolia = 3.25 * magnolia;
	double price_zymbul = 4.0 * zymbuly;
	double price_roses = 3.50 * roses;
	double price_cacti = 8.0 * cacti;

	double total = price_magnolia + price_zymbul + price_roses + price_cacti;
	double tax = total * 0.05;
	total -= tax;

	if (price_gift <= total)
	{
		total -= price_gift;

		cout << "She is left with " << floor(total) << " leva." << endl;
	}
	else if (price_gift > total)
	{
		price_gift -= total;

		cout << "She will have to borrow " << ceil(price_gift) << " leva." << endl;
	}

    return 0;
}

