// p03.Journey.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
	double boudget;
	string season;
	cin >> boudget >> season;

	string place = "";

	if (boudget <= 100)
	{
		cout << "Somewhere in Bulgaria" << endl;;

		if (season == "summer")
		{
			boudget *= 0.3;
			place = "Camp";
		}
		else if (season == "winter")
		{
			boudget *= 0.7;
			place = "Hotel";
		}
	}
	else if (boudget <= 1000)
	{
		cout << "Somewhere in Balkans" << endl;

		if (season == "summer")
		{
			boudget *= 0.4;
			place = "Camp";
		}
		else if (season == "winter")
		{
			boudget *= 0.8;
			place = "Hotel";
		}
	}
	else if (boudget > 1000)
	{
		cout << "Somewhere in Europe" << endl;

		boudget *= 0.9;
		place = "Hotel";
	}

	cout << place << " - " 
		<< fixed << setprecision(2) << boudget 
		<< endl;
	
    return 0;
}

