// Triangle-Area.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double width;
	double height;

	cin >> width >> height;

	double triangle_area = (width * height) / 2;

	cout << fixed << setprecision(2) << triangle_area << endl;

    return 0;
}

