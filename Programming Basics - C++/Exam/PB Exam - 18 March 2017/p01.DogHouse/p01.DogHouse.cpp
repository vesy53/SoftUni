// p01.DogHouse.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double width_side;
	double height;
	cin >> width_side >> height;

	double total_width = width_side * (width_side / 2) * 2;
	double square = width_side / 2 * width_side / 2;
	double triangle = (width_side / 2 * (height - width_side / 2)) / 2;
	double rear_wall = square + triangle;
	double door = width_side / 5 * width_side / 5;
	double front_wall = rear_wall - door;
	double total = total_width + rear_wall + front_wall;
	double green_paint = total / 3;
	double roof = width_side * (width_side / 2) * 2;
	double red_paint = roof / 5;

	cout << fixed << setprecision(2) << green_paint << endl;
	cout << fixed << setprecision(2) << red_paint << endl;

    return 0;
}

