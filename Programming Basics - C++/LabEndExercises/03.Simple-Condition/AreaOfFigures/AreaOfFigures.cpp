// AreaOfFigures.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double area;
	string geometry_figure;
    cin >> geometry_figure; 

	if (geometry_figure == "rectangle")
	{
		double width, hight;
		cin >> width >> hight;
		area = width * hight;
	}
	else if (geometry_figure == "triangle")
	{
		double width, hight;
		cin >> width >> hight;
		area = width * hight / 2;
	}
	else if (geometry_figure == "square")
	{  
		double width;
		cin >> width;
		area = width * width;
	}
	else if (geometry_figure == "circle")
	{
		double radius;
		cin >> radius;
		area = 3.14159265359 * radius * radius;
	}

	cout << fixed << setprecision(3) << area << endl;

    return 0;
}

