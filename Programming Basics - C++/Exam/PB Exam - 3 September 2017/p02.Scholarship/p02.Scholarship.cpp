// p02.Scholarship.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double income_BGN;
	double average_success;
	double min_salary;
	cin >> income_BGN >> average_success >> min_salary;

	double social = 0;
	double exellent = 0;

	if (average_success >= 5.50)
	{
		exellent = floor(average_success * 25);
	}

	if (income_BGN <= min_salary && average_success > 4.50)
	{
		social = floor(min_salary * 0.35);
	}

	if (income_BGN < min_salary && average_success < 4.50)
	{
		cout << "You cannot get a scholarship!" << endl;
	}
	else if (income_BGN > min_salary && average_success < 5.50)
	{
		cout << "You cannot get a scholarship!" << endl;
	}
	else if (social > exellent)
	{
		cout << "You get a Social scholarship " 
			<< social << " BGN" << endl;
	}
	else if (social <= exellent)
	{
		cout << "You get a scholarship for excellent results " 
			<< exellent << " BGN" << endl;
	}

    return 0;
}

