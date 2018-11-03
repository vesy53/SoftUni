// OnTimeForExam.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int exam_hour, exam_minutes, arrival_hour, arrival_minutes;
	cin >> exam_hour >> exam_minutes >> arrival_hour >> arrival_minutes;

	int exam_total = exam_hour * 60 + exam_minutes;
	int arrival_total = arrival_hour * 60 + arrival_minutes;
	int difference = exam_total - arrival_total;

	if (difference <= 30 && difference >=0)
	{
		int different_minutes = difference % 60;

		cout << "On time" << endl;

		if (different_minutes != 0)
		{
			cout << different_minutes << " minutes before the start" << endl;
		}
	}
	else if (difference < 0)
	{
		difference = abs(difference);
		int difference_hours = difference / 60;
		int difference_minutes = difference % 60;

		cout << "Late" << endl;
		if (difference_hours !=0)
		{
			cout << difference_hours << ":" << setw(2) << setfill('0')
				 << difference_minutes << " hours after the start" << endl;
		}
		else 
		{
			cout << difference_minutes << " minutes after the start" << endl;
		}
	}
	else if (difference > 30)
	{
		int different_hours = difference / 60;
		int different_minutes = difference % 60;
		cout << "Early" << endl;
		if (different_hours != 0)
		{
			cout << different_hours << ":" << setw(2) << setfill('0')
				 << different_minutes << " hours before the start" << endl;
		}
		else
		{
			cout << different_minutes << " minutes before the start" << endl;
		}
	}

	return 0;
}
