// PointnectangleBorder.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double x1, y1, x2, y2, x_of_point, y_of_point;
	cin >> x1 >> y1 >> x2 >> y2 >> x_of_point >> y_of_point;

	bool is_on_left_border, is_on_right_border, is_on_top_border, is_on_bottom_border;
	double left, right, top, bottom;
	left = fmin(x1, x2);
	right = fmax(x1, x2);
	top = fmin(y1, y2);
	bottom = fmax(y1, y2);
	is_on_left_border = left == x_of_point && y_of_point >= top && y_of_point <= bottom;
	is_on_right_border = right == x_of_point && y_of_point >= top && y_of_point <= bottom;
	is_on_top_border = top == y_of_point && x_of_point >= left && x_of_point <= right;
	is_on_bottom_border = bottom == y_of_point && x_of_point >= left && x_of_point <= right;

	bool is_on_border = is_on_left_border || is_on_right_border ||
		                is_on_top_border || is_on_bottom_border;

	if (is_on_border)
	{
		cout << "Border" << endl;
	}
	else
	{
		cout << "Inside / Outside" << endl;
	}

    return 0;
}

