// p02.Lutenitsa.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double tomatoes;
	double num_boxes;
	double num_jars;
	cin >> tomatoes >> num_boxes >> num_jars;

	double total_lutenitsa = tomatoes / 5;
	double jars = total_lutenitsa / 0.535;
	double boxes = jars / num_jars;

	cout << "Total lutenica: " 
		<< floor(total_lutenitsa) 
		<< " kilograms." 
		<< endl;

	if (boxes <= num_boxes)
	{
		double total_boxes = num_boxes - boxes;
		double total_jars = (num_boxes * num_jars) - jars;

		cout << floor(total_boxes) << " more boxes needed." << endl;
		cout << floor(total_jars) << " more jars needed." << endl;
	}
	else if (boxes > num_boxes)
	{
		boxes -= num_boxes;
		jars -= num_boxes * num_jars;

		cout << floor(boxes) << " boxes left." << endl;
		cout << floor(jars) << " jars left." << endl;
	}

    return 0;
}

