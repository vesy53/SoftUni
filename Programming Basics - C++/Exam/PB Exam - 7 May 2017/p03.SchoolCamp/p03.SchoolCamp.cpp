// p03.SchoolCamp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string season;
	string type_group;
	int num_students;
	int num_night;
	cin >> season >> type_group >> num_students >> num_night;

	double price = 0;
	string type_sport = "";

	if (season == "Winter")
	{
		if (type_group == "girls")
		{
			price = 9.6;
			type_sport = "Gymnastics";
		}
		else if (type_group == "boys")
		{
			price = 9.6;
			type_sport = "Judo";
		}
		else if (type_group == "mixed")
		{
			price = 10;
			type_sport = "Ski";
		}
	}
	else if (season == "Spring")
	{
		if (type_group == "girls")
		{
			price = 7.2;
			type_sport = "Athletics";
		}
		else if (type_group == "boys")
		{
			price = 7.2;
			type_sport = "Tennis";
		}
		else if (type_group == "mixed")
		{
			price = 9.50;
			type_sport = "Cycling";
		}
	}
	else if (season == "Summer")
	{
		if (type_group == "girls")
		{
			price = 15;
			type_sport = "Volleyball";
		}
		else if (type_group == "boys")
		{
			price = 15;
			type_sport = "Football";
		}
		else if (type_group == "mixed")
		{
			price = 20;
			type_sport = "Swimming";
		}
	}

	double total_price = num_students * num_night * price;

	if (num_students >= 50)
	{
		total_price -= total_price * 0.5;
	}
	else if (num_students >= 20 && num_students < 50)
	{
		total_price -= total_price * 0.15;
	}
	else if (num_students >= 10 && num_students < 20)
	{
		total_price -= total_price * 0.05;
	}

	cout << type_sport << " " 
		<< fixed << setprecision(2) << total_price
		<< " lv." 
		<< endl;

    return 0;
}

