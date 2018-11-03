// p02.TheSleepingCatTom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	int num_of_days_off;
	cin >> num_of_days_off;

	int holiday_days = num_of_days_off * 127;
	int work_days = (365 - num_of_days_off) * 63;
	int total = holiday_days + work_days;

	if (total <= 30000)
	{
		int result = 30000 - total;
		double hours = floor(result / 60);
		double minutes = result % 60;

		cout << "Tom sleeps well" << endl;
		cout << hours 
			<< "hours and "
			<< minutes 
			<< " minutes less for play" 
			<< endl;
	}
	else if (total > 30000)
	{
		total -= 30000;
		double hours = total / 60;
		double minutes = total % 60;

		cout << "Tom will run away" << endl;
		cout << hours 
			<< "hours and " 
			<< minutes 
			<< "minutes more for play" 
			<< endl;;
	}

    return 0;
}

