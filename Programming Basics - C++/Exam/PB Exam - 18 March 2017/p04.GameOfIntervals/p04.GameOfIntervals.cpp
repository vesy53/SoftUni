// p04.GameOfIntervals.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int num;
	cin >> num;

	double counter_1 = 0;
	double counter_2 = 0;
	double counter_3 = 0;
	double counter_4 = 0;
	double counter_5 = 0;
	double counter_6 = 0;
	double result = 0;

	for (int i = 0; i < num; i++)
	{
		int number;
		cin >> number;

		if (number >= 0 && number <= 9)
		{
			counter_1++;
			result += number * 0.2;
		}
		else if (number >= 10 && number <= 19)
		{
			counter_2++;
			result += number * 0.3;
		}
		else if (number >= 20 && number <= 29)
		{
			counter_3++;
			result += number * 0.4;
		}
		else if (number >= 30 && number <= 39)
		{
			counter_4++;
			result += 50;
		}
		else if (number >= 40 && number <= 50)
		{
			counter_5++;
			result += 100;
		}
		else if (number < 0 || number > 50)
		{
			counter_6++;
			result /= 2;
		}
	}

	cout << fixed << setprecision(2) << result << endl;
	cout << "From 0 to 9: "
		<< fixed << setprecision(2) << counter_1 / num * 100
		<< "%" 
		<< endl;
	cout << "From 10 to 19: "
		<< fixed << setprecision(2) << counter_2 / num * 100 
		<< "%" 
		<< endl;
	cout << "From 20 to 29: "
		<< fixed << setprecision(2) << counter_3 / num * 100
		<< "%" 
		<< endl;
	cout << "From 30 to 39: "
		<< fixed << setprecision(2) << counter_4 / num * 100
		<< "%"
		<< endl;
	cout << "From 40 to 50: "
		<< fixed << setprecision(2) << counter_5 / num * 100
		<< "%"
		<< endl;
	cout << "Invalid numbers: "
		<< fixed << setprecision(2) << counter_6 / num * 100
		<< "%"
		<< endl;

    return 0;
}

