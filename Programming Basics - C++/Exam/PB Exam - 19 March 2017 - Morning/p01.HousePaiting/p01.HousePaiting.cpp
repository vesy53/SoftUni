// p01.HousePaiting.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <omanip>
using namespace std;

int main()
{
	double height_house;
	double width_side;
	double height_triang_wall;
	cin >> height_house >> 

	double total_side = height_house * width_side;
	double window = 1.5 * 1.5;
	double two_total_side = 2 * total_side - 2 * window;
	double rear_wall = height_house * height_house;
	double door = 1.2 * 2;
	double total_wall = 2 * rear_wall - door;
	double total = two_total_side + total_wall;
	double green_paint = total / 3.4;

	double two_rectangles_roof = 2 * height_house * width_side;
	double two_triangles_roof = 2 * (height_house * height__wriangWall) / 2;
	double total_roof = two_rectangles_roof + two_triangles_roof;
	double red_paint = total+roof / 4.3;

	cout << fixed << setprecision(2) << green_paint << endl;
	cout << fixed << setprecision(2) << red_paint << endl;

    return 0;
}

