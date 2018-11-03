// DelenieBezOstatak.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int number;
	cin >> number;

	double prozent1 = 0;
	double prozent2 = 0;
	double prozent3 = 0;
	double count_p1 = 0;
	double count_p2 = 0;
	double count_p3 = 0;

	for (int i = 0; i < number; i++)
	{
		int current_number;
		cin >> current_number;

		if (current_number % 2 == 0)
		{
			count_p1++;
			prozent1 = count_p1 / number * 100;
		}
		if (current_number % 3 == 0)
		{
			count_p2++;
			prozent2 = count_p2 / number * 100;
		}
		if (current_number % 4 == 0)
		{
			count_p3++;
			prozent3 = count_p3 / number * 100;
		}
	}
	cout << fixed << setprecision(2) << prozent1 << "%" << endl;
	cout << fixed << setprecision(2) << prozent2 << "%" << endl;
	cout << fixed << setprecision(2) << prozent3 << "%" << endl;

    return 0;
}

