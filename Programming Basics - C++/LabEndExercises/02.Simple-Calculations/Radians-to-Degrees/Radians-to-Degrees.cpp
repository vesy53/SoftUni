// Radians-to-Degrees.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double radians;
	cin >> radians;

	double pi = 3.1415;
	double degree = radians * (180 / pi);

	cout << fixed << setprecision(0) << degree << endl;

    return 0;
}

