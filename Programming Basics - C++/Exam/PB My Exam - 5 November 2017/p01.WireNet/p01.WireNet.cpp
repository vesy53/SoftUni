// p01.WireNet.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double length_m;
	double width_m;
	double height_m;
	double price;
	double weight_sq_meter;

	double total_length = length_m * 2 + width_m * 2;
	price *= total_length;
	double area = total_length * height_m;
	weight_sq_meter *= area;

	cout << total_length << endl;
	cout << fixed << setprecision(2) << price << endl;
	cout << fixed << setprecision(3) << weight_sq_meter << endl;

    return 0;
}

