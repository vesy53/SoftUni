// p04.PartitionWithoutResidue.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{

	int n;
	cin >> n;

	double counter_1 = 0;
	double counter_2 = 0;
	double counter_3 = 0;

	for (int i = 1; i <= n; i++)
	{
		int number;
		cin >> number;

		if (number % 2 == 0)
		{
			counter_1++;
		}
		if (number % 3 == 0)
		{
			counter_2++;
		}
		if (number % 4 == 0)
		{
			counter_3++;
		}
	}

	double total_cout_1 = counter_1 / n * 100;
	double total_cout_2 = counter_2 / n * 100;
	double total_cout_3 = counter_3 / n * 100;
 
	cout << fixed << setprecision(2) << total_cout_1 << "%" << endl;
	cout << fixed << setprecision(2) << total_cout_2 << "%" << endl;
	cout << fixed << setprecision(2) << total_cout_3 << "%" << endl;

    return 0;
}

