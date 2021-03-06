// p03.MatchTickets.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double boudget;
	string category;
	int num_of_person;
	cin >> boudget >> category >> num_of_person;

	double transport_price = 0;

	if (num_of_person >= 1 && num_of_person <= 4)
	{
		transport_price = boudget * 0.75;
	}
	else if (num_of_person >= 5 && num_of_person <= 9)
	{
		transport_price = boudget * 0.6;
	}
	else if (num_of_person >= 10 && num_of_person <= 24)
	{
		transport_price = boudget * 0.5;
	}
	else if (num_of_person >= 25 && num_of_person <= 49)
	{
		transport_price = boudget * 0.4;
	}
	else if (num_of_person >= 50)
	{
		transport_price = boudget * 0.25;
	}

	double total = boudget - transport_price;
	double price = 0;

	if (category == "Normal")
	{
		price = 249.99;
	}
	else if (category == "VIP")
	{
		price = 499.99;
	}

	double total_price = price * num_of_person;

	if (total_price < total)
	{
		total -= total_price;

		cout << "Yes! You have "
			<< fixed << setprecision(2) << total
			<< " leva left."
			<< endl;
	}
	else if (total_price >= total)
	{
		total_price -= total;

		cout << "Not enough money! You need "
			<< fixed << setprecision(2) << total_price
			<< " leva."
			<< endl;
	}

    return 0;
}

