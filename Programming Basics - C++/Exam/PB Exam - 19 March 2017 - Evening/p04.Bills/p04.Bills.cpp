// p04.Bills.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int month;
	cin >> month;

	double total_elect = 0;
	double water = 20;
	double internet = 15;
	double other = 0;
	double tax = 0;
	double other_per_month = 0;

	for (int i = 0; i < month; i++)
	{
		double electricity;
		cin >> electricity;

		total_elect += electricity;

		other = electricity + water + internet;
		tax = other * 0.2;
		other_per_month += other + tax;
	}

	water *= month;
	internet *= month;
	double average =
		(total_elect + water + internet + other_per_month) / month;

	cout << "Electricity: " << fixed << setprecision (2) << total_elect << " lv" << endl;
	cout << "Water: " << fixed << setprecision(2) << water << " lv" << endl;
	cout << "Internet: " << fixed << setprecision(2) << internet << " lv" << endl;
	cout << "Other: " << fixed << setprecision(2) << other_per_month << " lv" << endl;
	cout << "Average: " << fixed << setprecision(2) << average << " lv" << endl;

    return 0;
}

