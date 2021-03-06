// p03.OnTimeForTheExam.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	int hour_of_exam;
	int minutes_of_exam;
	int hour_of_arrival;
	int minutes_of_arrival;
	cin >> hour_of_exam 
		>> minutes_of_exam 
		>> hour_of_arrival 
		>> minutes_of_arrival;

	int total_min_of_exam = hour_of_exam * 60 + minutes_of_exam;
	int total_min_of_arrival = hour_of_arrival * 60 + minutes_of_arrival;
	int difference = total_min_of_exam - total_min_of_arrival;

	if (difference >= 0 && difference <= 30)
	{
		int diff_min = difference % 60;

		cout << "On time" << endl;

		if (diff_min != 0)
		{
			cout << diff_min 
				<< " minutes before the start" 
				<< endl;
		}
	}
	else if (difference < 0)
	{
		difference = abs(difference);
		int diff_hour = difference / 60;
		int diff_min = difference % 60;

		cout << "Late" << endl;

		if (diff_hour != 0)
		{
			cout << diff_hour << ":" 
				<< setfill('0') << setw(2) << diff_min 
				<< " hours after the start" 
				<< endl;
		}
		else
		{
			cout << diff_min 
				<< " minutes after the start" 
				<< endl;
		}
	}
	else if (difference > 30)
	{
		int diff_hours = difference / 60;
		int diff_min = difference % 60;

		cout << "Early" << endl;

		if (diff_hours != 0)
		{
			cout << diff_hours << ":" 
				<< setfill('0') << setw(2) << diff_min 
				<< " hours before the start" 
				<< endl;
		}
		else
		{
			cout << diff_min 
				<< " minutes before the start" 
				<< endl;
		}
	}

    return 0;
}

