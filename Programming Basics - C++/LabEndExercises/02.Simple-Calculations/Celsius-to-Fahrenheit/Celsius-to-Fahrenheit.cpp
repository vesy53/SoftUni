// Celsius-to-Fahrenheit.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	double celsius;
	cin >> celsius;

	double fahrenheit = celsius * 1.8 + 32;

	cout << fahrenheit << endl;

    return 0;
}

