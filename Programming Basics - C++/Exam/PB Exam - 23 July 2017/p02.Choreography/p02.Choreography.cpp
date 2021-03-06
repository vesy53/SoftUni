// p02.Choreography.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	double steps;
	double dancers;
	double days_for_learning;
	cin >> steps >> dancers >> days_for_learning;

	double steps_for_day = (steps / days_for_learning) / steps;
	steps_for_day = ceil(steps_for_day * 100);
	double percent_per_dancer = steps_for_day / dancers;

	if (steps_for_day <= 13)
	{
		cout << "Yes, they will succeed in that goal! " 
			<< fixed << setprecision(2) << percent_per_dancer 
			<< "%." 
			<< endl;
	}
	else if (steps_for_day > 13)
	{
		cout << "No, They will not succeed in that goal! Required " 
			<< fixed << setprecision(2) << percent_per_dancer 
			<< "% steps to be learned per day." 
			<< endl;
	}

    return 0;
}

