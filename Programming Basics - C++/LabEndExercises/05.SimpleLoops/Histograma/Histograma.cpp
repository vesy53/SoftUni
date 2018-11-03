// Histograma.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int in_number;
	cin >> in_number;

	double prozent1 = 0;
	double prozent2 = 0;
	double prozent3 = 0;
	double prozent4 = 0;
	double prozent5 = 0;
	int count_p1 = 0;
	int count_p2 = 0;
	int count_p3 = 0;
	int count_p4 = 0;
	int count_p5 = 0;

	for (int i = 0; i < in_number; i++)
	{
		int current_number;
		cin >> current_number;

		if (current_number < 200)
		{
			count_p1++;
			prozent1 = count_p1 * 100.0 / in_number;
		}
		else if (current_number >= 200 && current_number <= 399)
		{
			count_p2++;
			prozent2 = count_p2 * 100.0 / in_number;
		}
		else if (current_number >= 400 && current_number <= 599)
		{
			count_p3++;
			prozent3 = count_p3 * 100.0 / in_number;

		}
		else if (current_number >= 600 && current_number <= 799)
		{
			count_p4++;
			prozent4 = count_p4 * 100.0 / in_number;
		}
		else if (current_number >= 800)
		{ 
			count_p5++;
			prozent5 = count_p5 * 100.0 / in_number;
		}
	}
	cout << fixed << setprecision(2) << prozent1 << "%" << endl;
	cout << fixed << setprecision(2) << prozent2 << "%" << endl;
	cout << fixed << setprecision(2) << prozent3 << "%" << endl;
	cout << fixed << setprecision(2) << prozent4 << "%" << endl;
	cout << fixed << setprecision(2) << prozent5 << "%" << endl;

    return 0;
}

