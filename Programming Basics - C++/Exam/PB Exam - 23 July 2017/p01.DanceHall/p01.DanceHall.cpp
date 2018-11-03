// p01.DanceHall.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double height_m;
	double width_m;
	double side_wardrobe_m;
	cin >> height_m >> width_m >> side_wardrobe_m;

	double total_hall = (height_m * 100) * (width_m * 100);
	double wardrobe = (side_wardrobe_m * 100) * (side_wardrobe_m * 100);
	double bench = total_hall / 10;
	double free_space = total_hall - wardrobe - bench;
	double dancers = free_space / (40 + 7000);

	cout << floor(dancers) << endl;

    return 0;
}

