// p01.TailoringWorkshop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double num_table;
	double height;
	double width;
	cin >> num_table >> height >> width;

	double total_tablecloths =
		num_table * (height + 2 * 0.30) * (width + 2 * 0.30);
	double total_box = num_table * (height / 2) * (height / 2);
	double price_dollar = total_tablecloths * 7 + total_box * 9;
	double price_lv = price_dollar * 1.85;

	cout << fixed << setprecision(2) << price_dollar << " USD" << endl;
	cout << fixed << setprecision(2) << price_lv << " BGN" << endl;

    return 0;
}

