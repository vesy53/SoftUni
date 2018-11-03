// Volleyboll.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
using namespace std;

int main()
{
	string year;
	double holidays, weekends_return_homes;
	cin >> year >> holidays >> weekends_return_homes;
	
	double weekend = (48 - weekends_return_homes) * 3 / 4;
	double play_in_Sofia = holidays * 2 / 3;
	double total_play = weekend + play_in_Sofia + weekends_return_homes;

	if (year == "leap")
	{
		total_play *= 1.15;
	}

	cout << floor(total_play) << endl;
	
    return 0;
}

