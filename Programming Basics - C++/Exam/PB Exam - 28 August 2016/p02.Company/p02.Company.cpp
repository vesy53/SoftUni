// p02.Company.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double needed_hours;
	int days;
	int num_person;

	double day_for_training = (days - days * 0.1) * 8;
	num_person *= 2 * days;
	double total_hours = floor(day_for_training + num_person);

	if (total_hours >= needed_hours)
	{
		total_hours -= needed_hours;

		cout << "Yes!" << total_hours << " hours left." << endl;
	}
	else if (total_hours < needed_hours)
	{
		needed_hours -= total_hours;

		cout << "Not enough time!" << needed_hours << " hours needed." << endl;
	}

    return 0;
}

