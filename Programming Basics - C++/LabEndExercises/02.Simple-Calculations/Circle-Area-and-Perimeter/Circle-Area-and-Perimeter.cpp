// Circle-Area-and-Perimeter.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


int main()
{
	double radius;
	double pi = 3.14159265359;

	cin >> radius;

	double area = pi * radius * radius;
	double perimeter = 2 * pi * radius;

	cout << area << endl;
	cout << perimeter << endl;

    return 0;
}

