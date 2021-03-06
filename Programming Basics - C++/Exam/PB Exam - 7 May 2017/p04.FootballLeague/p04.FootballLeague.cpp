// p04.FootballLeague.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	double capacity_stadium;
	double num_fans;
	cin >> capacity_stadium >> num_fans;

	double counter_A = 0;
	double counter_B = 0;
	double counter_V = 0;
	double counter_G = 0;

	for (int i = 0; i < num_fans; i++)
	{
		string sector;
		cin >> sector;

		if (sector == "A")
		{
			counter_A++;
		}
		else if (sector == "B")
		{
			counter_B++;
		}
		else if (sector == "V")
		{
			counter_V++;
		}
		else if (sector == "G")
		{
			counter_G++;
		}
	}

	cout << fixed << setprecision(2) << counter_A / num_fans * 100 
		<< "%" 
		<< endl;
	cout << fixed << setprecision(2) << counter_B / num_fans * 100 
		<< "%" 
		<< endl;
	cout << fixed << setprecision(2) << counter_V / num_fans * 100 
		<< "%" 
		<< endl;
	cout << fixed << setprecision(2) << counter_G / num_fans * 100 
		<< "%" 
		<< endl;
	cout << fixed << setprecision(2) << num_fans / capacity_stadium * 100 
		<< "%"
		<< endl;

    return 0;
}

