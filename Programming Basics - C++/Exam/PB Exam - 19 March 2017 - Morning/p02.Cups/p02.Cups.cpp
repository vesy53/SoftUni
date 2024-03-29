// p02.Cups.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	double needed_cups;
	double worker;
	double work_day;
	cin >> needed_cups >> worker >> work_day;

	double total_hours = worker * work_day * 8;
	double work_cups = floor(total_hours / 5);
	double price = 0;

	if (work_cups <= needed_cups)
	{
		needed_cups -= work_cups;
		price = needed_cups * 4.2;

		cout << "Losses: " 
			<< fixed << setprecision(2) << price 
			<< endl;
	}
	else if (work_cups > needed_cups)
	{
		work_cups -= needed_cups;
		price = work_cups * 4.2;

		cout << fixed << setprecision(2) << price 
			<< " extra money" 
			<< endl;
	}

    return 0;
}

