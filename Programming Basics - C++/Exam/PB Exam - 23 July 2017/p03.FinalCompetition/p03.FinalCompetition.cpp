// p03.FinalCompetition.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double dancers;
	double points;
	string season;
	string place;
	cin >> dancers >> points >> season >> place;

	double cash_prize = dancers * points;
	double money_costs = 0.0;

	if (season == "summer")
	{
		if (place == "Bulgaria")
		{
			money_costs = cash_prize - cash_prize * 0.05;
		}
		else if (place == "Abroad")
		{
			cash_prize += cash_prize * 0.5;
			money_costs = cash_prize - cash_prize * 0.1;
		}
	}
	else if (season == "winter")
	{
		if (place == "Bulgaria")
		{
			money_costs = cash_prize - cash_prize * 0.08;
		}
		else if (place == "Abroad")
		{
			cash_prize += cash_prize * 0.5;
			money_costs = cash_prize - cash_prize * 0.15;
		}
	}

	double money_charity = money_costs * 0.75;
	double total = money_costs - money_charity;
	double money_dancer = total / dancers;

	cout << "Charity - " 
		<< fixed << setprecision(2) << money_charity 
		<< endl;
	cout << "Money per dancer - " 
		<< fixed << setprecision(2) << money_dancer 
		<< endl;

    return 0;
}

