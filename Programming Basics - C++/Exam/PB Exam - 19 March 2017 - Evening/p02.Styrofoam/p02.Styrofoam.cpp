// p02.Styrofoam.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	double boudget;
	double area_house;
	double num_window;
	double sq_m_in_one_package;
	double price_styrofoam;
	cin >> boudget >> area_house >> num_window >> sq_m_in_one_package >> price_styrofoam;

	double total_area = area_house - num_window * 2.4;
	total_area += total_area * 0.1;
	double needed_packages = ceil(total_area / sq_m_in_one_package);
	double price_packages = needed_packages * price_styrofoam;

	if (price_packages <= boudget)
	{
		boudget -= price_packages;

		cout << "Spent: " << fixed << setprecision(2) << price_packages << endl;
		cout << "Left: " << fixed << setprecision(2) << boudget << endl;
	}
	else if (price_packages > boudget)
	{
		price_packages -= boudget;

		cout << "Need more: " << fixed << setprecision(2) << price_packages << endl;
	}

    return 0;
}

