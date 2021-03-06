// p01.HousePrice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double small_room;
	double kitchen;
	double square_metre;
	cin >> small_room >> kitchen >> square_metre;

	double bathroom = small_room / 2;
	double sec_room = small_room + small_room * 0.1;
	double third_room = sec_room + sec_room * 0.1;
	double total = small_room + kitchen + bathroom + sec_room + third_room;
	double koridor = total * 0.05;
	total += koridor;

	double total_price = total * square_metre;

	cout << fixed << setprecision(2) << total_price << endl;

    return 0;
}

