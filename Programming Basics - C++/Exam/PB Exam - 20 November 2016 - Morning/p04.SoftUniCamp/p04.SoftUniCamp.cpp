// p04.SoftUniCamp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int groups;
	cin >> groups;

	double car = 0;
	double minibus = 0;
	double small_bus = 0;
	double large_bus = 0;
	double train = 0;
	double total = 0;

	for (int i = 1; i <= groups; i++)
	{
		int num_person;
		cin >> num_person;

		total += num_person;

		if (num_person <= 5)
		{
			car += num_person;
		}
		else if (num_person >= 6 && num_person <= 12)
		{
			minibus += num_person;
		}
		else if (num_person >= 13 && num_person <= 25)
		{
			small_bus += num_person;
		}
		else if (num_person >= 26 && num_person <= 40)
		{
			large_bus += num_person;
		}
		else if (num_person >= 41)
		{
			train += num_person;
		}
	}

	cout << fixed << setprecision(2) << car / total * 100 << "%" << endl;
	cout << fixed << setprecision(2) << minibus / total * 100 << "%" << endl;
	cout << fixed << setprecision(2) << small_bus / total * 100 << "%" << endl;
	cout << fixed << setprecision(2) << large_bus / total * 100 << "%" << endl;
	cout << fixed << setprecision(2) << train / total * 100 << "%" << endl;

    return 0;
}

