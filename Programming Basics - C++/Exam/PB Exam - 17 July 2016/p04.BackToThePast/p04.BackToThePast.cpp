// p04.BackToThePast.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	double inherited_money;
	int year_to_live;
	cin >> inherited_money >> year_to_live;

	int years = 17;

	for (int i = 1800; i <= year_to_live; i++)
	{
		years++;

		if (i % 2 == 0)
		{
			inherited_money -= 12000;
		}
		else
		{
			inherited_money -= 12000 + 50 * years;
		}
	}

	if (inherited_money >= 0)
	{
		cout << "Yes! He will live a carefree life and will have "
			<< fixed << setprecision(2) << inherited_money
			<< " dollars left."
			<< endl;
	}
	else if (inherited_money < 0)
	{
		cout << "He will need "
			<< fixed << setprecision(2) << abs(inherited_money)
			<< " dollars to survive."
			<< endl;
	}

    return 0;
}

