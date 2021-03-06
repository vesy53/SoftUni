// p04.SmartLily.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int age;
	double washing_machine_price;
	double toys_price;
	cin >> age >> washing_machine_price >> toys_price;

	double toys = 0.0;
	double money = 0.0;

	for (int i = 1; i <= age; i++)
	{
		if (i % 2 == 1)
		{
			toys++;
		}
		else if (i % 2 == 0)
		{
			money += toys * 10;
			money--;
		}
	}

	double total_toys = toys_price * toys;
	double result = money + total_toys;

	if (result >= washing_machine_price)
	{
		result -= washing_machine_price;

		cout << "Yes! " 
			<< fixed << setprecision(2) << result 
			<< endl;
	}
	else if (result < washing_machine_price)
	{
		washing_machine_price -= result;

		cout << "No! " 
			<< fixed << setprecision(2) << washing_machine_price 
			<< endl;;
	}

    return 0;
}

