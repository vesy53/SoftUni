// p01.Birthday.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double lenght_sm;
	double width_sm;
	double height_sm;
	double percentage;
	cin >> lenght_sm >> width_sm >> height_sm >> percentage;

	double total = lenght_sm * width_sm * height_sm;
	double total_liters = total * 0.001;
	percentage *= 0.01;
	double result = total_liters * (1 - percentage);

	cout << fixed << setprecision(3) << result << endl;

    return 0;
}

