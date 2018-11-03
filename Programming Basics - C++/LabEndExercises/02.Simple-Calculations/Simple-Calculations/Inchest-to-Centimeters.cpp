// Inchiest-to-centimeters.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	double inches;
	cin >> inches;
	double centimeters = inches * 2.54;
	cout << centimeters << endl;

	return 0;
}

