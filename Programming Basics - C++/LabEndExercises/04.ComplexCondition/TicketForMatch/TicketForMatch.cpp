// TicketForMatch.cpp : Defines the entry point for the console application.
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
	double people;
	cin >> boudget >> category >> people;

	double transport_price;

	if (people >= 1 && people <= 4)
	{
		transport_price = boudget * 0.75;
	}
	else if (people >= 5 && people <= 9)
	{
		transport_price = boudget * 0.60;
	}
	else if (people >= 10 && people <= 24)
	{
		transport_price = boudget * 0.50;
	}
	else if (people >= 25 && people <= 49)
	{
		transport_price = boudget * 0.40;
	}
	else if (people >= 50)
	{
		transport_price = boudget * 0.25;
	}
	double money_left = boudget - transport_price;
	double money_tickets = 0.0;

	if (category == "VIP")
	{
	    double vip_price = 499.99;
	    money_tickets = people * vip_price;
	}
	else
	{
		double normal_price = 249.99;
		money_tickets = people * normal_price;
	}

	if (money_tickets <= money_left)
	{
		double money = money_left - money_tickets;
		cout << "Yes! You have " << fixed << setprecision(2) 
			 << money << " leva left." << endl;
	}
	else 
	{
		cout << "Not enough money! You need " << fixed << setprecision(2) 
			 << money_tickets - money_left << " leva." << endl;
	}

    return 0;
}

