// zada4a13.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	double heigth;
	double width;
	cin >> heigth >> width;

	double lengh_room = (width * 100) - 100;
	double seets_row = floor(lengh_room / 70);
	double seets_room = heigth * 100;
	double seets_number = floor(width / 120);
	double total_seats = (seets_room * seets_number) - 3;
	cout << total_seats << endl;

    return 0;
}

