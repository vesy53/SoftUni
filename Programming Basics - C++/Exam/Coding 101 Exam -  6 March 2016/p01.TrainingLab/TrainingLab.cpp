// p01.TrainingLab.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double width;
	double height;
	cin >> width >> height;

	height *= 100;
	double corridor = 100;
	double desk_of_height = floor((height - corridor) / 70);
	width *= 100;
	double desk_of_width = floor(width / 120);
	double total = (desk_of_height * desk_of_width) - 3;

	cout << total << endl;

    return 0;
}

