// p01.TileRepair.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double length_landing;
	double width_of_tile;
	double length_of_tile;
	double width_of_bench;
	double length_of_bench;
	cin >> length_landing 
		>> width_of_tile 
		>> length_of_tile 
		>> width_of_bench 
		>> length_of_bench;

	double total_landing = length_landing * length_landing;
	double total_bench = width_of_bench * length_of_bench;
	double coverage_area = total_landing - total_bench;
	double coverage_tile = width_of_tile * length_of_tile;
	double total_tile = coverage_area / coverage_tile;
	double total_times = total_tile * 0.2;

	cout << fixed << setprecision(2) << total_tile << endl;
	cout << fixed << setprecision(2) << total_times << endl;

    return 0;
}

