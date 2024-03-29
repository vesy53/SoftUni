// p02.Harvest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double vineyard;
	double grapes;
	double liters_of_wine_needed;
	double num_of_workers;
	cin >> vineyard >> grapes >> liters_of_wine_needed >> num_of_workers;

	vineyard *= grapes;
	double wine = vineyard * 0.4 / 2.5;

	if (wine < liters_of_wine_needed)
	{
		liters_of_wine_needed -= wine;

		cout << "It will be a tough winter! More "
			 << floor(liters_of_wine_needed)
			 << " liters wine needed."
			 << endl;
	}
	else if (wine >= liters_of_wine_needed)
	{
		double total_wine = ceil(wine - liters_of_wine_needed);
		double liters_per_person = ceil(total_wine / num_of_workers);

		cout << "Good harvest this year! Total wine: "
			<< floor(wine)
			<< " liters."
			<< endl;
		cout << total_wine 
			<< "liters left -> " 
			<< liters_per_person 
			<< " liters per person." 
			<< endl;
	}
    return 0;
}

