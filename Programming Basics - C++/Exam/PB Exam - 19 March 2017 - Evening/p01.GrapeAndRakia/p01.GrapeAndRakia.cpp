// p01.GrapeAndRakia.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double area_vineyard;
	double kg_of_square_meter;
	double marriage;
	cin >> area_vineyard >> kg_of_square_meter >> marriage;

	double total = (area_vineyard * kg_of_square_meter) - marriage;
	double rakia = (total * 0.45) / 7.5;
	double price_rakia = rakia * 9.80;

	double sale = (total * 0.55) * 1.50;


	cout << fixed << setprecision(2) << price_rakia << endl;
	cout << fixed << setprecision(2) << sale << endl;

    return 0;
}

