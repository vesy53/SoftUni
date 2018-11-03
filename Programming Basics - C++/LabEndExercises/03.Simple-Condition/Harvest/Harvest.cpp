// Harvest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double vineyard, grapes, need_wine, workers;
	cin >> vineyard >> grapes >> need_wine >> workers;

	double total_grapes = vineyard * grapes;
	double wine = 0.4 * total_grapes / 2.5;
	double total_wine = wine - need_wine;
	double results = total_wine / workers;

	if (wine >= need_wine)
	{
		int floor_wine = floor(wine);
		int ceild_total_wine = ceil(total_wine);
		int ceild_results = ceil(results);
		cout << "Good harvest this year! Total wine: " << floor_wine << " liters." << endl;
		cout << ceild_total_wine << " liters left -> " << ceild_results << " liters per person." << endl;
	}
	else
	{
		total_wine = abs(total_wine);
		int floor_total_wine = floor(total_wine);
		cout << "It will be a tough winter! More " 		
			 << floor_total_wine << " liters wine needed." << endl;
	}
    return 0;
}

