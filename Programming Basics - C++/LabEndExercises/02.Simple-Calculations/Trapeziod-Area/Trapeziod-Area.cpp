// Trapeziod-Area.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	double lower_side_of_trapezoid, upper_side_of_trapezoid, height_of_trapezoid;

	cin >> lower_side_of_trapezoid >> upper_side_of_trapezoid >> height_of_trapezoid;

	double area = (lower_side_of_trapezoid + upper_side_of_trapezoid) * height_of_trapezoid / 2;

	cout << area << endl;

    return 0;
}

