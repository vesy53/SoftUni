// p02.ChangeTiles.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	double money;
	double width_of_the_floor;
	double length_of_the_floor;
	double side_of_the_triangle;
	double height_of_the_triangle;
	double price_of_one_tile;
	double amount_for_the_master;
	cin >> money
		>> width_of_the_floor
		>> length_of_the_floor
		>> side_of_the_triangle
		>> height_of_the_triangle
		>> price_of_one_tile
		>> amount_for_the_master;

	double total_floor = width_of_the_floor * length_of_the_floor;
	double total_tile = side_of_the_triangle * height_of_the_triangle / 2;
	double needed_tile = ceil(total_floor / total_tile) + 5;
	double total_money = needed_tile * price_of_one_tile + amount_for_the_master;

	if (total_money <= money)
	{
		money -= total_money;

		cout << fixed << setprecision(2) << money
			<< " lv left."
			<< endl;
	}
	else if (total_money > money)
	{
		total_money -= money;

		cout << "You'll need "
			<< fixed << setprecision(2) << total_money
			<< " lv more."
			<< endl;
	}

    return 0;
}

