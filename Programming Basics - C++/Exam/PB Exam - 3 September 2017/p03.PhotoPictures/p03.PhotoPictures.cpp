// p03.PhotoPictures.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int num_photos;
	string type_photos;
	string way_order;
	cin >> num_photos >> type_photos >> way_order;

	double price = 0;

	if (type_photos == "9X13")
	{
		price = num_photos * 0.16;

		if (num_photos >= 50)
		{
			price *= 0.95;
		}
	}
	else if (type_photos == "10X15")
	{
		price = num_photos * 0.16;

		if (num_photos >= 80)
		{
			price *= 0.97;
		}
	}
	else if (type_photos == "13X18")
	{
		price = num_photos * 0.38;

		if (num_photos >= 50 && num_photos <= 100)
		{
			price *= 0.97;
		}
		else if (num_photos > 100)
		{
			price *= 0.95;
		}
	}
	else if (type_photos == "20X30")
	{
		price = num_photos * 2.90;

		if (num_photos >= 10 && num_photos <= 50)
		{
			price *= 0.93;
		}
		else if (num_photos > 50)
		{
			price *= 0.91;
		}
	}

	if (way_order == "online")
	{
		price *= 0.98;
	}

	cout << fixed << setprecision(2) << price << "BGN" << endl;

    return 0;
}

