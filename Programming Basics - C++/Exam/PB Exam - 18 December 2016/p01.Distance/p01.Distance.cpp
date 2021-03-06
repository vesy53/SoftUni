// p01.Distance.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double speed;
	double first_time;
	double sec_time;
	double third_time;
	cin >> speed >> first_time >> sec_time >> third_time;

	double hour = 0.0166666667;

	double distanceSpeed = speed * (first_time * hour);
	double increase = speed + speed * 0.1;
	sec_time *= hour * increase;
	double decrease = increase - increase * 0.05;
	third_time *= hour * decrease;
	double total = distanceSpeed + sec_time + third_time;

	cout << fixed << setprecision(2) << total << endl;

    return 0;
}

