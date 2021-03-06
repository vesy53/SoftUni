// p04.Histogram.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double number;
	cin >> number;

	double counter_1 = 0;
	double counter_2 = 0;
	double counter_3 = 0;
	double counter_4 = 0;
	double counter_5 = 0;

	for (int i = 1; i <= number; i++)
	{
		int num;

		if (num < 200)
		{
			counter_1++;
		}
		else if (num >= 200 && num <= 399)
		{
			counter_2++;
		}
		else if (num >= 400 && num <= 599)
		{
			counter_3++;
		}
		else if (num >= 600 && num <= 799)
		{
			counter_4++;
		}
		else if (num >= 800)
		{
			counter_5++;
		}
	}

	cout << fixed << setprecision(2) << counter_1 / number * 100 << "%" << endl;
	cout << fixed << setprecision(2) << counter_2 / number * 100 << "%" << endl;
	cout << fixed << setprecision(2) << counter_3 / number * 100 << "%" << endl;
	cout << fixed << setprecision(2) << counter_4 / number * 100 << "%" << endl;
	cout << fixed << setprecision(2) << counter_5 / number * 100 << "%" << endl;

    return 0;
}

