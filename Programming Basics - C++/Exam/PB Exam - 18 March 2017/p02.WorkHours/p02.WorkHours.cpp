// p02.WorkHours.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int needed_hours;
	int workers;
	int work_days;
	cin >> needed_hours >> workers >> work_days;

	int total_hour = workers * work_days * 8;

	if (total_hour <= needed_hours)
	{
		needed_hours -= total_hour;
		double penalties = needed_hours * work_days;

		cout << neededHours << " overtime " << endl;
		cout << "Penalties: " << penalties << endl;;
	}
	else if (total_hour > needed_hours)
	{
		totalHour -= needed_hours;

		cout << totalHour << " hours left");
	}

    return 0;
}

