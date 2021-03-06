// p04.Grades.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int num_students;
	cin >> num_students;

	double counter_2 = 0;
	double counter_3 = 0;
	double counter_4 = 0;
	double counter_5 = 0;
	double total = 0;

	for (int i = 1; i <= num_students; i++)
	{
		double grade;
		cin >> grade;

		total += grade;

		if (grade <= 2.99)
		{
			counter_2++;
		}
		else if (grade >= 3 && grade <= 3.99)
		{
			counter_3++;
		}
		else if (grade >= 4 && grade <= 4.99)
		{
			counter_4++;
		}
		else if (grade >= 5)
		{
			counter_5++;
		}
	}

	cout << "Top students: "
		<< fixed << setprecision(2) << counter_5 / num_students * 100
		<< "%" << endl;
	cout << "Between 4.00 and 4.99: "
		<< fixed << setprecision(2) << counter_4 / num_students * 100
		<< "%" << endl;
	cout << "Between 3.00 and 3.99: "
		<< fixed << setprecision(2) << counter_3 / num_students * 100
		<< "%" << endl;
	cout << "Fail: "
		<< fixed << setprecision(2) << counter_2 / num_students * 100
		<< "%" << endl;
	cout << "Average: "
		<< fixed << setprecision(2) << total / num_students
		<< endl;

    return 0;
}

