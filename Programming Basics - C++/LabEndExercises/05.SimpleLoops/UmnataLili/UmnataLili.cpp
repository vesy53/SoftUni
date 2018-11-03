// uprajnenie.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int age, price_of_toy;
	double washing_mashine_price;
	cin >> age >> washing_mashine_price >> price_of_toy;
	int number_of_toys = 0;
	int sum_of_money = 0;
	int increment = 10;

	for (int current_age = 1; current_age <= age; current_age++)
	{
		if (current_age % 2 == 0)
		{
			sum_of_money += increment;
			increment += 10;
			sum_of_money--;
		}
		else
		{
			number_of_toys++;
		}
	}
	int total_sum_of_toys = number_of_toys * price_of_toy;
	int total_money = total_sum_of_toys + sum_of_money;
	if (total_money >= washing_mashine_price)
	{
		cout << "Yes! " << fixed << setprecision(2) 
			 << total_money - washing_mashine_price << endl;
	}
	else
	{
		cout << "No! " << fixed << setprecision(2) 
			 << washing_mashine_price - total_money << endl;
	}
    return 0;
}

