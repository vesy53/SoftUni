// p04.ExternalEvaluation.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int num;
	cin >> num;

	double counter_2 = 0;
	double counter_3 = 0;
	double counter_4 = 0;
	double counter_5 = 0;
	double counter_6 = 0;

	for (int i = 0; i < num; i++)
	{
		double points;
		cin >> points;

		if (points >= 0 && points < 22.5)
		{
			counter_2++;
		}
		else if (points >= 22.5 && points < 40.5)
		{
			counter_3++;
		}
		else if (points >= 40.5 && points < 58.5)
		{
			counter_4++;
		}
		else if (points >= 58.5 && points < 76.5)
		{
			counter_5++;
		}
		else if (points >= 76.5 && points <= 100)
		{
			counter_6++;
		}
	}

	cout << fixed << setprecision(2) << counter_2 / num * 100 
		<< "% poor marks" << endl;
	cout << fixed << setprecision(2) << counter_3 / num * 100 
		<< "% satisfactory marks" << endl;
	cout << fixed << setprecision(2) << counter_4 / num * 100 
		<< "% good marks" << endl;
	cout << fixed << setprecision(2) << counter_5 / num * 100 
		<< "% very good marks" << endl;
	cout << fixed << setprecision(2) << counter_6 / num * 100 
		<< "% excellent marks" << endl;

    return 0;
}

