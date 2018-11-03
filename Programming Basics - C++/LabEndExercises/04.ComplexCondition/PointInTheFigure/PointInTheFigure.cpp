// PointInTheFigure.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	double h, x, y;
	cin >> h >> x >> y;

	h = 2;
	bool inside_f1 = x >= 0 && x <= h * 3 && y >= 0 && y <= h;
	bool inside_f2 = x > h && x <= h * 2 && y > h && y <= h * 4;
	bool inside_border = x > h && x < h * 2 && y == 0;
	bool left_side_f1 = x == 0 && y >= 0 && y <= h;
	bool right_side_f1 = x == h * 3 && y >= 0 && y <= h;
	bool bottom_f1 = x >= 0 && x <= h * 3 && y == 0;
	bool top_f1_and_inside_border = x >= 0 && x <= h && y == h 
		 || x >= h * 2 && x <= h * 3 && y == h;
	bool left_side_f2 = x == h && y >= h && y <= h * 4;
	bool right_side_f2 = x == h * 2 && y >= h && y <= h * 4;
	bool top_f2 = x >= h && x <= h * 2 && y == h * 4;

	if (inside_f1 || inside_f2 || inside_border)
	{
		cout << "inside" << endl;
	}
	else if (left_side_f1 && right_side_f2 && bottom_f1
		     && top_f1_and_inside_border && bottom_f1 
		     || left_side_f2 && right_side_f2 && top_f2)
	{
		cout << "border" << endl;
	}
	else
	{
		cout << "outside" << endl;
	}

    return 0;
}

