// p02.WorldSwimmingRecord.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	double record_in_sec;
	double record_in_m;
	double time_in_sec_1_m;
	cin >> record_in_sec >> record_in_m >> time_in_sec_1_m;

	double result = record_in_m * time_in_sec_1_m;
	double total_time = floor(record_in_m / 15) * 12.5;
	double total = result + total_time;

	if (record_in_sec <= total)
	{
		total -= record_in_sec;

		cout << "No, he failed! He was " 
			<< fixed << setprecision(2) << total 
			<< " seconds slower." << endl;
	}
	else if (record_in_sec > total)
	{
		cout << "Yes, he succeeded! The new world record is "
			<< fixed << setprecision(2) << total 
			<< " seconds." << endl;
	}

    return 0;
}

